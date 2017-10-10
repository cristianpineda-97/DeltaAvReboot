using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using WMPLib;

namespace Asistente_De_Voz
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer sonido = new WindowsMediaPlayer();
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        bool HabilitarReconocimiento = true;
        string opc;
        public Form1()
        {
            InitializeComponent();
            Activar.BackColor = Color.Green;
            Detener.Visible = false;
            label3.Visible = false;
            resultado.Text = "OFF";
            resultado.BackColor = Color.Red;
            sonido.URL = @"Media\Audio\hola.wav";
            sonido.controls.play();
        }

        private void Activar_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultado.Text == "OFF")
                {
                    sonido.URL = @"Media\Audio\hola2.wav";
                    sonido.controls.play();
                }
                else if (resultado.Text == "ON")
                {
                    sonido.URL = @"Media\Audio\hola2.wav";
                    sonido.controls.stop();
                }
                resultado.Text = "ON";
                resultado.BackColor = Color.Green;
                Detener.Visible = true;
                label3.Visible = true;
                Activar.Visible = false;
                label2.Visible = false;
                Detener.BackColor = Color.Red;
                _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Media\comandos.txt")))));
                _recognizer.SpeechRecognized += _recognizer_SpeechRecognized;
                _recognizer.RecognizeCompleted += _recognizer_RecognizeCompleted;
                _recognizer.RecognizerUpdateReached += _recognizer_RecognizerUpdateReached;
                _recognizer.SetInputToDefaultAudioDevice();
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception error)
            {
                sonido.controls.stop();
                Activar.BackColor = Color.Red;
                Detener.BackColor = Color.Green;
                resultado.Text = "OFF";
                resultado.BackColor = Color.Red;
                MessageBox.Show(error.Message, "Se Ha Encontrado Un Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }

        private void _recognizer_RecognizerUpdateReached(object sender, RecognizerUpdateReachedEventArgs e)
        {
            HabilitarReconocimiento = false;
        }

        private void _recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
           HabilitarReconocimiento = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            if (Activar.BackColor != Color.Green)
            {
                MessageBox.Show("El Asistente Esta Desactivado", "Active El Asistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultado.Text = "OFF";
                resultado.BackColor = Color.Red;
                Detener.Visible = false;
                label3.Visible = false;
                Activar.Visible = true;
                label2.Visible = true;
                Detener.BackColor = Color.Red;
                sonido.URL = @"Media\Audio\detener.wav";
                sonido.controls.play();
                _recognizer.RecognizeAsyncStop();
            }
        }
        public void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            opc = e.Result.Text;
            if (HabilitarReconocimiento == true)
            {
                switch (opc)
                {
                    //-----------------------------esto ya es para los comandos Todos Con If------------------------------------------//

                    case "oyedeltaabregoogle....":             
                        sonido.URL = @"Media\Audio\google.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("chrome.exe");
                        break;

                    case "oyedeltaabreexcel....":
                        sonido.URL = @"Media\Audio\excel.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("excel.exe");
                        break;

                    case "oyedeltaabreword....":
                        sonido.URL = @"Media\Audio\word.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("winword.exe");
                        break;

                    case "adiosdelta....":
                        sonido.URL = @"Media\Audio\adiosdelta.wav";
                        sonido.controls.play();
                        Application.Exit();
                        break;

                    case "oyedeltaabreblocdenotas....":
                        sonido.URL = @"Media\Audio\notepad.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("notepad.exe");
                        break;

                    case "oyedeltaabreyoutube....":
                        sonido.URL = @"Media\Audio\youtube.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("http://www.youtube.com");
                        break;

                    case "oyedeltaabrefacebook....":
                        sonido.URL = @"Media\Audio\facebook.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("http://www.facebook.com");
                        break;

                    case "oyedeltaabremusica....":
                        sonido.URL = @"Media\Audio\wmp.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("wmplayer.exe");
                        break;

                    case "DeltaQueesAndroid....":
                        sonido.URL = @"Media\Audio\android.wav";
                        sonido.controls.play();
                        break;

                    case "oyedeltaabrewhatsappweb....":
                        sonido.URL = @"Media\Audio\whatsapp.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("https://web.whatsapp.com");
                        break;

                    case "holadelta....":
                        sonido.URL = @"Media\Audio\holadelta.wav";
                        sonido.controls.play();
                        break;

                    case "comoestas....":
                        sonido.URL = @"Media\Audio\gracias.wav";
                        sonido.controls.play();
                        break;

                    case "muybien....":
                        sonido.URL = @"Media\Audio\bien.wav";
                        sonido.controls.play();
                        break;
                    case "puesmuybien....":
                        sonido.URL = @"Media\Audio\bien.wav";
                        sonido.controls.play();
                        break;

                    case "oyedeltaabrepaneldecontrol....":
                        sonido.URL = @"Media\Audio\google.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("control");
                        break;

                    case "oyedeltaabrepropiedadesdefechayhora....":
                        sonido.URL = @"Media\Audio\google.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("timedate.cpl");
                        break;

                    case "oyedeltaabrepropiedadesdepantalla....":
                        sonido.URL = @"Media\Audio\google.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("desk.cpl");
                        break;

                    case "oyedeltaabrecalculadora....":
                        sonido.URL = @"Media\Audio\google.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("calc");
                        break;

                    case "oyedeltaabrepaint....":
                        sonido.URL = @"Media\Audio\google.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("mspaint");
                        break;

                    case "oyedeltaapagarequipo....":
                        sonido.URL = @"Media\Audio\google.wav";
                        sonido.controls.play();
                        System.Diagnostics.Process.Start("shutdown");
                        break;

                    //--------------------------------------Fin De La Lineas De Comandos---------------------------------------------//
                }
            }
            else
            {
                HabilitarReconocimiento = false;
            }
        }
    }
}


