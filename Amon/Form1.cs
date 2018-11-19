using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Amon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conString;
        MySqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "server=tecdogt.com;user=root;database=admColegio;port=3306;password=masterola;Convert Zero Datetime=True";

            conn = new MySqlConnection(conString);

            try
            {
                conn.Open();

                String sql = @"Select * 
                                from admColegio.Alumno";


                using (MySqlDataAdapter dataAdap_Alu = new MySqlDataAdapter(sql, conn))
                {
                    ds_Alumnos.Clear();

                    dataAdap_Alu.Fill(ds_Alumnos);
                    dgv_Alumno.DataSource = ds_Alumnos.Tables[0];
                }


                sql = "Select * from admColegio.Profesor";
                using (MySqlDataAdapter dataAdap_prof = new MySqlDataAdapter(sql, conn))
                {
                    ds_profe.Clear();

                    dataAdap_prof.Fill(ds_profe);
                    dsv_Profesor.DataSource = ds_profe.Tables[0];
                }

                sql = @"Select 
	                        idGrado,
                            Nombre,
                            (
		                        Select concat(f.Nombre, ' ', f.Apellido)
                                from admColegio.Profesor f
                                where f.idProfesor = g.idProfesor
                            ) as `Nombre Profesor`
                        from admColegio.Grado g";

                using (MySqlDataAdapter dataAdap_Grado = new MySqlDataAdapter(sql, conn))
                {
                    ds_Grado.Clear();

                    dataAdap_Grado.Fill(ds_Grado);
                    dfv_Grados.DataSource = ds_Grado.Tables[0];
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ingresoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "admColegio.Alumno";
            addItemForm.connection = new MySqlConnection(conString); 

            addItemForm.ShowDialog();
        }

        private void dgv_Alumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refrescarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void actualizacionDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "Update.Alumno";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();

        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "Del.Alumno";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();
        }

        private void ingresoDeProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "admColegio.Profesor";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();
        }

        private void actualizacionDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "Update.Profesor";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();
        }

        private void darDeBajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "Del.Profesor";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();
        }

        private void crearGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "admColegio.Grado";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();
        }

        private void actulizarGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "Update.Grado";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();
        }

        private void eliminarGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItem addItemForm = new addItem();

            addItemForm.Tabla = "Del.Grado";
            addItemForm.connection = new MySqlConnection(conString);

            addItemForm.ShowDialog();
        }

        private void eliminarDuplicadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();

            String sql = @"Select idAlumno, Res as `Nombre y Apellido`, c as `Canidad de Duplicados` from
                            (
                                SELECT idAlumno, concat(upper(Nombres),' ',upper(Apellidos)) as Res, COUNT(*) c 
                                FROM admColegio.Alumno 
                                GROUP BY Res 
                                HAVING c > 1
                            ) a";

            using (MySqlDataAdapter dataAdap_Grado = new MySqlDataAdapter(sql, conn))
            {
                ds_dupli.Clear();

                dataAdap_Grado.Fill(ds_dupli);
                dgv_Dupli.DataSource = ds_dupli.Tables[0];

                if (ds_dupli.Tables[0].Rows.Count == 0)
                    MessageBox.Show("NO hay Duplicados");
                else
                {
                    dgv_Dupli.Show();
                    btn_DelDupli.Show();
                }
            }

            conn.Close();
        }

        private void btn_DelDupli_Click(object sender, EventArgs e)
        {
            int res = 0;
            //sender = "test";
            while (ds_dupli.Tables[0].Rows.Count > 0)
            {
                int i = 0;
                conn.Open();

                for (i = 0; i < ds_dupli.Tables[0].Rows.Count; i++)
                {
                    try
                    {

                        MySqlCommand com = conn.CreateCommand();
                        com.CommandText = @"Delete from admColegio.Alumno where idAlumno = ?ID";

                        com.Parameters.AddWithValue("?ID", ds_dupli.Tables[0].Rows[i][0].ToString());

                        com.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                conn.Close();

                res += i;

                eliminarDuplicadosToolStripMenuItem_Click(sender, e);
            }
            


            MessageBox.Show("Se eliminaron " + res + " catidad de registros duplicados");

        }
    }
}
