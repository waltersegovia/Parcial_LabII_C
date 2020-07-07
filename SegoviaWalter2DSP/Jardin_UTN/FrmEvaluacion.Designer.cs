namespace Jardin_UTN
{
    partial class FrmEvaluacion
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
            this.components = new System.ComponentModel.Container();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblEvaluando = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lstbAEvaluar = new System.Windows.Forms.ListBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblListaAlumnos = new System.Windows.Forms.Label();
            this.lblProxAlumno = new System.Windows.Forms.Label();
            this.txtProximoAlumno = new System.Windows.Forms.TextBox();
            this.lblReloj = new System.Windows.Forms.Label();
            this.tmReloj = new System.Windows.Forms.Timer(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(12, 30);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(46, 13);
            this.lblProfesor.TabIndex = 0;
            this.lblProfesor.Text = "Profesor";
            // 
            // lblEvaluando
            // 
            this.lblEvaluando.AutoSize = true;
            this.lblEvaluando.Location = new System.Drawing.Point(165, 53);
            this.lblEvaluando.Name = "lblEvaluando";
            this.lblEvaluando.Size = new System.Drawing.Size(70, 13);
            this.lblEvaluando.TabIndex = 1;
            this.lblEvaluando.Text = "Evaluando a:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(247, 30);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAlumno.TabIndex = 2;
            this.lblAlumno.Text = "Alumno";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(430, 30);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "Nota";
            // 
            // lstbAEvaluar
            // 
            this.lstbAEvaluar.FormattingEnabled = true;
            this.lstbAEvaluar.Location = new System.Drawing.Point(12, 105);
            this.lstbAEvaluar.Name = "lstbAEvaluar";
            this.lstbAEvaluar.Size = new System.Drawing.Size(248, 186);
            this.lstbAEvaluar.TabIndex = 4;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(12, 50);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(138, 20);
            this.txtProfesor.TabIndex = 5;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(250, 50);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(138, 20);
            this.txtAlumno.TabIndex = 6;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(422, 50);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(48, 20);
            this.txtNota.TabIndex = 7;
            // 
            // lblListaAlumnos
            // 
            this.lblListaAlumnos.AutoSize = true;
            this.lblListaAlumnos.Location = new System.Drawing.Point(12, 89);
            this.lblListaAlumnos.Name = "lblListaAlumnos";
            this.lblListaAlumnos.Size = new System.Drawing.Size(87, 13);
            this.lblListaAlumnos.TabIndex = 8;
            this.lblListaAlumnos.Text = "Lista de Alumnos";
            // 
            // lblProxAlumno
            // 
            this.lblProxAlumno.AutoSize = true;
            this.lblProxAlumno.Font = new System.Drawing.Font("Averia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxAlumno.Location = new System.Drawing.Point(286, 90);
            this.lblProxAlumno.Name = "lblProxAlumno";
            this.lblProxAlumno.Size = new System.Drawing.Size(167, 12);
            this.lblProxAlumno.TabIndex = 9;
            this.lblProxAlumno.Text = "Próximo Alumno a ser evaluado";
            // 
            // txtProximoAlumno
            // 
            this.txtProximoAlumno.Location = new System.Drawing.Point(281, 105);
            this.txtProximoAlumno.Name = "txtProximoAlumno";
            this.txtProximoAlumno.Size = new System.Drawing.Size(172, 20);
            this.txtProximoAlumno.TabIndex = 10;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(326, 186);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(51, 16);
            this.lblReloj.TabIndex = 11;
            this.lblReloj.Text = "label1";
            // 
            // tmReloj
            // 
            this.tmReloj.Enabled = true;
            this.tmReloj.Tick += new System.EventHandler(this.tmReloj_Tick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancelar.Location = new System.Drawing.Point(395, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(395, 224);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 13;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // FrmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Jardin_UTN.Properties.Resources.Jardín_3;
            this.ClientSize = new System.Drawing.Size(482, 307);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.txtProximoAlumno);
            this.Controls.Add(this.lblProxAlumno);
            this.Controls.Add(this.lblListaAlumnos);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.lstbAEvaluar);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblEvaluando);
            this.Controls.Add(this.lblProfesor);
            this.Name = "FrmEvaluacion";
            this.Text = "Aula de Evaluacion";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEvaluacion_FormClosing);
            this.Load += new System.EventHandler(this.FrmEvaluacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblEvaluando;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.ListBox lstbAEvaluar;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblListaAlumnos;
        private System.Windows.Forms.Label lblProxAlumno;
        private System.Windows.Forms.TextBox txtProximoAlumno;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer tmReloj;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEvaluar;
    }
}