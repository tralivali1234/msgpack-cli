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
    public class MsgPack_Serialization_ComplexTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer3;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<int>> _serializer4;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.ComplexType, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Uri> this_SetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, byte[]> this_SetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.DateTime> this_SetUnpackedValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistoryDelegate;
        
        private System.Reflection.MethodBase _methodBaseComplexType_set_Points0;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>> this_SetUnpackedValueOfPointsDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Uri>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<byte[]>(schema1);
            this._serializer2 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer3 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema2);
            MsgPack.Serialization.PolymorphismSchema schema3 = default(MsgPack.Serialization.PolymorphismSchema);
            schema3 = null;
            this._serializer4 = context.GetSerializer<System.Collections.Generic.List<int>>(schema3);
            this._methodBaseComplexType_set_Points0 = MsgPack.Serialization.ReflectionHelpers.GetMethod(typeof(MsgPack.Serialization.ComplexType), "set_Points", new System.Type[] {
                        typeof(System.Collections.Generic.List<int>)});
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[5];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            packOperationList[4] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>>(5);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            packOperationTable["Points"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexType, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexType, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.ComplexType, bool>>(4);
            nullCheckerTable["Source"] = new System.Func<MsgPack.Serialization.ComplexType, bool>(this.IsSourceNull);
            nullCheckerTable["Data"] = new System.Func<MsgPack.Serialization.ComplexType, bool>(this.IsDataNull);
            nullCheckerTable["History"] = new System.Func<MsgPack.Serialization.ComplexType, bool>(this.IsHistoryNull);
            nullCheckerTable["Points"] = new System.Func<MsgPack.Serialization.ComplexType, bool>(this.IsPointsNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[5];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            unpackOperationList[4] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>>(5);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Points"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Source",
                    "Data",
                    "TimeStamp",
                    "History",
                    "Points"};
            this.this_SetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_SetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexType, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_SetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
            this.this_SetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_SetUnpackedValueOfPointsDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>>(this.SetUnpackedValueOfPoints);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Source);
        }
        
        private bool IsSourceNull(MsgPack.Serialization.ComplexType objectTree) {
            return (objectTree.Source == null);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer1.PackTo(packer, objectTree.Data);
        }
        
        private bool IsDataNull(MsgPack.Serialization.ComplexType objectTree) {
            return (objectTree.Data == null);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer2.PackTo(packer, objectTree.TimeStamp);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer3.PackTo(packer, objectTree.History);
        }
        
        private bool IsHistoryNull(MsgPack.Serialization.ComplexType objectTree) {
            return (objectTree.History == null);
        }
        
        private void PackValueOfPoints(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer4.PackTo(packer, objectTree.Points);
        }
        
        private bool IsPointsNull(MsgPack.Serialization.ComplexType objectTree) {
            return (objectTree.Points == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexType> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.ComplexType>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexType> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.ComplexType>);
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
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexType unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, System.Uri> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, System.Uri>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Uri);
            unpackHelperParameters.MemberName = "Source";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfSourceDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexType unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, byte[]> unpackHelperParameters0 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, byte[]>);
            unpackHelperParameters0.Unpacker = unpacker;
            unpackHelperParameters0.UnpackingContext = unpackingContext;
            unpackHelperParameters0.Serializer = this._serializer1;
            unpackHelperParameters0.ItemsCount = itemsCount;
            unpackHelperParameters0.Unpacked = indexOfItem;
            unpackHelperParameters0.TargetObjectType = typeof(byte[]);
            unpackHelperParameters0.MemberName = "Data";
            unpackHelperParameters0.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters0.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
            unpackHelperParameters0.Setter = this.this_SetUnpackedValueOfDataDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters0);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexType unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.ComplexType, System.DateTime> unpackHelperParameters1 = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.ComplexType, System.DateTime>);
            unpackHelperParameters1.Unpacker = unpacker;
            unpackHelperParameters1.UnpackingContext = unpackingContext;
            unpackHelperParameters1.Serializer = this._serializer2;
            unpackHelperParameters1.ItemsCount = itemsCount;
            unpackHelperParameters1.Unpacked = indexOfItem;
            unpackHelperParameters1.TargetObjectType = typeof(System.DateTime);
            unpackHelperParameters1.MemberName = "TimeStamp";
            unpackHelperParameters1.DirectRead = null;
            unpackHelperParameters1.Setter = this.this_SetUnpackedValueOfTimeStampDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters1);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexType unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string> existent = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            existent = unpackingContext.History;
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>> unpackHelperParameters2 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>>);
            unpackHelperParameters2.Unpacker = unpacker;
            unpackHelperParameters2.UnpackingContext = unpackingContext;
            unpackHelperParameters2.Serializer = this._serializer3;
            unpackHelperParameters2.ItemsCount = itemsCount;
            unpackHelperParameters2.Unpacked = indexOfItem;
            unpackHelperParameters2.TargetObjectType = typeof(System.Collections.Generic.Dictionary<System.DateTime, string>);
            unpackHelperParameters2.MemberName = "History";
            unpackHelperParameters2.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters2.DirectRead = null;
            unpackHelperParameters2.Setter = this.this_SetUnpackedValueOfHistoryDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters2);
        }
        
        private void SetUnpackedValueOfPoints(MsgPack.Serialization.ComplexType unpackingContext, System.Collections.Generic.List<int> unpackedValue) {
            System.Collections.Generic.List<int> existent = default(System.Collections.Generic.List<int>);
            existent = unpackingContext.Points;
            if ((existent == null)) {
                this._methodBaseComplexType_set_Points0.Invoke(unpackingContext, new object[] {
                            unpackedValue});
            }
            else {
                System.Collections.Generic.List<int>.Enumerator enumerator = unpackedValue.GetEnumerator();
                int current;
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
        
        private void UnpackValueOfPoints(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>> unpackHelperParameters3 = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>>);
            unpackHelperParameters3.Unpacker = unpacker;
            unpackHelperParameters3.UnpackingContext = unpackingContext;
            unpackHelperParameters3.Serializer = this._serializer4;
            unpackHelperParameters3.ItemsCount = itemsCount;
            unpackHelperParameters3.Unpacked = indexOfItem;
            unpackHelperParameters3.TargetObjectType = typeof(System.Collections.Generic.List<int>);
            unpackHelperParameters3.MemberName = "Points";
            unpackHelperParameters3.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters3.DirectRead = null;
            unpackHelperParameters3.Setter = this.this_SetUnpackedValueOfPointsDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters3);
        }
        
        protected internal override MsgPack.Serialization.ComplexType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexType result = default(MsgPack.Serialization.ComplexType);
            result = new MsgPack.Serialization.ComplexType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._unpackOperationTable);
            }
        }
    }
}
