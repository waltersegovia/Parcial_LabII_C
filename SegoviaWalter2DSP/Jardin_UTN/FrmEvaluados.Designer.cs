namespace Jardin_UTN
{
    partial class FrmEvaluados
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
            this.lstbEvaluados = new System.Windows.Forms.ListBox();
            this.lblListaDeEvaluados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbEvaluados
            // 
            this.lstbEvaluados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstbEvaluados.FormattingEnabled = true;
            this.lstbEvaluados.Location = new System.Drawing.Point(12, 27);
            this.lstbEvaluados.Name = "lstbEvaluados";
            this.lstbEvaluados.Size = new System.Drawing.Size(281, 264);
            this.lstbEvaluados.TabIndex = 0;
            // 
            // lblListaDeEvaluados
            // 
            this.lblListaDeEvaluados.AutoSize = true;
            this.lblListaDeEvaluados.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeEvaluados.Location = new System.Drawing.Point(9, 9);
            this.lblListaDeEvaluados.Name = "lblListaDeEvaluados";
            this.lblListaDeEvaluados.Size = new System.Drawing.Size(139, 15);
            this.lblListaDeEvaluados.TabIndex = 1;
            this.lblListaDeEvaluados.Text = "Lista De Alumnos Evaluados";
            // 
            // FrmEvaluados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Jardin_UTN.Properties.Resources.Jardín_52;
            this.ClientSize = new System.Drawing.Size(308, 306);
            this.Controls.Add(this.lblListaDeEvaluados);
            this.Controls.Add(this.lstbEvaluados);
            this.Name = "FrmEvaluados";
            this.Text = "Aula de Evaluados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEvaluados_FormClosing);
            this.Load += new System.EventHandler(this.FrmEvaluados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbEvaluados;
        private System.Windows.Forms.Label lblListaDeEvaluados;
    }
}