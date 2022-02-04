using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using System.Threading;

namespace UIOTestdll
{
    internal class Control 
    {
        [DllImport("uio.dll")]
        private static extern bool usb_io_output(int pID, int cmd, int io1, int io2, int io3, int io4);

        public void control_light(int light, bool on_off, int interval)
        {
            //사용법
            //
            //Red   : 1
            //Orange: 2
            //Green : 3
            //
            //on    : 1
            //off   : 0
            //
            //                  hexa | deci
            //delay_ms : 0  ->  유지
            //delay_ms : 1  ->  0x11 |  17 (가장 빠르게 점멸)
            //delay_ms : 2  ->  0x22 |  34
            //delay_ms : 3  ->  0x33 |  51
            //delay_ms : 4  ->  0x44 |  68
            //delay_ms : 5  ->  0x55 |  85 (1초동안 깜.빡)
            //delay_ms : 6  ->  0x66 | 102
            //delay_ms : 7  ->  0x77 | 119
            //delay_ms : 8  ->  0x88 | 136
            //delay_ms : 9  ->  0x99 | 153
            //delay_ms : 10 ->  0xAA | 170 (2초동안 깜.빡)
            //delay_ms : 11 ->  0xBB | 187
            //delay_ms : 12 ->  0xCC | 204
            //delay_ms : 13 ->  0xDD | 221
            //delay_ms : 14 ->  0xEE | 238
            //delay_ms : 15 ->  0xFF | 255 (가장 느리게 점멸)

            int ID = 261;
            int ITV = 0; //interval

            switch(interval)
            {
                case  0: ITV =   0; break;
                case  1: ITV =  17; break;
                case  2: ITV =  34; break;
                case  3: ITV =  51; break;
                case  4: ITV =  68; break;
                case  5: ITV =  85; break;
                case  6: ITV = 102; break;
                case  7: ITV = 119; break;
                case  8: ITV = 136; break;
                case  9: ITV = 153; break;
                case 10: ITV = 170; break;
                case 11: ITV = 187; break;
                case 12: ITV = 204; break;
                case 13: ITV = 221; break;
                case 14: ITV = 238; break;
                case 15: ITV = 255; break;
                default: ITV =   0; break;
            }

            if(on_off)
            {
                usb_io_output(ID, ITV, light, 0, 0, 0);
            }
            else
            {
                usb_io_output(ID, ITV, light * (-1), 0, 0, 0);
            }
            
        }
    }
}
