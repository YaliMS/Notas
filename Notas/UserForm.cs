using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//using System.Text;

namespace Notas
{
    public partial class UserForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        public UserForm()
        {
            Font = SystemFonts.MessageBoxFont;

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

        private void mBtnVerificar_Click(object sender, EventArgs e)
        {
            byte[] user = Encoding.ASCII.GetBytes(mTxtUsuario.Text);
            byte[] pass = Encoding.ASCII.GetBytes(mTxtClave.Text);
            string qry = "SELECT count(*) FROM Usuarios WHERE Usuario = @prUser and Clave=@prPass";
            try
            {
                int count;

                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);

                // Se agrega la información de búsqueda con parámetros
                SqlCom.Parameters.Add(new SqlParameter("@prUser", user));
                SqlCom.Parameters.Add(new SqlParameter("@prpass", pass));

                // Abre la conexión y ejecutar el query
                con.Open();

                count = Convert.ToInt32(SqlCom.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show("Usuario válido", "Búsqueda Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No existe registro con ese Usuario/Clave", "Búsqueda Nota", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void mBtnSave_Click(object sender, EventArgs e)
        {
            byte[] user = Encoding.ASCII.GetBytes(mTxtUsuario.Text);
            byte[] pass = Encoding.ASCII.GetBytes(mTxtClave.Text);
            string qry = "INSERT INTO Usuarios (Usuario, Clave) VALUES (@prUsuario, @prClave)";

            try
            {
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);

                // Se agrega la información como parámetros
                SqlCom.Parameters.Add(new SqlParameter("@prUsuario", user));
                SqlCom.Parameters.Add(new SqlParameter("@prClave", pass));

                // Abrir la conexión y ejecutar el query
                con.Open();
                SqlCom.ExecuteNonQuery();

                // De no haber error, mostrar mensaje de confirmación
                MessageBox.Show("Usuario almacenado correctamente", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void mBtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
