#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2015 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

#if UNITY_5 || UNITY_STANDALONE || UNITY_WEBPLAYER || UNITY_WII || UNITY_IPHONE || UNITY_ANDROID || UNITY_PS3 || UNITY_XBOX360 || UNITY_FLASH || UNITY_BKACKBERRY || UNITY_WINRT
#define UNITY
#endif

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
#if !WINDOWS_PHONE
#if !NET35 && !UNITY
#if !UNITY || MSGPACK_UNITY_FULL
using System.Numerics;
#endif // !UNITY || MSGPACK_UNITY_FULL
#endif // !NET35 && !UNITY
#endif // !WINDOWS_PHONE
using System.Runtime.Serialization;
#if FEATURE_TAP
using System.Threading;
using System.Threading.Tasks;
#endif // FEATURE_TAP
#if !MSTEST
using NUnit.Framework;
#else
using TestFixtureAttribute = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestClassAttribute;
using TestAttribute = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestMethodAttribute;
using TimeoutAttribute = NUnit.Framework.TimeoutAttribute;
using Assert = NUnit.Framework.Assert;
using Is = NUnit.Framework.Is;
#endif

namespace MsgPack.Serialization
{
	[TestFixture]
	public class RegressionTests
	{
#if !NETFX_CORE
		[Test]
		public void TestIssue70()
		{
			var serializer = MessagePackSerializer.Get<DBNull>( new SerializationContext() );
#if !UNITY
			// Should not be created dynamically.
			Assert.That( serializer, Is.TypeOf( typeof( DefaultSerializers.System_DBNullMessagePackSerializer ) ) );
#endif // !UNITY

			using ( var buffer = new MemoryStream() )
			{
				serializer.Pack( buffer, DBNull.Value );

				buffer.Position = 0;
				var packed = Unpacking.UnpackObject( buffer );
				Assert.That( packed.IsNil, packed.ToString() );

				buffer.Position = 0;
				var unpacked = serializer.Unpack( buffer );
				Assert.That( Object.ReferenceEquals( unpacked, null ), Is.False );
				Assert.That( unpacked, Is.SameAs( DBNull.Value ) );
			}
		}
#endif // !NETFX_CORE

		[Test]
		public void TestIssue73()
		{
			var original = SerializationContext.ConfigureClassic();
			try
			{
				var value =
					new Dictionary<string, object> { { "1", new object() }, { "2", new object() } };
				var serializer = MessagePackSerializer.Get<Dictionary<string, object>>( new SerializationContext() );
				using ( var buffer = new MemoryStream() )
				{
					Assert.Throws<SerializationException>( () => serializer.Pack( buffer, value ) );
				}
			}
			finally
			{
				SerializationContext.Default = original;
			}
		}

		[Test]
		public void TestIssue92_EmptyAsMpo()
		{
			var bytes = new byte[] { 0x82, 0xA1, 0x74, 0x81, 0xA1, 0x74, 0x04, 0xA4, 0x64, 0x61, 0x74, 0x61, 0x80 };
			using ( var buffer = new MemoryStream( bytes ) )
			{
				var serializer = MessagePackSerializer.Get<Dictionary<string, MessagePackObject>>( new SerializationContext() );
				var d = serializer.Unpack( buffer );
			}
		}

