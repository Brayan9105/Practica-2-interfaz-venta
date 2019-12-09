using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazLoginMasVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            readFile = new StreamReader("usuarios.txt");
            string usuario, password;
            string textLine = readFile.ReadToEnd();
            readFile.Close();

            usuario = txtUsuario.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();

            int countUser = 0;
            if (textLine != "") {
                string[] usuarios = textLine.Split('&');
                int i = 0;
                while (i < usuario.Length && usuarios[i] != "") {
                    string[] credenciales = usuarios[i].Split(';');
                    if (usuario.Equals(credenciales[0]) && password.Equals(credenciales[1]))
                    {
                        countUser++;
                        MessageBox.Show("Bienvenido");
                        Form2 f = new Form2(credenciales[0], credenciales[2]);
                        //ventasForm f = new ventasForm();
                        //productsForm f = new productsForm();
                        clearLogin();
                        f.Show();

                        break;
                    }
                    i++;
                }
            }
            

            if (countUser == 0) {
                MessageBox.Show("Acceso negado");
                clearLogin();
            }
            

        }

         public void clearLogin() {
            txtUsuario.Clear();
            txtPassword.Clear();
        }



        static TextReader readFile;
        

       
       
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }

    
}
