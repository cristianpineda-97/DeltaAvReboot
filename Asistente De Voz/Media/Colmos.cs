using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistente_De_Voz.Media
{
    public class Colmos : Form1
    {
        public static void Colmo()
        {
            Random ColmoAlAlzar = new Random();
            int opc = ColmoAlAlzar.Next(1, 20);
            switch (opc)
            {
                case 1:
                    sonido.URL = @"Media\audio\Colmos\1.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 2:
                    sonido.URL = @"Media\audio\Colmos\2.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 3:
                    sonido.URL = @"Media\audio\Colmos\3.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 4:
                    sonido.URL = @"Media\audio\Colmos\4.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 5:
                    sonido.URL = @"Media\audio\Colmos\5.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 6:
                    sonido.URL = @"Media\audio\Colmos\6.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 7:
                    sonido.URL = @"Media\audio\Colmos\7.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 8:
                    sonido.URL = @"Media\audio\Colmos\8.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 9:
                    sonido.URL = @"Media\audio\Colmos\9.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 10:
                    sonido.URL = @"Media\audio\Colmos\10.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 11:
                    sonido.URL = @"Media\audio\Colmos\11.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 12:
                    sonido.URL = @"Media\audio\Colmos\12.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 13:
                    sonido.URL = @"Media\audio\Colmos\13.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 14:
                    sonido.URL = @"Media\audio\Colmos\14.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 15:
                    sonido.URL = @"Media\audio\Colmos\15.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 16:
                    sonido.URL = @"Media\audio\Colmos\16.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 17:
                    sonido.URL = @"Media\audio\Colmos\17.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 18:
                    sonido.URL = @"Media\audio\Colmos\18.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 19:
                    sonido.URL = @"Media\audio\Colmos\19.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 20:
                    sonido.URL = @"Media\audio\Colmos\20.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
            }
        }
    }
}
