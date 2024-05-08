using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAutonomus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Datos obj= new Datos();
            DataSet ds = obj.all("Select * from alumnos");
            if (ds != null )
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
