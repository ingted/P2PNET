﻿using P2PNET.ObjectLayer;
using P2PNET.TransportLayer;

namespace P2PNET.ObjectLayer.EventArgs
{
    public class ObjReceivedEventArgs : System.EventArgs
    {
        public BObject Obj { get; }

        //constructor
        public ObjReceivedEventArgs(BObject mObj)
        {
            this.Obj = mObj;
        }
    }
}
