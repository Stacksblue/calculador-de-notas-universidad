using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculador_de_notas_universidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggMateria1_Click(object sender, EventArgs e)
        {
            NombreMateria1.Text = tBoxNombreMateria1.Text;
            
        }

        private void btnEliminarMateria1_Click(object sender, EventArgs e)
        {
            NombreMateria1.Text = "";
            tBoxNombreMateria1.Text = "";
        }

        private void btnAggMateria2_Click(object sender, EventArgs e)
        {
            NombreMateria2.Text = tBoxNombreMateria2.Text;
        }

        private void btnEliminarMateria2_Click(object sender, EventArgs e)
        {
            NombreMateria2.Text = "";
            tBoxNombreMateria2.Text = "";
        }

        private void btnAggMateria3_Click(object sender, EventArgs e)
        {
            NombreMateria3.Text = tBoxNombreMateria3.Text;
        }

        private void btnEliminarMateria3_Click(object sender, EventArgs e)
        {
            NombreMateria3.Text = "";
            tBoxNombreMateria3.Text = "";
        }

        private void btnAggMateria4_Click(object sender, EventArgs e)
        {
            NombreMateria4.Text = tBoxNombreMateria4.Text;
        }

        private void btnEliminarMateria4_Click(object sender, EventArgs e)
        {
            NombreMateria4.Text = "";
            tBoxNombreMateria4.Text = "";
        }

        private void btnAggMateria5_Click(object sender, EventArgs e)
        {
            NombreMateria5.Text = tBoxNombreMateria5.Text;
        }

        private void btnEliminarMateria5_Click(object sender, EventArgs e)
        {
            NombreMateria5.Text = "";
            tBoxNombreMateria5.Text = "";
        }
    }
}
