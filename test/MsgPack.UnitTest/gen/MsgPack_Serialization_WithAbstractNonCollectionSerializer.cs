﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_WithAbstractNonCollectionSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.WithAbstractNonCollection> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.IO.Stream> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.WithAbstractNonCollection, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.WithAbstractNonCollection, System.IO.Stream> this_SetUnpackedValueOfNonCollectionDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_WithAbstractNonCollectionSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.IO.Stream>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>(this.PackValueOfNonCollection);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfNonCollectionAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>>(1);
            packOperationTable["NonCollection"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection>(this.PackValueOfNonCollection);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["NonCollection"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.WithAbstractNonCollection, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfNonCollectionAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.WithAbstractNonCollection, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.WithAbstractNonCollection, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.WithAbstractNonCollection, bool>>(1);
            nullCheckerTable["NonCollection"] = new System.Func<MsgPack.Serialization.WithAbstractNonCollection, bool>(this.IsNonCollectionNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>(this.UnpackValueOfNonCollection);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfNonCollectionAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>>(1);
            unpackOperationTable["NonCollection"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int>(this.UnpackValueOfNonCollection);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["NonCollection"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractNonCollection, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfNonCollectionAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "NonCollection"};
            this.this_SetUnpackedValueOfNonCollectionDelegate = new System.Action<MsgPack.Serialization.WithAbstractNonCollection, System.IO.Stream>(this.SetUnpackedValueOfNonCollection);
        }
        
        private void PackValueOfNonCollection(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractNonCollection objectTree) {
            this._serializer0.PackTo(packer, objectTree.NonCollection);
        }
        
        private bool IsNonCollectionNull(MsgPack.Serialization.WithAbstractNonCollection objectTree) {
            return (objectTree.NonCollection == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractNonCollection objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.WithAbstractNonCollection> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.WithAbstractNonCollection>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.WithAbstractNonCollection> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.WithAbstractNonCollection>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTable;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(ref packHelperParameters);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(ref packHelperParameters0);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfNonCollectionAsync(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractNonCollection objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.NonCollection, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractNonCollection objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.WithAbstractNonCollection> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.WithAbstractNonCollection>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.WithAbstractNonCollection> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.WithAbstractNonCollection>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTableAsync;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            packHelperParameters0.CancellationToken = cancellationToken;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(ref packHelperParameters);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(ref packHelperParameters0);
            }
        }
        
        private void SetUnpackedValueOfNonCollection(MsgPack.Serialization.WithAbstractNonCollection unpackingContext, System.IO.Stream unpackedValue) {
            unpackingContext.NonCollection = unpackedValue;
        }
        
        private void UnpackValueOfNonCollection(MsgPack.Unpacker unpacker, MsgPack.Serialization.WithAbstractNonCollection unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.WithAbstractNonCollection, System.IO.Stream> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.WithAbstractNonCollection, System.IO.Stream>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.IO.Stream);
            unpackHelperParameters.MemberName = "NonCollection";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfNonCollectionDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.WithAbstractNonCollection UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.WithAbstractNonCollection result = default(MsgPack.Serialization.WithAbstractNonCollection);
            result = new MsgPack.Serialization.WithAbstractNonCollection();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractNonCollection>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractNonCollection>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfNonCollectionAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.WithAbstractNonCollection unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.WithAbstractNonCollection, System.IO.Stream> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.WithAbstractNonCollection, System.IO.Stream>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.IO.Stream);
            unpackHelperParameters.MemberName = "NonCollection";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfNonCollectionDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.WithAbstractNonCollection> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.WithAbstractNonCollection result = default(MsgPack.Serialization.WithAbstractNonCollection);
            result = new MsgPack.Serialization.WithAbstractNonCollection();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractNonCollection>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractNonCollection>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
