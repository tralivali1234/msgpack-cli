﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Based on corefx's SortedDictionary<TKey, TValue>

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic
{
	[DebuggerDisplay( "Count = {Count}" )]
	public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary
	{
		private KeyCollection _keys;
		private ValueCollection _values;

		private TreeSet<KeyValuePair<TKey, TValue>> _set;

		public SortedDictionary() : this( ( IComparer<TKey> )null )
		{
		}

		public SortedDictionary( IDictionary<TKey, TValue> dictionary ) : this( dictionary, null )
		{
		}

		public SortedDictionary( IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer )
		{
			if ( dictionary == null )
			{
				throw new ArgumentNullException( nameof( dictionary ) );
			}

			_set = new TreeSet<KeyValuePair<TKey, TValue>>( new KeyValuePairComparer( comparer ) );

			foreach ( KeyValuePair<TKey, TValue> pair in dictionary )
			{
				_set.Add( pair );
			}
		}

		public SortedDictionary( IComparer<TKey> comparer )
		{
			_set = new TreeSet<KeyValuePair<TKey, TValue>>( new KeyValuePairComparer( comparer ) );
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add( KeyValuePair<TKey, TValue> keyValuePair )
		{
			_set.Add( keyValuePair );
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains( KeyValuePair<TKey, TValue> keyValuePair )
		{
			TreeSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(keyValuePair);
			if ( node == null )
			{
				return false;
			}

			if ( keyValuePair.Value == null )
			{
				return node.Item.Value == null;
			}
			else
			{
				return EqualityComparer<TValue>.Default.Equals( node.Item.Value, keyValuePair.Value );
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove( KeyValuePair<TKey, TValue> keyValuePair )
		{
			TreeSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(keyValuePair);
			if ( node == null )
			{
				return false;
			}

			if ( EqualityComparer<TValue>.Default.Equals( node.Item.Value, keyValuePair.Value ) )
			{
				_set.Remove( keyValuePair );
				return true;
			}
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public TValue this[ TKey key ]
		{
			get
			{
				if ( key == null )
				{
					throw new ArgumentNullException( nameof( key ) );
				}

				TreeSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
				if ( node == null )
				{
					throw new KeyNotFoundException();
				}

				return node.Item.Value;
			}
			set
			{
				if ( key == null )
				{
					throw new ArgumentNullException( nameof( key ) );
				}

				TreeSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
				if ( node == null )
				{
					_set.Add( new KeyValuePair<TKey, TValue>( key, value ) );
				}
				else
				{
					node.Item = new KeyValuePair<TKey, TValue>( node.Item.Key, value );
					_set.UpdateVersion();
				}
			}
		}

		public int Count
		{
			get
			{
				return _set.Count;
			}
		}

		public IComparer<TKey> Comparer
		{
			get
			{
				return ( ( KeyValuePairComparer )_set.Comparer ).keyComparer;
			}
		}

		public KeyCollection Keys
		{
			get
			{
				if ( _keys == null ) _keys = new KeyCollection( this );
				return _keys;
			}
		}

		ICollection<TKey> IDictionary<TKey, TValue>.Keys
		{
			get
			{
				return Keys;
			}
		}

		public ValueCollection Values
		{
			get
			{
				if ( _values == null ) _values = new ValueCollection( this );
				return _values;
			}
		}

		ICollection<TValue> IDictionary<TKey, TValue>.Values
		{
			get
			{
				return Values;
			}
		}

		public void Add( TKey key, TValue value )
		{
			if ( key == null )
			{
				throw new ArgumentNullException( nameof( key ) );
			}
			_set.Add( new KeyValuePair<TKey, TValue>( key, value ) );
		}

		public void Clear()
		{
			_set.Clear();
		}

		public bool ContainsKey( TKey key )
		{
			if ( key == null )
			{
				throw new ArgumentNullException( nameof( key ) );
			}

			return _set.Contains( new KeyValuePair<TKey, TValue>( key, default( TValue ) ) );
		}

		public bool ContainsValue( TValue value )
		{
			bool found = false;
			if ( value == null )
			{
				_set.InOrderTreeWalk( delegate ( TreeSet<KeyValuePair<TKey, TValue>>.Node node )
				{
					if ( node.Item.Value == null )
					{
						found = true;
						return false;  // stop the walk
					}
					return true;
				} );
			}
			else
			{
				EqualityComparer<TValue> valueComparer = EqualityComparer<TValue>.Default;
				_set.InOrderTreeWalk( delegate ( TreeSet<KeyValuePair<TKey, TValue>>.Node node )
				{
					if ( valueComparer.Equals( node.Item.Value, value ) )
					{
						found = true;
						return false;  // stop the walk
					}
					return true;
				} );
			}
			return found;
		}

		public void CopyTo( KeyValuePair<TKey, TValue>[] array, int index )
		{
			_set.CopyTo( array, index );
		}

		public Enumerator GetEnumerator()
		{
			return new Enumerator( this, Enumerator.KeyValuePair );
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return new Enumerator( this, Enumerator.KeyValuePair );
		}

		public bool Remove( TKey key )
		{
			if ( key == null )
			{
				throw new ArgumentNullException( nameof( key ) );
			}

			return _set.Remove( new KeyValuePair<TKey, TValue>( key, default( TValue ) ) );
		}

		public bool TryGetValue( TKey key, out TValue value )
		{
			if ( key == null )
			{
				throw new ArgumentNullException( nameof( key ) );
			}

			TreeSet<KeyValuePair<TKey, TValue>>.Node node = _set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
			if ( node == null )
			{
				value = default( TValue );
				return false;
			}
			value = node.Item.Value;
			return true;
		}

		void ICollection.CopyTo( Array array, int index )
		{
			( ( ICollection )_set ).CopyTo( array, index );
		}

		bool IDictionary.IsFixedSize
		{
			get { return false; }
		}

		bool IDictionary.IsReadOnly
		{
			get { return false; }
		}

		ICollection IDictionary.Keys
		{
			get { return ( ICollection )Keys; }
		}

		ICollection IDictionary.Values
		{
			get { return ( ICollection )Values; }
		}

		object IDictionary.this[ object key ]
		{
			get
			{
				if ( IsCompatibleKey( key ) )
				{
					TValue value;
					if ( TryGetValue( ( TKey )key, out value ) )
					{
						return value;
					}
				}

				return null;
			}
			set
			{
				if ( key == null )
				{
					throw new ArgumentNullException( nameof( key ) );
				}

				if ( value == null && !( default( TValue ) == null ) )
					throw new ArgumentNullException( nameof( value ) );

				try
				{
					TKey tempKey = (TKey)key;
					try
					{
						this[ tempKey ] = ( TValue )value;
					}
					catch ( InvalidCastException )
					{
						throw new ArgumentException( String.Format( "Wrong type {0}.", value, typeof( TValue ) ), nameof( value ) );
					}
				}
				catch ( InvalidCastException )
				{
					throw new ArgumentException( String.Format( "Wrong type {0}.", key, typeof( TKey ) ), nameof( key ) );
				}
			}
		}

		void IDictionary.Add( object key, object value )
		{
			if ( key == null )
			{
				throw new ArgumentNullException( nameof( key ) );
			}

			if ( value == null && !( default( TValue ) == null ) )
				throw new ArgumentNullException( nameof( value ) );

			try
			{
				TKey tempKey = (TKey)key;

				try
				{
					Add( tempKey, ( TValue )value );
				}
				catch ( InvalidCastException )
				{
					throw new ArgumentException( String.Format( "Wrong type {0}.", value, typeof( TValue ) ), nameof( value ) );
				}
			}
			catch ( InvalidCastException )
			{
				throw new ArgumentException( String.Format( "Wrong type {0}.", key, typeof( TKey ) ), nameof( key ) );
			}
		}

		bool IDictionary.Contains( object key )
		{
			if ( IsCompatibleKey( key ) )
			{
				return ContainsKey( ( TKey )key );
			}
			return false;
		}

		private static bool IsCompatibleKey( object key )
		{
			if ( key == null )
			{
				throw new ArgumentNullException( nameof( key ) );
			}

			return ( key is TKey );
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Enumerator( this, Enumerator.DictEntry );
		}

		void IDictionary.Remove( object key )
		{
			if ( IsCompatibleKey( key ) )
			{
				Remove( ( TKey )key );
			}
		}

		bool ICollection.IsSynchronized
		{
			get { return false; }
		}

		object ICollection.SyncRoot
		{
			get { return ( ( ICollection )_set ).SyncRoot; }
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator( this, Enumerator.KeyValuePair );
		}

		[SuppressMessage( "Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "not an expected scenario" )]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator
		{
			private TreeSet<KeyValuePair<TKey, TValue>>.Enumerator _treeEnum;
			private int _getEnumeratorRetType;  // What should Enumerator.Current return?

			internal const int KeyValuePair = 1;
			internal const int DictEntry = 2;

			internal Enumerator( SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType )
			{
				_treeEnum = dictionary._set.GetEnumerator();
				_getEnumeratorRetType = getEnumeratorRetType;
			}

			public bool MoveNext()
			{
				return _treeEnum.MoveNext();
			}

			public void Dispose()
			{
				_treeEnum.Dispose();
			}

			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					return _treeEnum.Current;
				}
			}

			internal bool NotStartedOrEnded
			{
				get
				{
					return _treeEnum.NotStartedOrEnded;
				}
			}

			internal void Reset()
			{
				_treeEnum.Reset();
			}


			void IEnumerator.Reset()
			{
				_treeEnum.Reset();
			}

			object IEnumerator.Current
			{
				get
				{
					if ( NotStartedOrEnded )
					{
						throw new InvalidOperationException( "Enum op cannot happen." );
					}

					if ( _getEnumeratorRetType == DictEntry )
					{
						return new DictionaryEntry( Current.Key, Current.Value );
					}
					else
					{
						return new KeyValuePair<TKey, TValue>( Current.Key, Current.Value );
					}
				}
			}

			object IDictionaryEnumerator.Key
			{
				get
				{
					if ( NotStartedOrEnded )
					{
						throw new InvalidOperationException( "Enum op cannot happen." );
					}

					return Current.Key;
				}
			}

			object IDictionaryEnumerator.Value
			{
				get
				{
					if ( NotStartedOrEnded )
					{
						throw new InvalidOperationException( "Enum op cannot happen." );
					}

					return Current.Value;
				}
			}

			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if ( NotStartedOrEnded )
					{
						throw new InvalidOperationException( "Enum op cannot happen." );
					}

					return new DictionaryEntry( Current.Key, Current.Value );
				}
			}
		}

		[DebuggerDisplay( "Count = {Count}" )]
		public sealed class KeyCollection : ICollection<TKey>, ICollection
		{
			private SortedDictionary<TKey, TValue> _dictionary;

			public KeyCollection( SortedDictionary<TKey, TValue> dictionary )
			{
				if ( dictionary == null )
				{
					throw new ArgumentNullException( nameof( dictionary ) );
				}
				_dictionary = dictionary;
			}

			public Enumerator GetEnumerator()
			{
				return new Enumerator( _dictionary );
			}

			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
			{
				return new Enumerator( _dictionary );
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Enumerator( _dictionary );
			}

			public void CopyTo( TKey[] array, int index )
			{
				if ( array == null )
				{
					throw new ArgumentNullException( nameof( array ) );
				}

				if ( index < 0 )
				{
					throw new ArgumentOutOfRangeException( nameof( index ) );
				}

				if ( array.Length - index < Count )
				{
					throw new ArgumentException( "Array plus offset too small." );
				}

				_dictionary._set.InOrderTreeWalk( delegate ( TreeSet<KeyValuePair<TKey, TValue>>.Node node ) { array[ index++ ] = node.Item.Key; return true; } );
			}

			void ICollection.CopyTo( Array array, int index )
			{
				if ( array == null )
				{
					throw new ArgumentNullException( nameof( array ) );
				}

				if ( array.Rank != 1 )
				{
					throw new ArgumentException( "Multi dimensional array.", nameof( array ) );
				}

				if ( array.GetLowerBound( 0 ) != 0 )
				{
					throw new ArgumentException( "Non zero lower bound array.", nameof( array ) );
				}

				if ( index < 0 )
				{
					throw new ArgumentOutOfRangeException( nameof( index ) );
				}

				if ( array.Length - index < _dictionary.Count )
				{
					throw new ArgumentException( "Array plus offset too small." );
				}

				TKey[] keys = array as TKey[];
				if ( keys != null )
				{
					CopyTo( keys, index );
				}
				else
				{
					try
					{
						object[] objects = (object[])array;
						_dictionary._set.InOrderTreeWalk( delegate ( TreeSet<KeyValuePair<TKey, TValue>>.Node node ) { objects[ index++ ] = node.Item.Key; return true; } );
					}
					catch ( ArrayTypeMismatchException )
					{
						throw new ArgumentException( "Invalid array type.", nameof( array ) );
					}
				}
			}

			public int Count
			{
				get { return _dictionary.Count; }
			}

			bool ICollection<TKey>.IsReadOnly
			{
				get { return true; }
			}

			void ICollection<TKey>.Add( TKey item )
			{
				throw new NotSupportedException();
			}

			void ICollection<TKey>.Clear()
			{
				throw new NotSupportedException();
			}

			bool ICollection<TKey>.Contains( TKey item )
			{
				return _dictionary.ContainsKey( item );
			}

			bool ICollection<TKey>.Remove( TKey item )
			{
				throw new NotSupportedException();
			}

			bool ICollection.IsSynchronized
			{
				get { return false; }
			}

			object ICollection.SyncRoot
			{
				get { return ( ( ICollection )_dictionary ).SyncRoot; }
			}

			[SuppressMessage( "Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "not an expected scenario" )]
			public struct Enumerator : IEnumerator<TKey>, IEnumerator
			{
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;

				internal Enumerator( SortedDictionary<TKey, TValue> dictionary )
				{
					_dictEnum = dictionary.GetEnumerator();
				}

				public void Dispose()
				{
					_dictEnum.Dispose();
				}

				public bool MoveNext()
				{
					return _dictEnum.MoveNext();
				}

				public TKey Current
				{
					get
					{
						return _dictEnum.Current.Key;
					}
				}

				object IEnumerator.Current
				{
					get
					{
						if ( _dictEnum.NotStartedOrEnded )
						{
							throw new InvalidOperationException( "Enum op cannot happen." );
						}

						return Current;
					}
				}

				void IEnumerator.Reset()
				{
					_dictEnum.Reset();
				}
			}
		}

		[DebuggerDisplay( "Count = {Count}" )]
		public sealed class ValueCollection : ICollection<TValue>, ICollection
		{
			private SortedDictionary<TKey, TValue> _dictionary;

			public ValueCollection( SortedDictionary<TKey, TValue> dictionary )
			{
				if ( dictionary == null )
				{
					throw new ArgumentNullException( nameof( dictionary ) );
				}
				_dictionary = dictionary;
			}

			public Enumerator GetEnumerator()
			{
				return new Enumerator( _dictionary );
			}

			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
			{
				return new Enumerator( _dictionary );
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Enumerator( _dictionary );
			}

			public void CopyTo( TValue[] array, int index )
			{
				if ( array == null )
				{
					throw new ArgumentNullException( nameof( array ) );
				}

				if ( index < 0 )
				{
					throw new ArgumentOutOfRangeException( nameof( index ) );
				}

				if ( array.Length - index < Count )
				{
					throw new ArgumentException( "Array plus offset too small." );
				}

				_dictionary._set.InOrderTreeWalk( delegate ( TreeSet<KeyValuePair<TKey, TValue>>.Node node ) { array[ index++ ] = node.Item.Value; return true; } );
			}

			void ICollection.CopyTo( Array array, int index )
			{
				if ( array == null )
				{
					throw new ArgumentNullException( nameof( array ) );
				}

				if ( array.Rank != 1 )
				{
					throw new ArgumentException( "Multi dimensional array.", nameof( array ) );
				}

				if ( array.GetLowerBound( 0 ) != 0 )
				{
					throw new ArgumentException( "Non zero lower bound array.", nameof( array ) );
				}

				if ( index < 0 )
				{
					throw new ArgumentOutOfRangeException( nameof( index ) );
				}

				if ( array.Length - index < _dictionary.Count )
				{
					throw new ArgumentException( "Array plus offset too small." );
				}

				TValue[] values = array as TValue[];
				if ( values != null )
				{
					CopyTo( values, index );
				}
				else
				{
					try
					{
						object[] objects = (object[])array;
						_dictionary._set.InOrderTreeWalk( delegate ( TreeSet<KeyValuePair<TKey, TValue>>.Node node ) { objects[ index++ ] = node.Item.Value; return true; } );
					}
					catch ( ArrayTypeMismatchException )
					{
						throw new ArgumentException( "Invalid array type.", nameof( array ) );
					}
				}
			}

			public int Count
			{
				get { return _dictionary.Count; }
			}

			bool ICollection<TValue>.IsReadOnly
			{
				get { return true; }
			}

			void ICollection<TValue>.Add( TValue item )
			{
				throw new NotSupportedException();
			}

			void ICollection<TValue>.Clear()
			{
				throw new NotSupportedException();
			}

			bool ICollection<TValue>.Contains( TValue item )
			{
				return _dictionary.ContainsValue( item );
			}

			bool ICollection<TValue>.Remove( TValue item )
			{
				throw new NotSupportedException();
			}

			bool ICollection.IsSynchronized
			{
				get { return false; }
			}

			object ICollection.SyncRoot
			{
				get { return ( ( ICollection )_dictionary ).SyncRoot; }
			}

			[SuppressMessage( "Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "not an expected scenario" )]
			public struct Enumerator : IEnumerator<TValue>, IEnumerator
			{
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;

				internal Enumerator( SortedDictionary<TKey, TValue> dictionary )
				{
					_dictEnum = dictionary.GetEnumerator();
				}

				public void Dispose()
				{
					_dictEnum.Dispose();
				}

				public bool MoveNext()
				{
					return _dictEnum.MoveNext();
				}

				public TValue Current
				{
					get
					{
						return _dictEnum.Current.Value;
					}
				}

				object IEnumerator.Current
				{
					get
					{
						if ( _dictEnum.NotStartedOrEnded )
						{
							throw new InvalidOperationException( "Enum op cannot happen." );
						}

						return Current;
					}
				}

				void IEnumerator.Reset()
				{
					_dictEnum.Reset();
				}
			}
		}

		internal sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
		{
			internal IComparer<TKey> keyComparer;

			public KeyValuePairComparer( IComparer<TKey> keyComparer )
			{
				if ( keyComparer == null )
				{
					this.keyComparer = Comparer<TKey>.Default;
				}
				else
				{
					this.keyComparer = keyComparer;
				}
			}

			public override int Compare( KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y )
			{
				return keyComparer.Compare( x.Key, y.Key );
			}
		}
	}

	/// <summary>
	/// This class is intended as a helper for backwards compatibility with existing SortedDictionaries.
	/// TreeSet has been converted into SortedSet<T>, which will be exposed publicly. SortedDictionaries
	/// have the problem where they have already been serialized to disk as having a backing class named
	/// TreeSet. To ensure that we can read back anything that has already been written to disk, we need to
	/// make sure that we have a class named TreeSet that does everything the way it used to.
	/// 
	/// The only thing that makes it different from SortedSet is that it throws on duplicates
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal sealed class TreeSet<T> : SortedSet<T>
	{
		public TreeSet()
			: base()
		{ }

		public TreeSet( IComparer<T> comparer ) : base( comparer ) { }

		public TreeSet( ICollection<T> collection ) : base( collection ) { }

		public TreeSet( ICollection<T> collection, IComparer<T> comparer ) : base( collection, comparer ) { }

		internal override bool AddIfNotPresent( T item )
		{
			bool ret = base.AddIfNotPresent(item);
			if ( !ret )
			{
				throw new ArgumentException( String.Format( "{0} is already added.", item ) );
			}
			return ret;
		}
	}
}