using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amon
{
    public partial class addItem : Form
    {
        public addItem()
        {
            InitializeComponent();
        }

        public string Tabla { get; set; }
        public MySqlConnection connection { get; set; }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addItem_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Tabla);

            switch (Tabla)
            {
                case "admColegio.Alumno":
                    l_item.Text = "Nombre";
                    I_tem2.Text = "Apellido";
                    I_tem3.Text = "Genero";
                    I_tem4.Text = "Fecha Nacimiento";

                    PItem5.Hide();

                    textBox3.Hide();
                    textBox4.Hide();

                    comboG.Show();
                    dateEdad.Show();

                    btn_accept.Click += Btn_accept_Click_Alumno;

                    break;
                case "Update.Alumno":

                    l_item.Text = "Nombre";
                    I_tem2.Text = "Apellido";
                    I_tem3.Text = "Genero";
                    I_tem4.Text = "Fecha Nacimiento";
                    I_tem5.Text = "ID";

                    

                    textBox3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();

                    comboG.Show();
                    dateEdad.Show();
                    

                    String sql = @"Select 0 as idAlumno 
                                    union
                                    Select idAlumno from admColegio.Alumno";

                    updateIDS(sql);
                    ID.SelectedIndexChanged += ID_SelectedIndexChanged_update;


                    btn_accept.Click += Btn_accept_Click_AlumnoUpdate;

                    break;
                case "Del.Alumno":

                    l_item.Text = "Nombre";
                    I_tem2.Text = "Apellido";
                    I_tem3.Text = "Genero";
                    I_tem4.Text = "Fecha Nacimiento";
                    I_tem5.Text = "ID";


                    PItem.Enabled = false;
                    PItem2.Enabled = false;
                    PItem3.Enabled = false;
                    PItem4.Enabled = false;

                    textBox3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();

                    comboG.Show();
                    dateEdad.Show();

                    String sqlD = @"Select 0 as idAlumno 
                                    union
                                    Select idAlumno from admColegio.Alumno";

                    updateIDS(sqlD);
                    ID.SelectedIndexChanged += ID_SelectedIndexChanged_update;

                    btn_accept.Click += Btn_accept_Click_AlumnoDel;

                    break;
                case "admColegio.Profesor":
                    l_item.Text = "Nombre";
                    I_tem2.Text = "Apellido";
                    I_tem3.Text = "Genero";

                    PItem4.Hide();
                    PItem5.Hide();

                    textBox3.Hide();

                    comboG.Show();

                    btn_accept.Click += Btn_accept_Click_InsetProf;
                    break;
                case "Update.Profesor":
                    l_item.Text = "Nombre";
                    I_tem2.Text = "Apellido";
                    I_tem3.Text = "Genero";
                    I_tem5.Text = "ID";

                    PItem4.Hide();

                    textBox3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();

                    comboG.Show();
                    dateEdad.Show();


                    String sqlP = @"Select 0 as idAlumno 
                                    union
                                    Select idProfesor from admColegio.Profesor";

                    updateIDS(sqlP);
                    ID.SelectedIndexChanged += ID_SelectedIndexChanged_Prof;

                    btn_accept.Click += Btn_accept_Click_updateProd; ;
                    break;
                case "Del.Profesor":
                    l_item.Text = "Nombre";
                    I_tem2.Text = "Apellido";
                    I_tem3.Text = "Genero";
                    I_tem5.Text = "ID";

                    PItem4.Hide();

                    textBox3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();

                    PItem.Enabled = false;
                    PItem2.Enabled = false;
                    PItem3.Enabled = false;
                    PItem4.Enabled = false;

                    comboG.Show();
                    dateEdad.Show();


                    String sqlPD = @"Select 0 as idAlumno 
                                    union
                                    Select idProfesor from admColegio.Profesor";

                    updateIDS(sqlPD);
                    ID.SelectedIndexChanged += ID_SelectedIndexChanged_Prof;

                    btn_accept.Click += Btn_accept_Click_del_prof;
                    break;
                case "admColegio.Grado":
                    l_item.Text = "Nombre";
                    I_tem2.Text = "Nombre del Profesor";
                    I_tem3.Text = "Id Profesor";

                    PItem4.Hide();
                    PItem5.Hide();

                    textBox3.Hide();
                    textBox5.Hide();
                    PItem2.Enabled = false;

                    comboG.Show();
                    sqlPD = @"Select 0 as idAlumno 
                                    union
                                    Select idProfesor from admColegio.Profesor";
                    updateProf(sqlPD);

                    comboG.SelectedIndexChanged += ComboG_SelectedIndexChanged_cambioPrf;

                    btn_accept.Click += Btn_accept_Click_NuevoGrado;
                    break;
                case "Update.Grado":
                    l_item.Text = "Nombre";
                    I_tem2.Text = "Nombre del Profesor";
                    I_tem3.Text = "Id Profesor";
                    I_tem5.Text = "ID";

                    PItem4.Hide();

                    textBox3.Hide();
                    textBox5.Hide();
                    PItem2.Enabled = false;

                    sqlPD = @"Select 0 as idAlumno 
                                    union
                                    Select idGrado from admColegio.Grado";

                    updateIDS(sqlPD);
                    
                    comboG.Show();
                    sqlPD = @"Select 0 as idAlumno 
                                    union
                                    Select idProfesor from admColegio.Profesor";
                    updateProf(sqlPD);

                    comboG.SelectedIndexChanged += ComboG_SelectedIndexChanged_cambioPrf;
                    ID.SelectedIndexChanged += ID_SelectedIndexChanged_grado;


                    btn_accept.Click += Btn_accept_Click_updtG;
                    break;
                case "Del.Grado":
                    l_item.Text = "Nombre";
                    I_tem2.Text = "Nombre del Profesor";
                    I_tem5.Text = "ID";

                    PItem4.Hide();
                    PItem3.Hide();

                    textBox3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();

                    PItem.Enabled = false;
                    PItem2.Enabled = false;
                    PItem3.Enabled = false;
                    PItem4.Enabled = false;

                    comboG.Show();
                    dateEdad.Show();


                    sqlPD = @"Select 0 as idAlumno 
                                    union
                                    Select idGrado from admColegio.Grado";

                    updateIDS(sqlPD);
                    ID.SelectedIndexChanged += ID_SelectedIndexChanged_delGRado;

                    btn_accept.Click += Btn_accept_Click_Dele;
                    break;
            }
        }

        private void Btn_accept_Click_Dele(object sender, EventArgs e)
        {
            try
            {
                connection.Open();


                MySqlCommand com = connection.CreateCommand();
                com.CommandText = @"DELETE FROM `admColegio`.`Grado` WHERE (`idGrado` = ?ID);";

                com.Parameters.AddWithValue("?ID", ID.Text);

                com.ExecuteNonQuery();

                MessageBox.Show("Alumno Agregado Con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ID_SelectedIndexChanged_delGRado(object sender, EventArgs e)
        {

            try
            {
                connection.Open();

                string sql = @"Select g.Nombre,
	                                concat(f.Nombre, ' ', f.Apellido) as `Nombre profesor`
                                from 
	                                admColegio.Grado g,
                                    admColegio.Profesor f
                                where f.idProfesor = g.idProfesor 
                                and idGrado = " + ID.Text;

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int i = 0;
                    textBox1.Text = reader.GetString(i++);
                    textBox2.Text = reader.GetString(i++);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void Btn_accept_Click_updtG(object sender, EventArgs e)
        {
            try
            {
                connection.Open();


                MySqlCommand com = connection.CreateCommand();
                com.CommandText = @"UPDATE `admColegio`.`Grado` 
                                    SET `Nombre` = ?nombre, 
                                        `idProfesor` =  ?idpr
                                    WHERE (`idGrado` = ?ID);";

                com.Parameters.AddWithValue("?nombre", textBox1.Text);
                com.Parameters.AddWithValue("?idpr", comboG.Text);
                com.Parameters.AddWithValue("?ID", ID.Text);

                com.ExecuteNonQuery();

                
                MessageBox.Show("Alumno Agregado Con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ID_SelectedIndexChanged_grado(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql = @"Select Nombre, idProfesor from admColegio.Grado where idGrado = " + ID.Text;

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int i = 0;
                    textBox1.Text = reader.GetString(i++);

                    comboG.Text = reader.GetString(i++);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void Btn_accept_Click_NuevoGrado(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 )
                MessageBox.Show("El Campo Nombre es obligatorios");
            else
            {
                if (comboG.Text == "0")
                    MessageBox.Show("Se requiete que exista datos de profesores ingresados");
                else
                {
                    try
                    {
                        connection.Open();


                        MySqlCommand com = connection.CreateCommand();
                        com.CommandText = @"INSERT INTO `admColegio`.`Grado` (`Nombre`, `idProfesor`) 
                                        VALUES (?nombre, ?idPrf)";

                        com.Parameters.AddWithValue("?nombre", textBox1.Text);
                        com.Parameters.AddWithValue("?idPrf", comboG.Text);

                        com.ExecuteNonQuery();

                        MessageBox.Show("Alumno Agregado Con exito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }

        private void ComboG_SelectedIndexChanged_cambioPrf(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql = @"Select concat(Nombre, ' ', Apellido)  as  Nombre from admColegio.Profesor where idProfesor = " + comboG.Text;

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int i = 0;
                    textBox2.Text = reader.GetString(i++);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void Btn_accept_Click_del_prof(object sender, EventArgs e)
        {
            try
            {
                connection.Open();


                MySqlCommand com = connection.CreateCommand();
                com.CommandText = @"DELETE FROM `admColegio`.`Profesor` WHERE (`idProfesor` = ?ID);";

                com.Parameters.AddWithValue("?ID", ID.Text);

                com.ExecuteNonQuery();

                MessageBox.Show("Alumno Agregado Con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ID_SelectedIndexChanged_Prof(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql = @"Select Nombre, Apellido, Genero from admColegio.Profesor where idProfesor = " + ID.Text;

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int i = 0;
                    textBox1.Text = reader.GetString(i++);
                    textBox2.Text = reader.GetString(i++);
                    comboG.Text = reader.GetString(i++);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        private void Btn_accept_Click_updateProd(object sender, EventArgs e)
        {
            try
            {
                connection.Open();


                MySqlCommand com = connection.CreateCommand();
                com.CommandText = @"UPDATE `admColegio`.`Profesor`
                                    SET `Nombre` = ?nombre, 
                                        `Apellido` =  ?apellido, 
                                        `Genero` = ?g
                                    WHERE (`idProfesor` = ?ID);";

                com.Parameters.AddWithValue("?nombre", textBox1.Text);
                com.Parameters.AddWithValue("?apellido", textBox2.Text);
                com.Parameters.AddWithValue("?g", comboG.Text);
                com.Parameters.AddWithValue("?ID", ID.Text);

                com.ExecuteNonQuery();



                MessageBox.Show("Alumno Agregado Con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Btn_accept_Click_InsetProf(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                MessageBox.Show("Los Campos Nombre y Apellidos son obligatorios");
            else
            {
                try
                {
                    connection.Open();


                    MySqlCommand com = connection.CreateCommand();
                    com.CommandText = @"INSERT INTO `admColegio`.`Profesor` (`Nombre`, `Apellido`, `Genero`) 
                                        VALUES (?nombre, ?apellido, ?g)";

                    com.Parameters.AddWithValue("?nombre", textBox1.Text);
                    com.Parameters.AddWithValue("?apellido", textBox2.Text);
                    com.Parameters.AddWithValue("?g", comboG.Text);

                    com.ExecuteNonQuery();
                    
                    MessageBox.Show("Profesor Agregado Con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        void updateProf(String SQL)
        {
            if (SQL == "")
            {

            }
            else
                try
                {
                    connection.Open();

                    dataSet1.Clear();
                    var dataAdapD = new MySqlDataAdapter(SQL, connection);
                    dataAdapD.Fill(dataSet1);

                    comboG.DataSource = dataSet1.Tables[0];
                    comboG.DisplayMember = "idAlumno";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }

        void updateIDS(String SQL)
        {
            try
            {
                connection.Open();
               
                ids.Clear();
                var dataAdapD = new MySqlDataAdapter(SQL, connection);
                dataAdapD.Fill(ids);



                ID.DataSource = ids.Tables[0];
                ID.DisplayMember = "idAlumno"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Btn_accept_Click_AlumnoDel(object s, EventArgs e)
        {
            try
            {
                connection.Open();


                MySqlCommand com = connection.CreateCommand();
                com.CommandText = @"DELETE FROM `admColegio`.`Alumno` WHERE (`idAlumno` = ?ID);";
                
                com.Parameters.AddWithValue("?ID", ID.Text);

                com.ExecuteNonQuery();
                
                MessageBox.Show("Alumno Agregado Con exito");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
               /* String sql = @"Select 0 as idAlumno 
                                    union
                                    Select idAlumno from admColegio.Alumno";

                updateIDS(sql);*/
            }
        }

        private void ID_SelectedIndexChanged_update(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql = @"Select Nombres, Apellidos, Genero, FechaNacimiento from admColegio.Alumno where idAlumno = " + ID.Text;

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int i = 0;
                    textBox1.Text = reader.GetString(i++);
                    textBox2.Text = reader.GetString(i++);
                    comboG.Text = reader.GetString(i++);

                    dateEdad.Value = reader.GetDateTime(i++);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                connection.Close();
            }

        }

        private void Btn_accept_Click_AlumnoUpdate(object s, EventArgs e)
        {
            try
            {
                connection.Open();


                MySqlCommand com = connection.CreateCommand();
                com.CommandText = @"UPDATE `admColegio`.`Alumno` 
                                    SET `Nombres` = ?nombre, 
                                        `Apellidos` =  ?apellido, 
                                        `Genero` = ?g, 
                                        `FechaNacimiento` =  ?fecha 
                                    WHERE (`idAlumno` = ?ID);";

                com.Parameters.AddWithValue("?nombre", textBox1.Text);
                com.Parameters.AddWithValue("?apellido", textBox2.Text);
                com.Parameters.AddWithValue("?g", comboG.Text);
                com.Parameters.AddWithValue("?fecha", dateEdad.Value.Date.ToShortDateString());
                com.Parameters.AddWithValue("?ID", ID.Text);

                com.ExecuteNonQuery();

                

                MessageBox.Show("Alumno Agregado Con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void Btn_accept_Click_Alumno(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                MessageBox.Show("Los Campos Nombre y Apellidos son obligatorios");
            else
            {
                try
                {
                    connection.Open();


                    MySqlCommand com = connection.CreateCommand();
                    com.CommandText = @"INSERT INTO `admColegio`.`Alumno` (`Nombres`, `Apellidos`, `Genero`, `FechaNacimiento`, `FechaSistena`) 
                                        VALUES (?nombre, ?apellido, ?g, ?fecha, sysdate())";

                    com.Parameters.AddWithValue("?nombre", textBox1.Text);
                    com.Parameters.AddWithValue("?apellido", textBox2.Text);
                    com.Parameters.AddWithValue("?g", comboG.Text);
                    com.Parameters.AddWithValue("?fecha", dateEdad.Value.Date.ToShortDateString());

                    com.ExecuteNonQuery();

                    

                    MessageBox.Show("Alumno Agregado Con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        
    }
}
