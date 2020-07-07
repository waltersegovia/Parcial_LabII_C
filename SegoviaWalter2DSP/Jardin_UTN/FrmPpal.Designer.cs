namespace Jardin_UTN
{
    partial class FrmPpal
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
            this.lstvAlumnos = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvDocentes = new System.Windows.Forms.ListView();
            this.colIdDocente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEdadDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDniDOc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDireccionDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecreo = new System.Windows.Forms.Label();
            this.lstvAulas = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aEvaluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvAlumnos
            // 
            this.lstvAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colEdad,
            this.colDni,
            this.colDireccion});
            this.lstvAlumnos.HideSelection = false;
            this.lstvAlumnos.Location = new System.Drawing.Point(23, 204);
            this.lstvAlumnos.Name = "lstvAlumnos";
            this.lstvAlumnos.Size = new System.Drawing.Size(579, 198);
            this.lstvAlumnos.TabIndex = 1;
            this.lstvAlumnos.UseCompatibleStateImageBehavior = false;
            this.lstvAlumnos.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID Alumno";
            this.colId.Width = 77;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNombre.Width = 65;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colApellido.Width = 97;
            // 
            // colEdad
            // 
            this.colEdad.Text = "Edad";
            this.colEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEdad.Width = 97;
            // 
            // colDni
            // 
            this.colDni.Text = "DNI";
            this.colDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDni.Width = 90;
            // 
            // colDireccion
            // 
            this.colDireccion.Text = "Dirección";
            this.colDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDireccion.Width = 157;
            // 
            // lstvDocentes
            // 
            this.lstvDocentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdDocente,
            this.colNom,
            this.colApell,
            this.colEdadDoc,
            this.colSexo,
            this.colDniDOc,
            this.colDireccionDoc,
            this.colEmail});
            this.lstvDocentes.HideSelection = false;
            this.lstvDocentes.Location = new System.Drawing.Point(23, 44);
            this.lstvDocentes.Name = "lstvDocentes";
            this.lstvDocentes.Size = new System.Drawing.Size(765, 154);
            this.lstvDocentes.TabIndex = 2;
            this.lstvDocentes.UseCompatibleStateImageBehavior = false;
            this.lstvDocentes.View = System.Windows.Forms.View.Details;
            // 
            // colIdDocente
            // 
            this.colIdDocente.Text = "ID Docente";
            this.colIdDocente.Width = 73;
            // 
            // colNom
            // 
            this.colNom.Text = "Nombre";
            this.colNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNom.Width = 72;
            // 
            // colApell
            // 
            this.colApell.Text = "Apellido";
            this.colApell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colApell.Width = 103;
            // 
            // colEdadDoc
            // 
            this.colEdadDoc.Text = "Edad";
            this.colEdadDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEdadDoc.Width = 74;
            // 
            // colSexo
            // 
            this.colSexo.Text = "Sexo";
            this.colSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSexo.Width = 98;
            // 
            // colDniDOc
            // 
            this.colDniDOc.Text = "DNI";
            this.colDniDOc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDniDOc.Width = 141;
            // 
            // colDireccionDoc
            // 
            this.colDireccionDoc.Text = "Dirección";
            this.colDireccionDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEmail.Width = 108;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeDocentesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // listaDeDocentesToolStripMenuItem
            // 
            this.listaDeDocentesToolStripMenuItem.Name = "listaDeDocentesToolStripMenuItem";
            this.listaDeDocentesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listaDeDocentesToolStripMenuItem.Text = "Lista de Docentes";
            this.listaDeDocentesToolStripMenuItem.Click += new System.EventHandler(this.listaDeDocentesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarDocentesToolStripMenuItem,
            this.aEvaluarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // guardarDocentesToolStripMenuItem
            // 
            this.guardarDocentesToolStripMenuItem.Name = "guardarDocentesToolStripMenuItem";
            this.guardarDocentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarDocentesToolStripMenuItem.Text = "Guardar Docentes ";
            this.guardarDocentesToolStripMenuItem.Click += new System.EventHandler(this.guardarDocentesToolStripMenuItem_Click);
            // 
            // lblRecreo
            // 
            this.lblRecreo.AutoSize = true;
            this.lblRecreo.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecreo.Location = new System.Drawing.Point(794, 177);
            this.lblRecreo.Name = "lblRecreo";
            this.lblRecreo.Size = new System.Drawing.Size(50, 21);
            this.lblRecreo.TabIndex = 4;
            this.lblRecreo.Text = "label1";
            // 
            // lstvAulas
            // 
            this.lstvAulas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.lstvAulas.HideSelection = false;
            this.lstvAulas.Location = new System.Drawing.Point(620, 204);
            this.lstvAulas.Name = "lstvAulas";
            this.lstvAulas.Size = new System.Drawing.Size(168, 198);
            this.lstvAulas.TabIndex = 5;
            this.lstvAulas.UseCompatibleStateImageBehavior = false;
            this.lstvAulas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID ";
            this.columnHeader13.Width = 52;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Sala";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 85;
            // 
            // aEvaluarToolStripMenuItem
            // 
            this.aEvaluarToolStripMenuItem.Name = "aEvaluarToolStripMenuItem";
            this.aEvaluarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aEvaluarToolStripMenuItem.Text = "Evaluar Alumno";
            this.aEvaluarToolStripMenuItem.Click += new System.EventHandler(this.aEvaluarToolStripMenuItem_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Jardin_UTN.Properties.Resources.r10;
            this.ClientSize = new System.Drawing.Size(986, 495);
            this.Controls.Add(this.lstvAulas);
            this.Controls.Add(this.lblRecreo);
            this.Controls.Add(this.lstvDocentes);
            this.Controls.Add(this.lstvAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPpal";
            this.Text = "Jardin UTN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstvAlumnos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colEdad;
        private System.Windows.Forms.ColumnHeader colDni;
        private System.Windows.Forms.ColumnHeader colDireccion;
        private System.Windows.Forms.ListView lstvDocentes;
        private System.Windows.Forms.ColumnHeader colIdDocente;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colApell;
        private System.Windows.Forms.ColumnHeader colEdadDoc;
        private System.Windows.Forms.ColumnHeader colSexo;
        private System.Windows.Forms.ColumnHeader colDniDOc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeDocentesToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colDireccionDoc;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarDocentesToolStripMenuItem;
        private System.Windows.Forms.Label lblRecreo;
        private System.Windows.Forms.ListView lstvAulas;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aEvaluarToolStripMenuItem;
    }
}

