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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, bool>> _nullCheckersTable;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty_set_ListStaticItem0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, System.Collections.Generic.IList<string>> this_SetUnpackedValueOfListStaticItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<string>>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty_set_ListStaticItem0 = MsgPack.Serialization.ReflectionHelpers.GetMethod(typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty), "set_ListStaticItem", new System.Type[] {
                        typeof(System.Collections.Generic.IList<string>)});
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>(this.PackValueOfListStaticItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>>(1);
            packOperationTable["ListStaticItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>(this.PackValueOfListStaticItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, bool>>(1);
            nullCheckerTable["ListStaticItem"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, bool>(this.IsListStaticItemNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfListStaticItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>>(1);
            unpackOperationTable["ListStaticItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfListStaticItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "ListStaticItem"};
            this.this_SetUnpackedValueOfListStaticItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, System.Collections.Generic.IList<string>>(this.SetUnpackedValueOfListStaticItem);
        }
        
        private void PackValueOfListStaticItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListStaticItem);
        }
        
        private bool IsListStaticItemNull(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty objectTree) {
            return (objectTree.ListStaticItem == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>);
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
        
        private void SetUnpackedValueOfListStaticItem(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty unpackingContext, System.Collections.Generic.IList<string> unpackedValue) {
            System.Collections.Generic.IList<string> existent = default(System.Collections.Generic.IList<string>);
            existent = unpackingContext.ListStaticItem;
            if ((existent == null)) {
                this._methodBasePolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty_set_ListStaticItem0.Invoke(unpackingContext, new object[] {
                            unpackedValue});
            }
            else {
                System.Collections.Generic.IEnumerator<string> enumerator = unpackedValue.GetEnumerator();
                string current;
                try {
                    for (
                    ; enumerator.MoveNext(); 
                    ) {
                        current = enumerator.Current;
                        existent.Add(current);
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
        }
        
        private void UnpackValueOfListStaticItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, System.Collections.Generic.IList<string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty, System.Collections.Generic.IList<string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<string>);
            unpackHelperParameters.MemberName = "ListStaticItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListStaticItemDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListStaticItemPrivateSetterCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
