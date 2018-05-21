#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010-2017 FUJIWARA, Yusuke
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
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
	[DataContract]
	public class ComplexTypeWithDataContractWithOrder : IVerifiable
	{
		[DataMember( Order = 0 )]
		public Uri Source { get; set; }
		[DataMember( Order = 2 )]
		public DateTime TimeStamp { get; set; }
		[DataMember( Order = 1 )]
		public byte[] Data { get; set; }

		private readonly Dictionary<DateTime, string> _history = new Dictionary<DateTime, string>( DictionaryTestHelper.GetEqualityComparer<DateTime>() );

		[DataMember( Order = 3 )]
		public Dictionary<DateTime, string> History
		{
			get { return this._history; }
		}

		public object NonSerialized { get; set; }

		public void Verify( Stream stream )
		{
			stream.Position = 0;
			var data = Unpacking.UnpackObject( stream );
			NUnit.Framework.Assert.That( data, Is.Not.Null );
			if ( data.IsDictionary )
			{
				var map = data.AsDictionary();
				NUnit.Framework.Assert.That( map.ContainsKey( "Source" ) );
				NUnit.Framework.Assert.That( map[ "Source" ].AsString(), Is.EqualTo( this.Source.ToString() ) );
				NUnit.Framework.Assert.That( map.ContainsKey( "TimeStamp" ) );
				NUnit.Framework.Assert.That( map[ "TimeStamp" ].AsTimestamp().ToDateTime(), Is.EqualTo( this.TimeStamp.ToUniversalTime() ) );
				NUnit.Framework.Assert.That( map.ContainsKey( "Data" ) );
				NUnit.Framework.Assert.That( map[ "Data" ].AsBinary(), Is.EqualTo( this.Data ) );
				NUnit.Framework.Assert.That( map.ContainsKey( "History" ) );
				NUnit.Framework.Assert.That( map[ "History" ].AsDictionary().Count, Is.EqualTo( this.History.Count ) );
				NUnit.Framework.Assert.That( !map.ContainsKey( "NonSerialized" ) );
			}
			else
			{
				var array = data.AsList();
				NUnit.Framework.Assert.That( array.Count, Is.EqualTo( 4 ) );
				NUnit.Framework.Assert.That( array[ 0 ].AsString(), Is.EqualTo( this.Source.ToString() ) );
				NUnit.Framework.Assert.That( array[ 2 ].AsTimestamp().ToDateTime(), Is.EqualTo( this.TimeStamp.ToUniversalTime() ) );
				NUnit.Framework.Assert.That( array[ 1 ].AsBinary(), Is.EqualTo( this.Data ) );
				NUnit.Framework.Assert.That( array[ 3 ].AsDictionary().Count, Is.EqualTo( this.History.Count ) );
			}
		}
	}
}
