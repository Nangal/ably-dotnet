﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Linq;
using MsgPack;

namespace IO.Ably.CustomSerialisers
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    //[System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class IO_Ably_MessageSerializer : MsgPack.Serialization.MessagePackSerializer<IO.Ably.Message>
    {

        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;

        private MsgPack.Serialization.MessagePackSerializer<object> _serializer1;

        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTimeOffset>> _serializer2;

        public IO_Ably_MessageSerializer(MsgPack.Serialization.SerializationContext context) :
                base(context)
        {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<object>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Nullable<System.DateTimeOffset>>(schema2);
        }

        protected override void PackToCore(MsgPack.Packer packer, IO.Ably.Message objectTree)
        {
            var nonNullFields = new bool[]
            {
                objectTree.clientId.IsNotEmpty(),
                objectTree.connectionId.IsNotEmpty(),
                objectTree.data != null,
                objectTree.encoding.IsNotEmpty(),
                objectTree.id.IsNotEmpty(),
                objectTree.name.IsNotEmpty(),
                objectTree.timestamp != null,
            }.Count(x => x);

            packer.PackMapHeader(nonNullFields);
            if (objectTree.clientId.IsNotEmpty())
            {
                this._serializer0.PackTo(packer, "clientId");
                this._serializer0.PackTo(packer, objectTree.clientId);
            }
            if (objectTree.connectionId.IsNotEmpty())
            {
                this._serializer0.PackTo(packer, "connectionId");
                this._serializer0.PackTo(packer, objectTree.connectionId);
            }
            if (objectTree.data != null)
            {
                this._serializer0.PackTo(packer, "data");
                this._serializer1.PackTo(packer, objectTree.data);
            }
            if (objectTree.encoding.IsNotEmpty())
            {
                this._serializer0.PackTo(packer, "encoding");
                this._serializer0.PackTo(packer, objectTree.encoding);
            }
            if (objectTree.id.IsNotEmpty())
            {
                this._serializer0.PackTo(packer, "id");
                this._serializer0.PackTo(packer, objectTree.id);
            }
            if (objectTree.name.IsNotEmpty())
            {
                this._serializer0.PackTo(packer, "name");
                this._serializer0.PackTo(packer, objectTree.name);
            }
            if (objectTree.timestamp != null)
            {
                this._serializer0.PackTo(packer, "timestamp");
                this._serializer2.PackTo(packer, objectTree.timestamp);
            }
        }

        protected override IO.Ably.Message UnpackFromCore(MsgPack.Unpacker unpacker)
        {
            IO.Ably.Message result = default(IO.Ably.Message);
            result = new IO.Ably.Message();
            int itemsCount0 = default(int);
            itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < itemsCount0); i = (i + 1))
            {
                string key = default(string);
                string nullable7 = default(string);
                nullable7 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.Message),
                    "MemberName");
                if (((nullable7 == null)
                     == false))
                {
                    key = nullable7;
                }
                else
                {
                    throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                }
                if ((key == "timestamp"))
                {
                    System.Nullable<System.DateTimeOffset> nullable15 = default(System.Nullable<System.DateTimeOffset>);
                    if ((unpacker.Read() == false))
                    {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                    }
                    if (((unpacker.IsArrayHeader == false)
                         && (unpacker.IsMapHeader == false)))
                    {
                        nullable15 = this._serializer2.UnpackFrom(unpacker);
                    }
                    else
                    {
                        MsgPack.Unpacker disposable4 = default(MsgPack.Unpacker);
                        disposable4 = unpacker.ReadSubtree();
                        try
                        {
                            nullable15 = this._serializer2.UnpackFrom(disposable4);
                        }
                        finally
                        {
                            if (((disposable4 == null)
                                 == false))
                            {
                                disposable4.Dispose();
                            }
                        }
                    }
                    if (nullable15.HasValue)
                    {
                        result.timestamp = nullable15;
                    }
                }
                else
                {
                    if ((key == "name"))
                    {
                        string nullable14 = default(string);
                        nullable14 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker,
                            typeof(IO.Ably.Message), "System.String name");
                        if (((nullable14 == null)
                             == false))
                        {
                            result.name = nullable14;
                        }
                    }
                    else
                    {
                        if ((key == "id"))
                        {
                            string nullable13 = default(string);
                            nullable13 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker,
                                typeof(IO.Ably.Message), "System.String id");
                            if (((nullable13 == null)
                                 == false))
                            {
                                result.id = nullable13;
                            }
                        }
                        else
                        {
                            if ((key == "encoding"))
                            {
                                string nullable12 = default(string);
                                nullable12 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker,
                                    typeof(IO.Ably.Message), "System.String encoding");
                                if (((nullable12 == null)
                                     == false))
                                {
                                    result.encoding = nullable12;
                                }
                            }
                            else
                            {
                                if ((key == "data"))
                                {
                                    object nullable10 = default(object);
                                    if ((unpacker.Read() == false))
                                    {
                                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                    }
                                    if (((unpacker.IsArrayHeader == false)
                                         && (unpacker.IsMapHeader == false)))
                                    {
                                        nullable10 = this._serializer1.UnpackFrom(unpacker);
                                    }
                                    else
                                    {
                                        MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                                        disposable2 = unpacker.ReadSubtree();
                                        try
                                        {
                                            nullable10 = this._serializer1.UnpackFrom(disposable2);
                                        }
                                        finally
                                        {
                                            if (((disposable2 == null)
                                                 == false))
                                            {
                                                disposable2.Dispose();
                                            }
                                        }
                                    }
                                    if (((nullable10 == null)
                                         == false))
                                    {
                                        if (nullable10 is MsgPack.MessagePackObject)
                                        {
                                            nullable10 = ((MessagePackObject) nullable10).ToObject();
                                            if (nullable10 is MessagePackObject[])
                                            {
                                                result.data =
                                                    ((MessagePackObject[])nullable10).Select(x => x.ToObject()).ToArray();
                                            }
                                            else
                                            {
                                                result.data = nullable10;
                                            }
                                        }
                                        else
                                        {
                                            result.data = nullable10;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((key == "connectionId"))
                                    {
                                        string nullable9 = default(string);
                                        nullable9 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker,
                                            typeof(IO.Ably.Message), "System.String connectionId");
                                        if (((nullable9 == null)
                                             == false))
                                        {
                                            result.connectionId = nullable9;
                                        }
                                    }
                                    else
                                    {
                                        if ((key == "clientId"))
                                        {
                                            string nullable8 = default(string);
                                            nullable8 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker,
                                                typeof(IO.Ably.Message), "System.String clientId");
                                            if (((nullable8 == null)
                                                 == false))
                                            {
                                                result.clientId = nullable8;
                                            }
                                        }
                                        else
                                        {
                                            unpacker.Skip();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
        {
            if (condition)
            {
                return whenTrue;
            }
            else
            {
                return whenFalse;
            }
        }
    }
}
