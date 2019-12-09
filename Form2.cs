using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazLoginMasVenta
{
    public partial class Form2 : Form
    {
        public Form2(string user, string roll)
        {
            InitializeComponent();
            openChildForm(new consultasForm());
            lbUserName.Text = $"Bienvenido {user}";

            if (!roll.Equals("Admin"))
            {
                btnProductos.Hide();
                btnUsuarios.Hide();
                btnVentas.Hide();
                btnIngresos.Hide();
            }
        }

    public static userForm usersForm;
        public static object Control { get; internal set; }


        Form currentForm = null;
        private void openChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new userForm());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            
            openChildForm(new productsForm());
        }

        private void BtnSalirMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new consultasForm());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new ventasForm());
        }

        private void BtnIngresos_Click(object sender, EventArgs e)
        {
            openChildForm(new ingresosForm());
        }
    }
}