		[Test]
		public void TestIssue92_EmptyAsCollection()
		{
			var value = new int[][] { new[] { 1, 2 }, new int[ 0 ] };
			var serializer = MessagePackSerializer.Get<int[][]>( new SerializationContext() );
			using ( var buffer = new MemoryStream() )
			{
				serializer.Pack( buffer, value );
				buffer.Position = 0;
				var a = serializer.Unpack( buffer );
				Assert.That( a.Length, Is.EqualTo( 2 ) );
				Assert.That( a[ 0 ].Length, Is.EqualTo( 2 ) );
				Assert.That( a[ 0 ][ 0 ], Is.EqualTo( 1 ) );
				Assert.That( a[ 0 ][ 1 ], Is.EqualTo( 2 ) );
				Assert.That( a[ 1 ].Length, Is.EqualTo( 0 ) );
			}
		}

#if !SILVERLIGHT && !NETFX_CORE
		[Test]
		public void TestIssue99_HoGyuLee_AotForEnumKeyDictionary()
		{
			MessagePackSerializer.PrepareType<FileMode>();
			using ( var buffer = new MemoryStream( new byte[] { 0x81, 0x01, 0x00 } ) )
			{
				var serializer =
					MessagePackSerializer.Get<Dictionary<FileMode, int>>(
						PreGeneratedSerializerActivator.CreateContext(
							SerializationMethod.Array,
							PackerCompatibilityOptions.None
						)
					);
				var result = serializer.Unpack( buffer );
				Assert.That( result.Count, Is.EqualTo( 1 ) );
				var singleResult = default( KeyValuePair<FileMode, int> );
				foreach ( var kv in result )
				{
					singleResult = kv;
				}

				Assert.That( singleResult.Key, Is.EqualTo( ( FileMode )1 ) );
				Assert.That( singleResult.Value, Is.EqualTo( 0 ) );
			}
		}

		[Test]
		public void TestIssue124_AotForComplexValueType()
		{
			MessagePackSerializer.PrepareType<TestValueType>();
			var context =
				PreGeneratedSerializerActivator.CreateContext(
					SerializationMethod.Array,
					PackerCompatibilityOptions.None
				);
			context.Serializers.RegisterOverride( new TestValueTypeWrapperSerializer( context ) );
			var serializer = MessagePackSerializer.Get<TestValueTypeWrapper>( context );
			var target = new TestValueTypeWrapper { Value = new TestValueType { StringField = String.Empty } };
			using ( var buffer = new MemoryStream() )
			{
				serializer.Pack( buffer, target );
				buffer.Position = 0;
				var result = serializer.Unpack( buffer );
				Assert.That( result, Is.Not.Null );
				Assert.That( result.Value.StringField, Is.EqualTo( String.Empty ) );
				Assert.That( result.Value.Int32ArrayField, Is.Null );
				Assert.That( result.Value.DictionaryField, Is.Null );
			}
		}
#endif // !SLIVERLIGHT && !NETFX_CORE

#if !UNITY
		[Test]
		public void TestIssue111()
		{
			var context = new SerializationContext
			{
				SerializationMethod = SerializationMethod.Map,
				EnumSerializationOptions =
				{
					SerializationMethod = EnumSerializationMethod.ByName
				},
				CompatibilityOptions =
				{
					PackerCompatibilityOptions = PackerCompatibilityOptions.None
				}
			};

			var serializer = context.GetSerializer<Dictionary<string, object>>();

			var dict = new Dictionary<string, object>();
			dict[ "a" ] = "x";
			dict[ "b" ] = true;
			dict[ "c" ] = 5;
			dict[ "myclass" ] = new Issue111Class() { x = 8, y = "ola" };

			byte[] body = serializer.PackSingleObject( dict );

			using ( var stream = new MemoryStream( body ) )
			{
				var unpackedDictionary = Unpacking.UnpackDictionary( stream );
				Assert.That( unpackedDictionary.Count, Is.EqualTo( 4 ) );
				Assert.That( unpackedDictionary[ "a" ] == "x" );
				Assert.That( unpackedDictionary[ "b" ] == true );
				Assert.That( unpackedDictionary[ "c" ] == 5 );
				Assert.That( unpackedDictionary[ "myclass" ].IsDictionary );
				var myClass = unpackedDictionary[ "myclass" ].AsDictionary();
				Assert.That( myClass[ "x" ] == 8 );
				Assert.That( myClass[ "y" ] == "ola" );
			}
		}

		// Define other methods and classes here
		public enum Issue111Aux
		{
			AuxZero = 0,
			AuxOne = 1,
			AuxTwo = 2,
			AuxThree = 3,
		}

		public class Issue111Class
		{
			public int x;
			public string y;
			public Issue111Aux aux;
		}
#endif // !UNITY

		public class TestValueTypeWrapper
		{
			public TestValueType Value { get; set; }
			public TestValueTypeWrapper() { }
		}

		public class TestValueTypeWrapperSerializer : MessagePackSerializer<TestValueTypeWrapper>
		{
			private readonly MessagePackSerializer<TestValueType> _serializer0;

