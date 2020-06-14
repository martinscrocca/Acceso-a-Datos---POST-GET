namespace Acceso_A_datos_Martin_Scrocca
{
    partial class ListaCompleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSalirAPP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(101, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(533, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(675, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnSalirAPP
            // 
            this.btnSalirAPP.Location = new System.Drawing.Point(46, 415);
            this.btnSalirAPP.Name = "btnSalirAPP";
            this.btnSalirAPP.Size = new System.Drawing.Size(75, 23);
            this.btnSalirAPP.TabIndex = 2;
            this.btnSalirAPP.Text = "Salir App";
            this.btnSalirAPP.UseVisualStyleBackColor = true;
            this.btnSalirAPP.Click += new System.EventHandler(this.BtnSalirAPP_Click);
            // 
            // ListaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirAPP);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listBox1);
            this.Name = "ListaCompleta";
            this.Text = "ListaCompleta";
            this.Load += new System.EventHandler(this.ListaCompleta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalirAPP;
    }
}