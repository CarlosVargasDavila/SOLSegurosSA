using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSegurosSA
{
    public partial class FrmMainSeguros : Form
    {
        LogicaNegocios.Empleado empleado = new LogicaNegocios.Empleado();
        public FrmMainSeguros()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float salNeto = empleado.calSalario(float.Parse(txtSalario.Text));
            tabla.Rows.Add(txtCedula.Text, txtNombre.Text, txtEdad.Text, rbHombre.Checked ? 'H' : 'M', txtSalario.Text);
        }
    }
}