			public TestValueTypeWrapperSerializer( SerializationContext context )
				: base( context )
			{
				this._serializer0 = context.GetSerializer<TestValueType>( PolymorphismSchema.Default );
			}

			protected internal override void PackToCore( Packer packer, TestValueTypeWrapper objectTree )
			{
				packer.PackArrayHeader( 1 );
				this._serializer0.PackTo( packer, objectTree.Value );
			}

			protected internal override TestValueTypeWrapper UnpackFromCore( Unpacker unpacker )
			{
				Assert.That( unpacker.IsArrayHeader );
				Assert.That( unpacker.ItemsCount, Is.EqualTo( 1L ) );
				Assert.That( unpacker.Read() );
				return new TestValueTypeWrapper { Value = this._serializer0.UnpackFrom( unpacker ) };
			}
		}

		[Test]
		public void Issue143()
		{
			var array =
				new object[]
				{
					"111",
					32432,
					new int[] { 9, 8 },
					909
				};
			var serializer = MessagePackSerializer.Get<object>( new SerializationContext() );
			var packedBinary = serializer.PackSingleObject( array );
			var unpacked = serializer.UnpackSingleObject( packedBinary );
			var unpackedList = ( ( MessagePackObject )unpacked ).AsList();
			Assert.That( unpackedList.Count, Is.EqualTo( 4 ) );
			Assert.That( unpackedList[ 0 ] == "111" );
			Assert.That( unpackedList[ 1 ] == 32432 );
			Assert.That( unpackedList[ 2 ].IsList );
			Assert.That( unpackedList[ 2 ].AsList().Count, Is.EqualTo( 2 ) );
			Assert.That( unpackedList[ 2 ].AsList()[ 0 ] == 9 );
			Assert.That( unpackedList[ 2 ].AsList()[ 1 ] == 8 );
			Assert.That( unpackedList[ 3 ] == 909 );
		}

#if !SILVERLIGHT && !AOT && !NETSTANDARD1_1 && !NETSTANDARD1_3
		[Test]
		public void Issue145()
		{
			var results =
				SerializerGenerator.GenerateSerializerSourceCodes(
					new SerializerCodeGenerationConfiguration
					{
						EnumSerializationMethod = EnumSerializationMethod.ByUnderlyingValue,
						IsRecursive = true,
						OutputDirectory = Path.GetTempPath(),
						WithNullableSerializers = false,
						PreferReflectionBasedSerializer = true,
						SerializationMethod = SerializationMethod.Array
					},
					typeof( Issue145Class )
				).ToArray();
			foreach ( var result in results )
			{
				File.Delete( result.FilePath );
			}
		}

		[DataContract]
		public class Issue145Class
		{
			[DataMember( Order = 0 )]
			public int MyProperty1 { get; set; }
			[DataMember( Order = 2 )]
			public int MyProperty2 { get; set; }
		}

		[Test]
		public void TestIssue152()
		{
			var serializer = MessagePackSerializer.Get<Issue152>( new SerializationContext() );
			using ( var buffer = new MemoryStream() )
			{
				var target = new Issue152();
				target.SetItems( new List<int> { 1, 2, 3 } );
				serializer.Pack( buffer, target );
				buffer.Position = 0;
				var result = serializer.Unpack( buffer );
				Assert.That( result.GetItems(), Is.EqualTo( target.GetItems() ) );
			}
		}

		public class Issue152
		{
			[MessagePackMember( 0 )]
			private List<int> Items { get; set; }

			public List<int> GetItems()
			{
				return this.Items;
			}

			public void SetItems( List<int> items )
			{
				this.Items = items;
			}
		}

#endif // !SILVERLIGHT && !AOT && !NETSTANDARD1_1 && !NETSTANDARD1_3

		// Issue 168
		[Test]
		public void TestMessagePackObject_Binary_PackToMessage_ToBianry()
		{
			MessagePackObject obj = new MessagePackObject( new byte[] { 1, 2, 3 }, isBinary: true );
			var ctx = new SerializationContext( PackerCompatibilityOptions.None );
			var serializer = ctx.GetSerializer<MessagePackObject>();
			byte[] serialized = serializer.PackSingleObject( obj );
			Assert.That( serialized[ 0 ], Is.EqualTo( MessagePackCode.Bin8 ) );
		}

