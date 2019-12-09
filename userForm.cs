using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InterfazLoginMasVenta
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
            chargeDataGridUser();
        }

        private static TextReader read;


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private  void chargeDataGridUser() {
            read = new StreamReader("usuarios.txt");
            string textLine = read.ReadToEnd();
            read.Close();

            int indice;
            if (textLine != "") {
                string[] usuarios = textLine.Split('&');
                int i = 0;
                while (i<usuarios.Length && usuarios[i] != "") {
                    string[] datos = usuarios[i].Split(';');
                    indice = dtgUsuarios.Rows.Add();
                    dtgUsuarios.Rows[indice].Cells[0].Value = datos[0];//nombre
                    dtgUsuarios.Rows[indice].Cells[1].Value = datos[1];//password
                    dtgUsuarios.Rows[indice].Cells[2].Value = datos[2];//roll
                    i++;
                }

            }
           
        }

        private void BtnAgregarUsu_Click(object sender, EventArgs e)
        {
            if(txtNomUsu.Text != "" && txtPassUsu.Text != "" && combRollUsu.Text != "") {
                byte encontrado = 0;
                read = new StreamReader("usuarios.txt");
                string textLine = read.ReadToEnd();
                read.Close();

                if (textLine != "")
                {
                    string[] usuarios = textLine.Split('&');
                    int i = 0;
                    while (i < usuarios.Length && usuarios[i] != "")
                    {
                        string[] datos = usuarios[i].Split(';');
                        if (datos[0].ToLower().Equals(txtNomUsu.Text.ToLower()))
                        {
                            encontrado++;
                            break;
                        }
                        i++;
                    }
                }

                if (encontrado == 0)
                {
                    StreamWriter archivo = File.AppendText("usuarios.txt"); 
                    int indice = dtgUsuarios.Rows.Add();
                    dtgUsuarios.Rows[indice].Cells[0].Value = txtNomUsu.Text;//nombre
                    dtgUsuarios.Rows[indice].Cells[1].Value = txtPassUsu.Text;//password
                    dtgUsuarios.Rows[indice].Cells[2].Value = combRollUsu.SelectedItem;//roll
                    archivo.Write($"{txtNomUsu.Text};{txtPassUsu.Text};{combRollUsu.SelectedItem}&");
                    cleanAddUser();
                    archivo.Close();
                    
                }
                else
                {
                    MessageBox.Show("El usuario ya existe");
                    read.Close();
                }
                
            }else {
                MessageBox.Show("Faltan campos por completar");
            }
            
            
        }

        private void cleanAddUser() {
            txtNomUsu.Text = "";
            txtPassUsu.Text = "";
            combRollUsu.Text = "";
        }

        private void BtnResetAgrUsu_Click(object sender, EventArgs e)
        {
            cleanAddUser();
        }
    }
}
