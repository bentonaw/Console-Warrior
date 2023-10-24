using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Warrior
{
    internal class UI
    {
        //Buffervalues - gamestart
        internal int BufferStartX { get; set; }
        internal int BufferStartY { get; set; }

        

        public UI(int bufferStartX =100, int bufferStartY=50)
        {
            BufferStartX = bufferStartX;
            BufferStartY = bufferStartY;
        }

        public void MessageBox()
        {
            
        }
    }
}
