﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistente_De_Voz.Media 
{
    public class Chistes : Form1
    {
        public static void Chiste()
        {
            Random ChisteAlAlzar = new Random();
            int opc = ChisteAlAlzar.Next(1, 20);
            switch(opc)
            {
                case 1:
                    sonido.URL = @"Media\audio\Chistes\1.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 2:
                    sonido.URL = @"Media\audio\Chistes\2.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 3:
                    sonido.URL = @"Media\audio\Chistes\3.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 4:
                    sonido.URL = @"Media\audio\Chistes\4.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 5:
                    sonido.URL = @"Media\audio\Chistes\5.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 6:
                    sonido.URL = @"Media\audio\Chistes\6.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 7:
                    sonido.URL = @"Media\audio\Chistes\7.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 8:
                    sonido.URL = @"Media\audio\Chistes\8.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 9:
                    sonido.URL = @"Media\audio\Chistes\9.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 10:
                    sonido.URL = @"Media\audio\Chistes\10.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 11:
                    sonido.URL = @"Media\audio\Chistes\11.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 12:
                    sonido.URL = @"Media\audio\Chistes\12.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 13:
                    sonido.URL = @"Media\audio\Chistes\13.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 14:
                    sonido.URL = @"Media\audio\Chistes\14.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 15:
                    sonido.URL = @"Media\audio\Chistes\15.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 16:
                    sonido.URL = @"Media\audio\Chistes\16.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 17:
                    sonido.URL = @"Media\audio\Chistes\17.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 18:
                    sonido.URL = @"Media\audio\Chistes\18.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 19:
                    sonido.URL = @"Media\audio\Chistes\19.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
                case 20:
                    sonido.URL = @"Media\audio\Chistes\20.mp3";
                    sonido.controls.play();
                    opc = 0;
                    break;
            }         
        }
    }
}