		// Issue 204
		[Test]
		public void TestDateTimeTypeError_SerializationException()
		{
			using ( var data = new MemoryStream( new byte[] { 0xA0 } ) )
			{
				var context = new SerializationContext();
				foreach ( var method in new[] { DateTimeConversionMethod.UnixEpoc, DateTimeConversionMethod.Native } )
				{
					context.DefaultDateTimeConversionMethod = method;
					data.Position = 0;
					Assert.Throws<SerializationException>( () => context.GetSerializer<DateTime>().Unpack( data ) );
					data.Position = 0;
					Assert.Throws<SerializationException>( () => context.GetSerializer<DateTime?>().Unpack( data ) );
					data.Position = 0;
					Assert.Throws<SerializationException>( () => context.GetSerializer<DateTimeOffset>().Unpack( data ) );
					data.Position = 0;
					Assert.Throws<SerializationException>( () => context.GetSerializer<DateTimeOffset?>().Unpack( data ) );
				}
			}
		}

		[Test]
		public void TestIssue211_ListOfT()
		{
			var target = new SerializationContext().GetSerializer<List<SingleValueObject>>();
			using ( var buffer = new MemoryStream() )
			{
				target.Pack( buffer, new List<SingleValueObject> { null } );
				buffer.Position = 0;
				var result = target.Unpack( buffer );
				Assert.That( result.Count, Is.EqualTo( 1 ) );
				Assert.That( result[ 0 ], Is.Null );
			}
		}

		[Test]
		public void TestIssue211_DictionaryOfT()
		{
			var target = new SerializationContext().GetSerializer<Dictionary<string, SingleValueObject>>();
			using ( var buffer = new MemoryStream() )
			{
				target.Pack( buffer, new Dictionary<string, SingleValueObject> { { String.Empty, null } } );
				buffer.Position = 0;
				var result = target.Unpack( buffer );
				Assert.That( result.Count, Is.EqualTo( 1 ) );
				Assert.That( result.First().Value, Is.Null );
			}
		}

		[Test]
		public void TestIssue211_StackOfT()
		{
			var target = new SerializationContext().GetSerializer<Stack<SingleValueObject>>();
			using ( var buffer = new MemoryStream() )
			{
				var obj = new Stack<SingleValueObject>();
				obj.Push( null );
				target.Pack( buffer, obj );
				buffer.Position = 0;
				var result = target.Unpack( buffer );
				Assert.That( result.Count, Is.EqualTo( 1 ) );
				Assert.That( result.Pop(), Is.Null );
			}
		}

		[Test]
		public void TestIssue211_QueueOfT()
		{
			var target = new SerializationContext().GetSerializer<Queue<SingleValueObject>>();
			using ( var buffer = new MemoryStream() )
			{
				var obj = new Queue<SingleValueObject>();
				obj.Enqueue( null );
				target.Pack( buffer, obj );
				buffer.Position = 0;
				var result = target.Unpack( buffer );
				Assert.That( result.Count, Is.EqualTo( 1 ) );
				Assert.That( result.Dequeue(), Is.Null );
			}
		}

		public class SingleValueObject
		{
			public string Value { get; set; }
		}

		[Test]
		public void TestIssue252()
		{
			var context = new SerializationContext();
			var serializer = context.GetSerializer<Issue252Class>();
			var bytes = serializer.PackSingleObject( new Issue252Class() );
			Assert.That( bytes.Length, Is.EqualTo( MessagePackSerializer.BufferSize + 1 ), Binary.ToHexString( bytes ) );
		}

		public class Issue252Class
		{
			// BufferSize - sizeof( Int32 property ) - sizeof( byte array type header with 1bit length ) - sizeof( array header );
			public byte[] ByteArray = new byte[ MessagePackSerializer.BufferSize - sizeof( int ) - sizeof( byte ) - 1 - 1 ];
			public int Int32 = Int32.MaxValue;
		}

