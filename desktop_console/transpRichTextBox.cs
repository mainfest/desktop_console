﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_console
{
    public class transpRichTextBox:RichTextBox
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr LoadLibrary(string lpFileName);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams prams = base.CreateParams;
                if(LoadLibrary("msftedit.dll")!=IntPtr.Zero)
                {
                    prams.ExStyle |= 0x020;
                    prams.ClassName = "RICHEDIT50W";
                }
                return prams;
            }
        }
    }
}
