﻿#region License
/*
Copyright (c) 2005-2011, CellAO Team

All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

    * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
    * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ZoneEngine
{
    [Serializable]
    public class AOEvents : ISerializable
    {
        public int EventType;
        public List<AOFunctions> Functions = new List<AOFunctions>();

        /// Methods to do:
        /// Read Event

        public AOEvents(SerializationInfo info, StreamingContext context)
        {
            EventType = (int)info.GetValue("EventType", typeof(int));
            Functions = (List<AOFunctions>)info.GetValue("Functions", typeof(AOFunctions));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("EventType", EventType);
            info.AddValue("Functions", Functions);
        }

        public AOEvents()
        {
        }

        #region Read Event from blob
        public int readEventfromBlob(ref byte[] blob, int offset)
        {
            int c = offset;

            EventType = BitConverter.ToInt32(blob, c);
            c += 4;

            // Read Event Functions
            AOFunctions m_aof;
            int c2 = BitConverter.ToInt32(blob, c);
            c += 4;
            while (c2 > 0)
            {
                m_aof = new AOFunctions();
                c = m_aof.ReadFunctionfromBlob(ref blob, c);
                Functions.Add(m_aof);
                c2--;
            }
            return c;
        }
        #endregion
    }

}
