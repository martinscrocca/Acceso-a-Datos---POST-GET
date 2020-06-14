namespace Acceso_A_datos_Martin_Scrocca
{
    partial class FormListaConApellBuscado
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
            this.lstBuscaXapell = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBuscaXapell
            // 
            this.lstBuscaXapell.FormattingEnabled = true;
            this.lstBuscaXapell.Location = new System.Drawing.Point(131, 114);
            this.lstBuscaXapell.Name = "lstBuscaXapell";
            this.lstBuscaXapell.Size = new System.Drawing.Size(523, 290);
            this.lstBuscaXapell.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(631, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FormListaConApellBuscado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstBuscaXapell);
            this.Name = "FormListaConApellBuscado";
            this.Text = "FormListaConApellBuscado";
            this.Load += new System.EventHandler(this.FormListaConApellBuscado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBuscaXapell;
        private System.Windows.Forms.Button btnVolver;
    }
}