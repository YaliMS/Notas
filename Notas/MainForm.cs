using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Notas
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;

        public MainForm()
        {
            // Usar fuente Segoe UI en Vista en adelante
            // Font = SystemFonts.MessageBoxFont;

            InitializeComponent();

            CrearConexion();
        }

        void CrearConexion()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();

            cs.DataSource = @"localhost\SQLEXPRESS";
            cs.InitialCatalog = "pruebas";
            cs.UserID = "sa";
            cs.Password = "$3M93r7!11235";

            con = new SqlConnection(cs.ConnectionString);
        }

        private void mBtnBuscarArchivo_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgImagen.ShowDialog();
            if (r == DialogResult.OK)
            {
                mTxtRuta.Text = dlgImagen.FileName;
                pictureBox3.Load(mTxtRuta.Text);
            }
        }

        private void mBtnGuardar_Click(object sender, EventArgs e)
        {
            byte[] title = Encoding.ASCII.GetBytes(mTxtTitulo.Text);
            byte[] data = System.IO.File.ReadAllBytes(mTxtRuta.Text);
            string qry = "insert into Nota (Titulo, Imagen) values (@prTitulo, @prImagen)";

            try
            {
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);

                // Se agrega la información como parámetros
                SqlCom.Parameters.Add(new SqlParameter("@prTitulo", title));
                SqlCom.Parameters.Add(new SqlParameter("@prImagen", data));

                // Abrir la conexión y ejecutar el query
                con.Open();
                SqlCom.ExecuteNonQuery();

                // De no haber error, mostrar mensaje de confirmación
                MessageBox.Show("Nota almacenada correctamente", "Guardar Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cerrar la conexión si esta se encuentra abierta
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void mBtnBuscar_Click(object sender, EventArgs e)
        {
            string qry = "select Titulo, Imagen from Nota where Id = @prId";
            try
            {
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);

                // Se agrega la información de búsqueda con parámetros
                SqlCom.Parameters.Add(new SqlParameter("@prId", numericUpDown1.Value));

                // Abre la conexión y ejecutar el query
                con.Open();
                SqlDataReader rdr = SqlCom.ExecuteReader();

                Image newImage = null;

                if (rdr.Read())
                {
                    // Obtiene los resultados de la búsqueda
                    //lblNota.Text = rdr.GetString(0);
                    byte[] titleData = (byte[])rdr.GetValue(0);
                    byte[] imgData = (byte[])rdr.GetValue(1);

                    // Trata la información de la imagen para poder trasladarla al picturebox
                    using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                    {
                        ms.Write(imgData, 0, imgData.Length);
                        newImage = Image.FromStream(ms, true);
                    }

                    pictureBox4.Image = newImage;
                    newImage = null;

                    string title = Encoding.ASCII.GetString(titleData);
                    mLblNota.Text = title;
                }
                else
                {
                    MessageBox.Show("No existe registro con ese Id", "Búsqueda Nota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Cerrar la conexión si esta se encuentra abierta
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}