﻿namespace VISTA
{
    partial class FormBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenida));
            this.label2 = new System.Windows.Forms.Label();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnREGISTRARME = new System.Windows.Forms.Button();
            this.btnINICIARSESION = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "2K-Pizza";
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.Tomato;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSALIR.Location = new System.Drawing.Point(48, 258);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(116, 23);
            this.btnSALIR.TabIndex = 8;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnREGISTRARME
            // 
            this.btnREGISTRARME.BackColor = System.Drawing.Color.Orange;
            this.btnREGISTRARME.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnREGISTRARME.Location = new System.Drawing.Point(48, 229);
            this.btnREGISTRARME.Name = "btnREGISTRARME";
            this.btnREGISTRARME.Size = new System.Drawing.Size(116, 23);
            this.btnREGISTRARME.TabIndex = 7;
            this.btnREGISTRARME.Text = "Registrarme";
            this.btnREGISTRARME.UseVisualStyleBackColor = false;
            this.btnREGISTRARME.Click += new System.EventHandler(this.btnREGISTRARME_Click);
            // 
            // btnINICIARSESION
            // 
            this.btnINICIARSESION.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnINICIARSESION.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnINICIARSESION.Location = new System.Drawing.Point(48, 200);
            this.btnINICIARSESION.Name = "btnINICIARSESION";
            this.btnINICIARSESION.Size = new System.Drawing.Size(116, 23);
            this.btnINICIARSESION.TabIndex = 6;
            this.btnINICIARSESION.Text = "Iniciar Sesion";
            this.btnINICIARSESION.UseVisualStyleBackColor = false;
            this.btnINICIARSESION.Click += new System.EventHandler(this.btnINICIARSESION_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(221, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnREGISTRARME);
            this.Controls.Add(this.btnINICIARSESION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBienvenida";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.FormBienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnREGISTRARME;
        private System.Windows.Forms.Button btnINICIARSESION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

