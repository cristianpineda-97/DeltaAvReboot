using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using WMPLib;
using Asistente_De_Voz.Media;

namespace Asistente_De_Voz
{
    public partial class Form1 : Form
    {
        public static WindowsMediaPlayer sonido = new WindowsMediaPlayer();
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        string opc;
        public Form1()
        {
            InitializeComponent();
            Activar.BackColor = Color.Green;
            Detener.Visible = false;
            label3.Visible = false;
            resultado.Text = "OFF";
            resultado.BackColor = Color.Red;
            AudioNivel.Visible = false;
            sonido.URL = @"Media\Audio\HolaAbrir.mp3";
            sonido.controls.play();
        }
        private void Activar_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultado.Text == "OFF")
                {
                    sonido.URL = @"Media\Audio\HolaActivado.mp3";
                    sonido.controls.play();
                }
                else if (resultado.Text == "ON")
                {
                    sonido.URL = @"Media\Audio\HolaActivado.mp3";
                    sonido.controls.stop();
                }
                resultado.Text = "ON";
                resultado.BackColor = Color.Green;
                Detener.Visible = true;
                label3.Visible = true;
                Activar.Visible = false;
                label2.Visible = false;
                Detener.BackColor = Color.Red;
                AudioNivel.Visible = true;
                _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Media\comandos.txt")))));
                _recognizer.SetInputToDefaultAudioDevice();
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
                _recognizer.SpeechRecognized += _recognizer_SpeechRecognized;
                _recognizer.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(MedidorDeAudios);

            }
            catch (Exception error)
            {
                sonido.controls.stop();
                Activar.BackColor = Color.Red;
                Detener.BackColor = Color.Green;
                resultado.Text = "OFF";
                resultado.BackColor = Color.Red;
                AudioNivel.Visible = false;
                MessageBox.Show(error.Message, "Se Ha Encontrado Un Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        private void MedidorDeAudios(object s, AudioLevelUpdatedEventArgs e)
        {
            AudioNivel.Value = e.AudioLevel;
        }
        private void Detener_Click(object sender, EventArgs e)
        {
                resultado.Text = "OFF";
                resultado.BackColor = Color.Red;
                Detener.Visible = false;
                label3.Visible = false;
                Activar.Visible = true;
                label2.Visible = true;
                AudioNivel.Visible = false;
                Detener.BackColor = Color.Red;
                sonido.URL = @"Media\Audio\Detener.mp3";
                sonido.controls.play();
                _recognizer.RecognizeAsyncStop();
        }
        public void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            opc = e.Result.Text;
            switch (opc)
            {
                //-----------------------------esto ya es para los comandos Todos Con If------------------------------------------//

                case "abrirgoogle..":
                    sonido.URL = @"Media\Audio\AbrirNavegador.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("chrome.exe");
                    break;

                case "abrirexcel..":
                    sonido.URL = @"Media\Audio\AbrirExcel.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("excel.exe");
                    break;

                case "abrirword..":
                    sonido.URL = @"Media\Audio\AbrirWord.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("winword.exe");
                    break;

                case "adiosdelta..":
                    sonido.URL = @"Media\Audio\Adios.mp3";
                    sonido.controls.play();
                    Application.Exit();
                    break;

                case "abrirblocdenotas..":
                    sonido.URL = @"Media\Audio\AbrirBlocDeNotas.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("notepad.exe");
                    break;

                case "abriryoutube..":
                    sonido.URL = @"Media\Audio\AbrirYoutube.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("http://www.youtube.com");
                    break;

                case "abrirfacebook..":
                    sonido.URL = @"Media\Audio\AbrirFacebook.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("http://www.facebook.com");
                    break;

                case "abrirmusica..":
                    sonido.URL = @"Media\Audio\AbrirMusica.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("wmplayer.exe");
                    break;

                case "DeltaQueesUnAndroid..":
                    sonido.URL = @"Media\Audio\QueEsAndroid.mp3";
                    sonido.controls.play();
                    break;

                case "abrirwhatsappweb..":
                    sonido.URL = @"Media\Audio\AbrirWhatsapp.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("https://web.whatsapp.com");
                    break;

                case "holadelta..":
                    sonido.URL = @"Media\Audio\HolaSaludo.mp3";
                    sonido.controls.play();
                    break;

                case "comoestas..":
                    sonido.URL = @"Media\Audio\PuesMuyBien.mp3";
                    sonido.controls.play();
                    break;

                case "muybien...":
                    sonido.URL = @"Media\Audio\MeAlegroQueEsteBien.mp3";
                    sonido.controls.play();
                    break;
                case "puesmuybien...":
                    sonido.URL = @"Media\Audio\MeAlegroQueEsteBien.mp3";
                    sonido.controls.play();
                    break;

                case "abrirpaneldecontrol..":
                    sonido.URL = @"Media\Audio\AbrirPanelDeControl.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("control");
                    break;

                case "abrirpropiedadesdefechayhora..":
                    sonido.URL = @"Media\Audio\AbrirConfigFechaYHora.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("timedate.cpl");
                    break;

                case "abrirpropiedadesdepantalla..":
                    sonido.URL = @"Media\Audio\AbrirPropiePantalla.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("desk.cpl");
                    break;

                case "abrircalculadora..":
                    sonido.URL = @"Media\Audio\AbrirCalculadora.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("calc");
                    break;

                case "abrirpaint..":
                    sonido.URL = @"Media\Audio\AbrirPaint.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("mspaint");
                    break;

                case "apagarequipo..":
                    sonido.URL = @"Media\Audio\ApagarEquipo.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("shutdown", "-1");
                    break;
                    
                case "DeltaCuentameUnChiste..":
                    Media.Chistes.Chiste();
                    break;

                case "DeltaCuentameUnColmo..":
                    Media.Colmos.Colmo();
                    break;

                case "abrirPowerPoint..":
                    sonido.URL = @"Media\Audio\AbrirPowerPoint.mp3";
                    sonido.controls.play();
                    System.Diagnostics.Process.Start("POWERPNT");
                    break;

                //--------------------------------------Fin De La Lineas De Comandos---------------------------------------------//
                default:
                    break;
            }
        }
    }
}



