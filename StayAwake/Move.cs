using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace StayAwake
{
    public static class Move

    {
        internal const int INPUT_MOUSE = 0;
        internal const int MOUSEEVENTF_MOVE = 0x0001;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);

        public static void Mouse(int dx, int dy)
        {
            var input = new INPUT
            {
                TYPE = Move.INPUT_MOUSE,
                dx = dx,
                dy = dy,
                mouseData = 0,
                dwFlags = Move.MOUSEEVENTF_MOVE,
                time = 0,
                dwExtraInfo = (IntPtr)0
            };

            if (SendInput(1, ref input, Marshal.SizeOf(input)) != 1)
                throw new Win32Exception();
        }
    }
        internal struct INPUT
        {
            public int TYPE;
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

    }

