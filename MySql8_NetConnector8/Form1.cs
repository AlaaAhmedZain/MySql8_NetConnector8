using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql8_NetConnector8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (worldEntities ent = new worldEntities())
            {
                List<city>_l= ent.cities.ToList();              
                dataGridView1.DataSource = _l;               
            }
                
        }
    }
}
