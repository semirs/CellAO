﻿#region License
// Copyright (c) 2005-2012, CellAO Team
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

#region Usings...
#endregion

namespace ZoneEngine.Script
{
    using System.Collections.Generic;
    using System.IO;

    public class Scripts
    {
        //TODO: Place all the Engines Scripting Code in here (Checks, executes and compiles)
        private readonly Dictionary<string, string> cSharpList;

        private readonly Dictionary<string, string> dllList;

        public Dictionary<string, string> CSharpList
        {
            get
            {
                return this.cSharpList;
            }
        }

        public Dictionary<string, string> DllList
        {
            get
            {
                return this.dllList;
            }
        }

        public Scripts()
        {
            this.cSharpList = new Dictionary<string, string>();
            this.dllList = new Dictionary<string, string>();
        }

        public void CheckScripts()
        {
            DirectoryInfo dirinfo = new DirectoryInfo("Scripts/");
            FileInfo[] csinfo = dirinfo.GetFiles("*.cs");
            FileInfo[] dllinfo = dirinfo.GetFiles("*.dll");
            foreach (FileInfo fi in csinfo)
            {
                this.cSharpList.Add("CSName", fi.Name);
            }
            foreach (FileInfo fi2 in dllinfo)
            {
                this.dllList.Add("DllName", fi2.Name);
            }
        }
    }
}