		[Test]
		public void TestIssue270_Default()
		{
			var context = new SerializationContext();
			var guidBytes = context.GetSerializer<Guid>().PackSingleObject( Guid.NewGuid() );
			Assert.That( guidBytes[ 0 ], Is.EqualTo( MessagePackCode.Bin8 ) );
#if !WINDOWS_PHONE
#if !NET35 && !UNITY
#if !UNITY || MSGPACK_UNITY_FULL
			var bigIntBytes = context.GetSerializer<BigInteger>().PackSingleObject( new BigInteger( 123 ) );
			Assert.That( bigIntBytes[ 0 ], Is.EqualTo( MessagePackCode.Bin8 ) );
#endif // !UNITY || MSGPACK_UNITY_FULL
#endif // !NET35 && !UNITY
#endif // !WINDOWS_PHONE
		}

		[Test]
		public void TestIssue270_AsRaw()
		{
			var context = new SerializationContext();
			context.CompatibilityOptions.PackerCompatibilityOptions = PackerCompatibilityOptions.PackBinaryAsRaw;
			var guidBytes = context.GetSerializer<Guid>().PackSingleObject( Guid.NewGuid() );
			Assert.That( guidBytes[ 0 ], Is.EqualTo( 0xB0 ) );
#if !WINDOWS_PHONE
#if !NET35 && !UNITY
#if !UNITY || MSGPACK_UNITY_FULL
			var bigIntBytes = context.GetSerializer<BigInteger>().PackSingleObject( new BigInteger( 123 ) );
			Assert.That( bigIntBytes[ 0 ], Is.EqualTo( 0xA1 ) );
#endif // !UNITY || MSGPACK_UNITY_FULL
#endif // !NET35 && !UNITY
#endif // !WINDOWS_PHONE
		}

#if FEATURE_TAP

		[Test]
		public async Task TestIssue270Async_Default()
		{
			var context = new SerializationContext();
			var guidBytes = await context.GetSerializer<Guid>().PackSingleObjectAsync( Guid.NewGuid() );
			Assert.That( guidBytes[ 0 ], Is.EqualTo( MessagePackCode.Bin8 ) );
			var bigIntBytes = await context.GetSerializer<BigInteger>().PackSingleObjectAsync( new BigInteger( 123 ) );
			Assert.That( bigIntBytes[ 0 ], Is.EqualTo( MessagePackCode.Bin8 ) );
		}

		[Test]
		public async Task TestIssue270Async_AsRaw()
		{
			var context = new SerializationContext();
			context.CompatibilityOptions.PackerCompatibilityOptions = PackerCompatibilityOptions.PackBinaryAsRaw;
			var guidBytes = await context.GetSerializer<Guid>().PackSingleObjectAsync( Guid.NewGuid() );
			Assert.That( guidBytes[ 0 ], Is.EqualTo( 0xB0 ) );
			var bigIntBytes = await context.GetSerializer<BigInteger>().PackSingleObjectAsync( new BigInteger( 123 ) );
			Assert.That( bigIntBytes[ 0 ], Is.EqualTo( 0xA1 ) );
		}

#endif // FEATURE_TAP

		[Test]
		public void TestIssue269()
		{
			var input = new MessagePackObject( Timestamp.UtcNow.Encode() );
			var target = MessagePackSerializer.UnpackMessagePackObject( MessagePackSerializer.Get<MessagePackObject>().PackSingleObject( input ) );
			Assert.That( target.UnderlyingType, Is.EqualTo( typeof( MessagePackExtendedTypeObject ) ) );
			Assert.That( target.IsTypeOf<byte[]>(), Is.False );
			Assert.That( target.IsTypeOf<MessagePackExtendedTypeObject>(), Is.True );

			var forBinary = Assert.Throws<InvalidOperationException>( () => target.AsBinary() );
			Assert.That( forBinary.Message, Is.EqualTo( "Do not convert MsgPack.MessagePackExtendedTypeObject MessagePackObject to System.Byte[]." ) );

			var forString = Assert.Throws<InvalidOperationException>( () => target.AsString() );
			Assert.That( forString.Message, Is.EqualTo( "Do not convert MsgPack.MessagePackExtendedTypeObject MessagePackObject to System.String." ) );
		}
	}
}
