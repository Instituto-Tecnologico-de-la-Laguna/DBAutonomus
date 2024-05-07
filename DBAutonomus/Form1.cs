using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing;

namespace DBAutonomus
{
    public partial class Form1 : Form
    {
        OracleConnection con;
        public Form1()
        {
            InitializeComponent();
            
            string cadenaConexion = "User Id=ADMIN;Password=JOSEluis1981;Data Source=jldb_high";
            OracleConfiguration.TnsAdmin = @"D:\Github\DBAutonomus\DBAutonomus\Wallet\";
            OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
            con = new OracleConnection(cadenaConexion);

            CargarAlumnos();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

            Datos obj = new Datos();
            if (obj.abrirConexion() == true)
            {
                MessageBox.Show("Exito");
            }
            else
                MessageBox.Show("Error");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // NOMRE, APATERNO, AMATERNO, CONTROL
                // TABLA ALUMNO
                //con.Open();
                con.Open();
                string insertQuery = "INSERT INTO Alumnos (NOMBRE, APATERNO, AMATERNO, CONTROL) VALUES (:nombre, :apaterno, :amaterno, :control)";
                using (OracleCommand cmd = new OracleCommand(insertQuery, con))
                {
                    cmd.Parameters.Add(new OracleParameter("nombre", textNombre.Text));
                    cmd.Parameters.Add(new OracleParameter("apaterno", textAPaterno.Text));
                    cmd.Parameters.Add(new OracleParameter("amaterno", textAMaterno.Text));
                    cmd.Parameters.Add(new OracleParameter("control", textNControl.Text));
                    int rowsInserted = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsInserted + " fila(s) insertada(s).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar alumno: " + ex.Message);
            }
            finally
            {
                con.Close();
                CargarAlumnos(); // Actualizar la tabla después de agregar un alumno
            }
        }

        private void CargarAlumnos()
        {
            tablaAlumnos.Rows.Clear();

            try
            {
                con.Open();
                string selectQuery = "SELECT * FROM Alumnos";
                using (OracleCommand cmd = new OracleCommand(selectQuery, con))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agregar una fila al DataGridView por cada registro en el resultado
                            tablaAlumnos.Rows.Add(reader["NOMBRE"], reader["APATERNO"], reader["AMATERNO"], reader["CONTROL"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al cargar los datos de los alumnos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
