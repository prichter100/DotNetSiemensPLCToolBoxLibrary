﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSiemensPLCToolBoxLibrary.Communication.Library
{
    public class Connection : IDisposable
    {
        public void Dispose()
        { }

        private byte[] ConnectionId;

        internal Connection(byte[] ConnectionId)
        {
            this.ConnectionId = ConnectionId;
        }

        private Interface _interface;
        public Interface Interface
        {
            get { return _interface; }          
        }

        /*public Pdu ExchangePdu(Pdu mPdu)
        {
            //Interface.
        }*/

        public Pdu PrepareReadRequest()
        {
            return null;
        }

        public ResultSet ExecReadRequest(Pdu myPdu)
        {
            return null;
        }

        public void SendPdu(Pdu myPdu)
        { }

        public void DeleteprogrammBlock(int BlockType, int Nummer)
        { }

        //public byte[] ReadSzl()
    }
}