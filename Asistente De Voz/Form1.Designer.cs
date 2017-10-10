namespace Asistente_De_Voz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Activar = new System.Windows.Forms.Button();
            this.Detener = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Activar
            // 
            this.Activar.BackColor = System.Drawing.Color.Green;
            this.Activar.BackgroundImage = global::Asistente_De_Voz.Properties.Resources.microfono_grabador1;
            resources.ApplyResources(this.Activar, "Activar");
            this.Activar.Name = "Activar";
            this.Activar.UseVisualStyleBackColor = false;
            this.Activar.Click += new System.EventHandler(this.Activar_Click);
            // 
            // Detener
            // 
            this.Detener.BackColor = System.Drawing.Color.Red;
            this.Detener.BackgroundImage = global::Asistente_De_Voz.Properties.Resources.mutevoice;
            resources.ApplyResources(this.Detener, "Detener");
            this.Detener.Name = "Detener";
            this.Detener.UseVisualStyleBackColor = false;
            this.Detener.Click += new System.EventHandler(this.Detener_Click);
            // 
            // Estado
            // 
            resources.ApplyResources(this.Estado, "Estado");
            this.Estado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Estado.ForeColor = System.Drawing.Color.Snow;
            this.Estado.Name = "Estado";
            // 
            // resultado
            // 
            resources.ApplyResources(this.resultado, "resultado");
            this.resultado.BackColor = System.Drawing.Color.Snow;
            this.resultado.Name = "resultado";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Asistente_De_Voz.Properties.Resources._18926346_1309854035796351_723634850_o;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Detener);
            this.Controls.Add(this.Activar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Activar;
        private System.Windows.Forms.Button Detener;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

