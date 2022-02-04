using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace UIOTest
{
    internal class Control 
    {
        [DllImport("uio.dll")]
        private static extern bool usb_io_output(int pID, int cmd, int io1, int io2, int io3, int io4);
        public void control_light(int ID, int light, bool on_off)
        {
            //cmd : blink
            //
            //Red   : 1
            //Orange: 2
            //Green : 3
            //
            //on    : 1
            //off   : 0
            ID = 261;

            if(on_off)
            {
                //켜는 명령어
                usb_io_output(ID, 0, light, 0, 0, 0);

            }
            else
            {
                //끄는 명령어
                usb_io_output(ID, 0, light * (-1), 0, 0, 0);

            }
        }
    }
}
