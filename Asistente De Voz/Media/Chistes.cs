using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Asistente_De_Voz.Media
{
    public class Chistes
    {
        WindowsMediaPlayer Sonido = new WindowsMediaPlayer();
        public void Chiste()
        {
            Random ChisteAlAlzar = new Random();
            int opc = ChisteAlAlzar.Next(1, 20);
            switch(opc)
            {
                case 1:
                    Sonido.URL = @"Media\audio\Chistes\1.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 2:
                    Sonido.URL = @"Media\audio\Chistes\2.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 3:
                    Sonido.URL = @"Media\audio\Chistes\3.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 4:
                    Sonido.URL = @"Media\audio\Chistes\4.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 5:
                    Sonido.URL = @"Media\audio\Chistes\5.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 6:
                    Sonido.URL = @"Media\audio\Chistes\6.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 7:
                    Sonido.URL = @"Media\audio\Chistes\7.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 8:
                    Sonido.URL = @"Media\audio\Chistes\8.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 9:
                    Sonido.URL = @"Media\audio\Chistes\9.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 10:
                    Sonido.URL = @"Media\audio\Chistes\10.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 11:
                    Sonido.URL = @"Media\audio\Chistes\11.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 12:
                    Sonido.URL = @"Media\audio\Chistes\12.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 13:
                    Sonido.URL = @"Media\audio\Chistes\13.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 14:
                    Sonido.URL = @"Media\audio\Chistes\14.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 15:
                    Sonido.URL = @"Media\audio\Chistes\15.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 16:
                    Sonido.URL = @"Media\audio\Chistes\16.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 17:
                    Sonido.URL = @"Media\audio\Chistes\17.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 18:
                    Sonido.URL = @"Media\audio\Chistes\18.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 19:
                    Sonido.URL = @"Media\audio\Chistes\19.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
                case 20:
                    Sonido.URL = @"Media\audio\Chistes\20.mp3";
                    Sonido.controls.play();
                    opc = 0;
                    break;
            }         
        }
    }
}
