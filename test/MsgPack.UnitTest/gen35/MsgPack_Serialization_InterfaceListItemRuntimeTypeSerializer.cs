﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8745
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_InterfaceListItemRuntimeTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.InterfaceListItemRuntimeType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.InterfaceListItemRuntimeType, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.InterfaceListItemRuntimeType, System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>> this_SetUnpackedValueOfValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_InterfaceListItemRuntimeTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema itemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            itemsSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedCollection(typeof(System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>), itemsSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>(this.PackValueOfValue);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceListItemRuntimeType>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.InterfaceListItemRuntimeType, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.InterfaceListItemRuntimeType, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.InterfaceListItemRuntimeType, bool>>(1);
            nullCheckerTable["Value"] = new System.Func<MsgPack.Serialization.InterfaceListItemRuntimeType, bool>(this.IsValueNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
            this.this_SetUnpackedValueOfValueDelegate = new System.Action<MsgPack.Serialization.InterfaceListItemRuntimeType, System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>>(this.SetUnpackedValueOfValue);
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.InterfaceListItemRuntimeType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        private bool IsValueNull(MsgPack.Serialization.InterfaceListItemRuntimeType objectTree) {
            return (objectTree.Value == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.InterfaceListItemRuntimeType objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.InterfaceListItemRuntimeType> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.InterfaceListItemRuntimeType>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.InterfaceListItemRuntimeType> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.InterfaceListItemRuntimeType>);
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
        
        private void SetUnpackedValueOfValue(MsgPack.Serialization.InterfaceListItemRuntimeType unpackingContext, System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry> unpackedValue) {
            unpackingContext.Value = unpackedValue;
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.InterfaceListItemRuntimeType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.InterfaceListItemRuntimeType, System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.InterfaceListItemRuntimeType, System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<MsgPack.Serialization.IFileSystemEntry>);
            unpackHelperParameters.MemberName = "Value";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfValueDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.InterfaceListItemRuntimeType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.InterfaceListItemRuntimeType result = default(MsgPack.Serialization.InterfaceListItemRuntimeType);
            result = new MsgPack.Serialization.InterfaceListItemRuntimeType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceListItemRuntimeType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceListItemRuntimeType>(), this._unpackOperationTable);
            }
        }
    }
}
