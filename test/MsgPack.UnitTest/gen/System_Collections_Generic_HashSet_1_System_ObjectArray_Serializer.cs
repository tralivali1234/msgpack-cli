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
    public class System_Collections_Generic_HashSet_1_System_ObjectArray_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<System.Collections.Generic.HashSet<object[]>, object[]> {
        
        public System_Collections_Generic_HashSet_1_System_ObjectArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, System_Collections_Generic_HashSet_1_System_ObjectArray_Serializer.RestoreSchema(), ((MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom) 
                                | MsgPack.Serialization.SerializerCapabilities.UnpackTo)) {
        }
        
        protected override System.Collections.Generic.HashSet<object[]> CreateInstance(int initialCapacity) {
            System.Collections.Generic.HashSet<object[]> collection = default(System.Collections.Generic.HashSet<object[]>);
            collection = new System.Collections.Generic.HashSet<object[]>(MsgPack.Serialization.UnpackHelpers.GetEqualityComparer<object[]>());
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
