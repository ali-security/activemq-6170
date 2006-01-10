//
// Marshalling code for Open Wire Format for IntegerResponse
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
    public class IntegerResponseMarshaller : AbstractCommandMarshaller
    {


        public override Command CreateCommand() {
            return new IntegerResponse();
        }

        public override void BuildCommand(Command command, BinaryReader dataIn) {
            base.BuildCommand(command, dataIn);

            IntegerResponse info = (IntegerResponse) command;
            info.Result = dataIn.ReadInt32();

        }

        public override void WriteCommand(Command command, BinaryWriter dataOut) {
            base.WriteCommand(command, dataOut);

            IntegerResponse info = (IntegerResponse) command;
            dataOut.Write(info.Result);

        }
    }
}
