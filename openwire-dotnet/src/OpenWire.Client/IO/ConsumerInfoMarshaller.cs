//
// Marshalling code for Open Wire Format for ConsumerInfo
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using System;
using System.Collections;
using System.IO;

using OpenWire.Client;
using OpenWire.Client.Commands;
using OpenWire.Client.Core;
using OpenWire.Client.IO;

namespace OpenWire.Client.IO
{
    public class ConsumerInfoMarshaller : AbstractCommandMarshaller
    {


        public override Command CreateCommand() {
            return new ConsumerInfo();
        }

        public override void BuildCommand(Command command, BinaryReader dataIn) {
            base.BuildCommand(command, dataIn);

            ConsumerInfo info = (ConsumerInfo) command;
            info.ConsumerId = (ConsumerId) CommandMarshallerRegistry.ConsumerIdMarshaller.ReadCommand(dataIn);
            info.Browser = dataIn.ReadBoolean();
            info.Destination = ReadDestination(dataIn);
            info.PrefetchSize = dataIn.ReadInt32();
            info.DispatchAsync = dataIn.ReadBoolean();
            info.Selector = dataIn.ReadString();
            info.SubcriptionName = dataIn.ReadString();
            info.NoLocal = dataIn.ReadBoolean();
            info.Exclusive = dataIn.ReadBoolean();
            info.Retroactive = dataIn.ReadBoolean();
            info.Priority = dataIn.ReadByte();
            info.BrokerPath = ReadBrokerIds(dataIn);
            info.NetworkSubscription = dataIn.ReadBoolean();

        }

        public override void WriteCommand(Command command, BinaryWriter dataOut) {
            base.WriteCommand(command, dataOut);

            ConsumerInfo info = (ConsumerInfo) command;
            CommandMarshallerRegistry.ConsumerIdMarshaller.WriteCommand(info.ConsumerId, dataOut);
            dataOut.Write(info.Browser);
            WriteDestination(info.Destination, dataOut);
            dataOut.Write(info.PrefetchSize);
            dataOut.Write(info.DispatchAsync);
            dataOut.Write(info.Selector);
            dataOut.Write(info.SubcriptionName);
            dataOut.Write(info.NoLocal);
            dataOut.Write(info.Exclusive);
            dataOut.Write(info.Retroactive);
            dataOut.Write(info.Priority);
            WriteBrokerIds(info.BrokerPath, dataOut);
            dataOut.Write(info.NetworkSubscription);

        }
    }
}
