﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IO.Ably.CustomSerialisers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class IO_Ably_ErrorInfoSerializer : MsgPack.Serialization.MessagePackSerializer<IO.Ably.ErrorInfo> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.Net.HttpStatusCode>> _serializer2;
        
        public IO_Ably_ErrorInfoSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<int>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Nullable<System.Net.HttpStatusCode>>(schema2);
        }
        
        protected override void PackToCore(MsgPack.Packer packer, IO.Ably.ErrorInfo objectTree) {
            packer.PackMapHeader(3);
            this._serializer0.PackTo(packer, "code");
            this._serializer1.PackTo(packer, objectTree.Code);
            this._serializer0.PackTo(packer, "message");
            this._serializer0.PackTo(packer, objectTree.Message);
            this._serializer0.PackTo(packer, "statusCode");
            this._serializer2.PackTo(packer, objectTree.StatusCode);
        }
        
        protected override IO.Ably.ErrorInfo UnpackFromCore(MsgPack.Unpacker unpacker)
        {
            IO.Ably.ErrorInfo result = default(IO.Ably.ErrorInfo);
            result = new IO.Ably.ErrorInfo();
            int itemsCount0 = default(int);
            itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < itemsCount0); i = (i + 1))
            {
                string key = default(string);
                string nullable3 = default(string);
                nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.ErrorInfo),
                    "MemberName");
                if (((nullable3 == null)
                     == false))
                {
                    key = nullable3;
                }
                else
                {
                    throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                }
                if ((key == "statusCode"))
                {
                    System.Nullable<System.Net.HttpStatusCode> nullable7 =
                        default(System.Nullable<System.Net.HttpStatusCode>);
                    if ((unpacker.Read() == false))
                    {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                    }
                    if (((unpacker.IsArrayHeader == false)
                         && (unpacker.IsMapHeader == false)))
                    {
                        nullable7 = this._serializer2.UnpackFrom(unpacker);
                    }
                    else
                    {
                        MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                        disposable0 = unpacker.ReadSubtree();
                        try
                        {
                            nullable7 = this._serializer2.UnpackFrom(disposable0);
                        }
                        finally
                        {
                            if (((disposable0 == null)
                                 == false))
                            {
                                disposable0.Dispose();
                            }
                        }
                    }
                    if (nullable7.HasValue)
                    {
                        result.StatusCode = nullable7;
                    }
                }
                else
                {
                    if ((key == "message"))
                    {
                        string nullable5 = default(string);
                        nullable5 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker,
                            typeof(IO.Ably.ErrorInfo), "System.String message");
                        if (((nullable5 == null)
                             == false))
                        {
                            result.Message = nullable5;
                        }
                    }
                    else
                    {
                        if ((key == "code"))
                        {
                            System.Nullable<int> nullable4 = default(System.Nullable<int>);
                            nullable4 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker,
                                typeof(IO.Ably.ErrorInfo), "Int32 code");
                            if (nullable4.HasValue)
                            {
                                result.Code = nullable4.Value;
                            }
                        }
                        else
                        {
                            unpacker.Skip();
                        }
                    }
                }
            }
            return result;
        }

        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
