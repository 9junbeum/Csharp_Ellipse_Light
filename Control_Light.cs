using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace UioTest
{
    internal class Control_Light 
    {
        [DllImport("uio.dll")]
        private static extern bool usb_io_output(int pID, int cmd, int io1, int io2, int io3, int io4);
        [DllImport("uio.dll")]
        private static extern bool usb_io_reset(int pID);

        int ID = 0x261;
        int ITV = 0; //interval
        int light = 0;
        //타이머 생성.
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public void control_light(int light, bool on_off, int interval, int delay)
        {
            this.light = light;

            //사용법
            //
            //light : 1 ->Red
            //light : 2 ->Orange
            //light : 3 ->Green
            //
            //on_off : 1 -> on
            //on_off : 0 -> off
            //
            //interval 설정 값  hexa | deci
            //interval : 0  ->  0x00 |   0 (점멸 안함)
            //interval : 1  ->  0x11 |  17 (가장 빠르게 점멸)
            //interval : 2  ->  0x22 |  34
            //interval : 3  ->  0x33 |  51
            //interval : 4  ->  0x44 |  68
            //interval : 5  ->  0x55 |  85 (1초동안 깜.빡)
            //interval : 6  ->  0x66 | 102
            //interval : 7  ->  0x77 | 119
            //interval : 8  ->  0x88 | 136
            //interval : 9  ->  0x99 | 153
            //interval : 10 ->  0xAA | 170 (2초동안 깜.빡)
            //interval : 11 ->  0xBB | 187
            //interval : 12 ->  0xCC | 204
            //interval : 13 ->  0xDD | 221
            //interval : 14 ->  0xEE | 238
            //interval : 15 ->  0xFF | 255 (가장 느리게 점멸)
            //
            //delay 딜레이 (단위 ms)
            //delay : 0     -> 계속 유지
            //delay : 1000  -> 1초 유지


            switch (interval)
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

            if(delay > 0)
            {
                timer.Interval = delay;
            }
            timer.Tick += new EventHandler(OnTimedEvent);

            if (on_off)
            {
                timer.Stop();
                usb_io_output(ID, ITV, this.light, 0, 0, 0);
                if(delay != 0)
                {
                    //끄기 (초기화)
                    timer.Start();
                }
            }
            else
            {
                usb_io_output(ID, ITV, this.light * (-1), 0, 0, 0);
            }
            
        }
        
        private void OnTimedEvent(Object sender, System.EventArgs e)
        {
            //usb_io_reset(ID);
            usb_io_output(ID, 0, light * (-1), 0, 0, 0);
            timer.Stop();
        }

    }
}
