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
    public class MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithTwoMember> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithTwoMember, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithTwoMember, string> this_SetUnpackedValueOfValue1Delegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithTwoMember, string> this_SetUnpackedValueOfValue2Delegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<string>> MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>[2];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>(this.PackValueOfValue1);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>(this.PackValueOfValue2);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>[2];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfValue1Async);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfValue2Async);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>>(2);
            packOperationTable["Value1"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>(this.PackValueOfValue1);
            packOperationTable["Value2"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>(this.PackValueOfValue2);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(2);
            packOperationTableAsync["Value1"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfValue1Async);
            packOperationTableAsync["Value2"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfValue2Async);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithTwoMember, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithTwoMember, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexTypeWithTwoMember, bool>>(2);
            nullCheckerTable["Value1"] = new System.Func<MsgPack.Serialization.ComplexTypeWithTwoMember, bool>(this.IsValue1Null);
            nullCheckerTable["Value2"] = new System.Func<MsgPack.Serialization.ComplexTypeWithTwoMember, bool>(this.IsValue2Null);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>[2];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>(this.UnpackValueOfValue1);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>(this.UnpackValueOfValue2);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[2];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfValue1Async);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfValue2Async);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>>(2);
            unpackOperationTable["Value1"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>(this.UnpackValueOfValue1);
            unpackOperationTable["Value2"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int>(this.UnpackValueOfValue2);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(2);
            unpackOperationTableAsync["Value1"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfValue1Async);
            unpackOperationTableAsync["Value2"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfValue2Async);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Value1",
                    "Value2"};
            this.this_SetUnpackedValueOfValue1Delegate = new System.Action<MsgPack.Serialization.ComplexTypeWithTwoMember, string>(this.SetUnpackedValueOfValue1);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
            this.this_SetUnpackedValueOfValue2Delegate = new System.Action<MsgPack.Serialization.ComplexTypeWithTwoMember, string>(this.SetUnpackedValueOfValue2);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<string>>(MsgPack.Serialization.UnpackHelpers.UnpackStringValueAsync);
        }
        
        private void PackValueOfValue1(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value1);
        }
        
        private bool IsValue1Null(MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            return (objectTree.Value1 == null);
        }
        
        private void PackValueOfValue2(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value2);
        }
        
        private bool IsValue2Null(MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            return (objectTree.Value2 == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeWithTwoMember> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexTypeWithTwoMember>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeWithTwoMember> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexTypeWithTwoMember>);
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
        
        private System.Threading.Tasks.Task PackValueOfValue1Async(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Value1, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfValue2Async(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Value2, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember>);
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
        
        private void SetUnpackedValueOfValue1(MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, string unpackedValue) {
            unpackingContext.Value1 = unpackedValue;
        }
        
        private void UnpackValueOfValue1(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(string);
            unpackHelperParameters.MemberName = "Value1";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfValue1Delegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfValue2(MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, string unpackedValue) {
            unpackingContext.Value2 = unpackedValue;
        }
        
        private void UnpackValueOfValue2(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer0;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(string);
            unpackHelperParameters0.MemberName = "Value2";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfValue2Delegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters0);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithTwoMember UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithTwoMember result = default(MsgPack.Serialization.ComplexTypeWithTwoMember);
            result = new MsgPack.Serialization.ComplexTypeWithTwoMember();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithTwoMember>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithTwoMember>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfValue1Async(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(string);
            unpackHelperParameters.MemberName = "Value1";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfValue1Delegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfValue2Async(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.ComplexTypeWithTwoMember, string>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer0;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(string);
            unpackHelperParameters0.MemberName = "Value2";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueAsyncDelegate;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfValue2Delegate;
            unpackHelperParameters0.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters0);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.ComplexTypeWithTwoMember> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.ComplexTypeWithTwoMember result = default(MsgPack.Serialization.ComplexTypeWithTwoMember);
            result = new MsgPack.Serialization.ComplexTypeWithTwoMember();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithTwoMember>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithTwoMember>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
