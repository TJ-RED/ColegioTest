namespace Amon
{
    partial class Form1
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
            this.dgv_Alumno = new System.Windows.Forms.DataGridView();
            this.dsv_Profesor = new System.Windows.Forms.DataGridView();
            this.ds_Alumnos = new System.Data.DataSet();
            this.dfv_Grados = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ds_profe = new System.Data.DataSet();
            this.ds_Grado = new System.Data.DataSet();
            this.gradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actulizarGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarListaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Dupli = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarDuplicadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ds_dupli = new System.Data.DataSet();
            this.btn_DelDupli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsv_Profesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfv_Grados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_profe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Grado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dupli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_dupli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Alumno
            // 
            this.dgv_Alumno.AllowUserToOrderColumns = true;
            this.dgv_Alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumno.Location = new System.Drawing.Point(22, 88);
            this.dgv_Alumno.Name = "dgv_Alumno";
            this.dgv_Alumno.Size = new System.Drawing.Size(454, 164);
            this.dgv_Alumno.TabIndex = 0;
            this.dgv_Alumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alumno_CellContentClick);
            // 
            // dsv_Profesor
            // 
            this.dsv_Profesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsv_Profesor.Location = new System.Drawing.Point(482, 88);
            this.dsv_Profesor.Name = "dsv_Profesor";
            this.dsv_Profesor.Size = new System.Drawing.Size(492, 164);
            this.dsv_Profesor.TabIndex = 1;
            // 
            // ds_Alumnos
            // 
            this.ds_Alumnos.DataSetName = "NewDataSet";
            // 
            // dfv_Grados
            // 
            this.dfv_Grados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dfv_Grados.Location = new System.Drawing.Point(234, 258);
            this.dfv_Grados.Name = "dfv_Grados";
            this.dfv_Grados.Size = new System.Drawing.Size(492, 164);
            this.dfv_Grados.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.gradoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeAlumnoToolStripMenuItem,
            this.actualizacionDeDatosToolStripMenuItem,
            this.darDeBajaToolStripMenuItem,
            this.refrescarListaToolStripMenuItem,
            this.toolStripSeparator1,
            this.eliminarDuplicadosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // ingresoDeAlumnoToolStripMenuItem
            // 
            this.ingresoDeAlumnoToolStripMenuItem.Name = "ingresoDeAlumnoToolStripMenuItem";
            this.ingresoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ingresoDeAlumnoToolStripMenuItem.Text = "Nuevo Ingreso";
            this.ingresoDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeAlumnoToolStripMenuItem_Click);
            // 
            // actualizacionDeDatosToolStripMenuItem
            // 
            this.actualizacionDeDatosToolStripMenuItem.Name = "actualizacionDeDatosToolStripMenuItem";
            this.actualizacionDeDatosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.actualizacionDeDatosToolStripMenuItem.Text = "Actualizacion de datos";
            this.actualizacionDeDatosToolStripMenuItem.Click += new System.EventHandler(this.actualizacionDeDatosToolStripMenuItem_Click);
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.darDeBajaToolStripMenuItem.Text = "Dar de baja";
            this.darDeBajaToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaToolStripMenuItem_Click);
            // 
            // refrescarListaToolStripMenuItem
            // 
            this.refrescarListaToolStripMenuItem.Name = "refrescarListaToolStripMenuItem";
            this.refrescarListaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.refrescarListaToolStripMenuItem.Text = "Refrescar Lista";
            this.refrescarListaToolStripMenuItem.Click += new System.EventHandler(this.refrescarListaToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeProfesorToolStripMenuItem,
            this.actualizacionDeDatosToolStripMenuItem1,
            this.darDeBajaToolStripMenuItem1,
            this.refrescarListaToolStripMenuItem1});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // ingresoDeProfesorToolStripMenuItem
            // 
            this.ingresoDeProfesorToolStripMenuItem.Name = "ingresoDeProfesorToolStripMenuItem";
            this.ingresoDeProfesorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ingresoDeProfesorToolStripMenuItem.Text = "Ingreso de Profesor";
            this.ingresoDeProfesorToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeProfesorToolStripMenuItem_Click);
            // 
            // actualizacionDeDatosToolStripMenuItem1
            // 
            this.actualizacionDeDatosToolStripMenuItem1.Name = "actualizacionDeDatosToolStripMenuItem1";
            this.actualizacionDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.actualizacionDeDatosToolStripMenuItem1.Text = "Actualizacion de Datos";
            this.actualizacionDeDatosToolStripMenuItem1.Click += new System.EventHandler(this.actualizacionDeDatosToolStripMenuItem1_Click);
            // 
            // darDeBajaToolStripMenuItem1
            // 
            this.darDeBajaToolStripMenuItem1.Name = "darDeBajaToolStripMenuItem1";
            this.darDeBajaToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.darDeBajaToolStripMenuItem1.Text = "Dar de baja";
            this.darDeBajaToolStripMenuItem1.Click += new System.EventHandler(this.darDeBajaToolStripMenuItem1_Click);
            // 
            // refrescarListaToolStripMenuItem1
            // 
            this.refrescarListaToolStripMenuItem1.Name = "refrescarListaToolStripMenuItem1";
            this.refrescarListaToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.refrescarListaToolStripMenuItem1.Text = "Refrescar Lista";
            this.refrescarListaToolStripMenuItem1.Click += new System.EventHandler(this.refrescarListaToolStripMenuItem_Click);
            // 
            // ds_profe
            // 
            this.ds_profe.DataSetName = "NewDataSet";
            // 
            // ds_Grado
            // 
            this.ds_Grado.DataSetName = "NewDataSet";
            // 
            // gradoToolStripMenuItem
            // 
            this.gradoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearGradoToolStripMenuItem,
            this.actulizarGradoToolStripMenuItem,
            this.eliminarGradoToolStripMenuItem,
            this.refrescarListaToolStripMenuItem2});
            this.gradoToolStripMenuItem.Name = "gradoToolStripMenuItem";
            this.gradoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.gradoToolStripMenuItem.Text = "Grado";
            // 
            // crearGradoToolStripMenuItem
            // 
            this.crearGradoToolStripMenuItem.Name = "crearGradoToolStripMenuItem";
            this.crearGradoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.crearGradoToolStripMenuItem.Text = "Crear Grado";
            this.crearGradoToolStripMenuItem.Click += new System.EventHandler(this.crearGradoToolStripMenuItem_Click);
            // 
            // actulizarGradoToolStripMenuItem
            // 
            this.actulizarGradoToolStripMenuItem.Name = "actulizarGradoToolStripMenuItem";
            this.actulizarGradoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.actulizarGradoToolStripMenuItem.Text = "Actulizar Grado";
            this.actulizarGradoToolStripMenuItem.Click += new System.EventHandler(this.actulizarGradoToolStripMenuItem_Click);
            // 
            // eliminarGradoToolStripMenuItem
            // 
            this.eliminarGradoToolStripMenuItem.Name = "eliminarGradoToolStripMenuItem";
            this.eliminarGradoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.eliminarGradoToolStripMenuItem.Text = "Eliminar Grado";
            this.eliminarGradoToolStripMenuItem.Click += new System.EventHandler(this.eliminarGradoToolStripMenuItem_Click);
            // 
            // refrescarListaToolStripMenuItem2
            // 
            this.refrescarListaToolStripMenuItem2.Name = "refrescarListaToolStripMenuItem2";
            this.refrescarListaToolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.refrescarListaToolStripMenuItem2.Text = "Refrescar lista";
            this.refrescarListaToolStripMenuItem2.Click += new System.EventHandler(this.refrescarListaToolStripMenuItem_Click);
            // 
            // dgv_Dupli
            // 
            this.dgv_Dupli.AllowUserToOrderColumns = true;
            this.dgv_Dupli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dupli.Location = new System.Drawing.Point(22, 432);
            this.dgv_Dupli.Name = "dgv_Dupli";
            this.dgv_Dupli.Size = new System.Drawing.Size(454, 164);
            this.dgv_Dupli.TabIndex = 4;
            this.dgv_Dupli.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // eliminarDuplicadosToolStripMenuItem
            // 
            this.eliminarDuplicadosToolStripMenuItem.Name = "eliminarDuplicadosToolStripMenuItem";
            this.eliminarDuplicadosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarDuplicadosToolStripMenuItem.Text = "Eliminar Duplicados";
            this.eliminarDuplicadosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDuplicadosToolStripMenuItem_Click);
            // 
            // ds_dupli
            // 
            this.ds_dupli.DataSetName = "NewDataSet";
            // 
            // btn_DelDupli
            // 
            this.btn_DelDupli.BackColor = System.Drawing.Color.Red;
            this.btn_DelDupli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DelDupli.Location = new System.Drawing.Point(482, 432);
            this.btn_DelDupli.Name = "btn_DelDupli";
            this.btn_DelDupli.Size = new System.Drawing.Size(124, 23);
            this.btn_DelDupli.TabIndex = 5;
            this.btn_DelDupli.Text = "Remover Duplicados";
            this.btn_DelDupli.UseVisualStyleBackColor = false;
            this.btn_DelDupli.Visible = false;
            this.btn_DelDupli.Click += new System.EventHandler(this.btn_DelDupli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 608);
            this.Controls.Add(this.btn_DelDupli);
            this.Controls.Add(this.dgv_Dupli);
            this.Controls.Add(this.dfv_Grados);
            this.Controls.Add(this.dsv_Profesor);
            this.Controls.Add(this.dgv_Alumno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsv_Profesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfv_Grados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_profe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Grado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dupli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_dupli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Alumno;
        private System.Windows.Forms.DataGridView dsv_Profesor;
        private System.Windows.Forms.DataGridView dfv_Grados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
        public System.Data.DataSet ds_Alumnos;
        private System.Windows.Forms.ToolStripMenuItem refrescarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionDeDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refrescarListaToolStripMenuItem1;
        public System.Data.DataSet ds_profe;
        public System.Data.DataSet ds_Grado;
        private System.Windows.Forms.ToolStripMenuItem gradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actulizarGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrescarListaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eliminarDuplicadosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_Dupli;
        public System.Data.DataSet ds_dupli;
        private System.Windows.Forms.Button btn_DelDupli;
    }
}

