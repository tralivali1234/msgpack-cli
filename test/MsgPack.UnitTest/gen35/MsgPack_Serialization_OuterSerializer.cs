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
    public class MsgPack_Serialization_OuterSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.Outer> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.Inner> _serializer1;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.Outer, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.Outer, string> this_SetUnpackedValueOfADelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Action<MsgPack.Serialization.Outer, MsgPack.Serialization.Inner> this_SetUnpackedValueOfInnerDelegate;
        
        private System.Action<MsgPack.Serialization.Outer, string> this_SetUnpackedValueOfODelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_OuterSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<MsgPack.Serialization.Inner>(schema1);
            System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfA);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfInner);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfO);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>>(3);
            packOperationTable["A"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfA);
            packOperationTable["Inner"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfInner);
            packOperationTable["O"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.Outer>(this.PackValueOfO);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.Outer, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.Outer, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.Outer, bool>>(3);
            nullCheckerTable["A"] = new System.Func<MsgPack.Serialization.Outer, bool>(this.IsANull);
            nullCheckerTable["Inner"] = new System.Func<MsgPack.Serialization.Outer, bool>(this.IsInnerNull);
            nullCheckerTable["O"] = new System.Func<MsgPack.Serialization.Outer, bool>(this.IsONull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfA);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfInner);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfO);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>>(3);
            unpackOperationTable["A"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfA);
            unpackOperationTable["Inner"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfInner);
            unpackOperationTable["O"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.Outer, int, int>(this.UnpackValueOfO);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "A",
                    "Inner",
                    "O"};
            this.this_SetUnpackedValueOfADelegate = new System.Action<MsgPack.Serialization.Outer, string>(this.SetUnpackedValueOfA);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
            this.this_SetUnpackedValueOfInnerDelegate = new System.Action<MsgPack.Serialization.Outer, MsgPack.Serialization.Inner>(this.SetUnpackedValueOfInner);
            this.this_SetUnpackedValueOfODelegate = new System.Action<MsgPack.Serialization.Outer, string>(this.SetUnpackedValueOfO);
        }
        
        private void PackValueOfA(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            this._serializer0.PackTo(packer, objectTree.A);
        }
        
        private bool IsANull(MsgPack.Serialization.Outer objectTree) {
            return (objectTree.A == null);
        }
        
        private void PackValueOfInner(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            this._serializer1.PackTo(packer, objectTree.Inner);
        }
        
        private bool IsInnerNull(MsgPack.Serialization.Outer objectTree) {
            return (objectTree.Inner == null);
        }
        
        private void PackValueOfO(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            this._serializer0.PackTo(packer, objectTree.O);
        }
        
        private bool IsONull(MsgPack.Serialization.Outer objectTree) {
            return (objectTree.O == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.Outer objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.Outer> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.Outer>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.Outer> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.Outer>);
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
        
        private void SetUnpackedValueOfA(MsgPack.Serialization.Outer unpackingContext, string unpackedValue) {
            unpackingContext.A = unpackedValue;
        }
        
        private void UnpackValueOfA(MsgPack.Unpacker unpacker, MsgPack.Serialization.Outer unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.Outer, string> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.Outer, string>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(string);
            unpackHelperParameters.MemberName = "A";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfADelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfInner(MsgPack.Serialization.Outer unpackingContext, MsgPack.Serialization.Inner unpackedValue) {
            unpackingContext.Inner = unpackedValue;
        }
        
        private void UnpackValueOfInner(MsgPack.Unpacker unpacker, MsgPack.Serialization.Outer unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.Outer, MsgPack.Serialization.Inner> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.Outer, MsgPack.Serialization.Inner>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(MsgPack.Serialization.Inner);
            unpackHelperParameters0.MemberName = "Inner";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = null;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfInnerDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOfO(MsgPack.Serialization.Outer unpackingContext, string unpackedValue) {
            unpackingContext.O = unpackedValue;
        }
        
        private void UnpackValueOfO(MsgPack.Unpacker unpacker, MsgPack.Serialization.Outer unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.Outer, string> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.Outer, string>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer0;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(string);
            unpackHelperParameters1.MemberName = "O";
            unpackHelperParameters1.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters1.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfODelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters1);
        }
        
        protected internal override MsgPack.Serialization.Outer UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.Outer result = default(MsgPack.Serialization.Outer);
            result = new MsgPack.Serialization.Outer();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.Outer>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.Outer>(), this._unpackOperationTable);
            }
        }
    }
}
