﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class NMSString0x20 : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Value;
    }
}
