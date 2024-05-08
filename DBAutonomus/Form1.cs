namespace DBAutonomus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
           
            Datos obj= new Datos();
            bool r = obj.cmd("Insert Into Alumnos(control,nombre,apaterno,amaterno) " + 
                "Values('" + txtControl.Text + "','"+ txtNombre .Text + "','" +
                txtPaterno.Text + "','" + txtMaterno .Text + "')");

            if (r== true)
            {
                MessageBox.Show("Informacion agregada","Sistema",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error","Sistema",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        
    }
}
