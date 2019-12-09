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
    public partial class productsForm : Form
    {
        public productsForm()
        {
            InitializeComponent();
            chargeProducts();           
                
        }

        TextReader read;

        private void chargeProducts() {
            read = new StreamReader("productos.txt");
            string textLine;
            int indice;

            textLine = read.ReadToEnd();
            read.Close();

            if (textLine != "") {
                string[] productos = textLine.Split('&');
                int i = 0;
                while (i < productos.Length && productos[i] != "") {
                    string[] items = productos[i].Split(';');
                    indice = dtgProducts.Rows.Add();
                    dtgProducts.Rows[indice].Cells[0].Value = items[0];
                    dtgProducts.Rows[indice].Cells[1].Value = items[1];
                    dtgProducts.Rows[indice].Cells[2].Value = items[2];
                    dtgProducts.Rows[indice].Cells[3].Value = items[3];
                    dtgProducts.Rows[indice].Cells[4].Value = items[4];
                    dtgProducts.Rows[indice].Cells[5].Value = items[5];
                    dtgProducts.Rows[indice].Cells[6].Value = items[6];
                    i++;
                }
            }   
        }


        private void addProducts() {

            if (txtNomProduct.Text != ""  && txtValorProduct.Text != ""){
                int encontrados = 0;
                string textLine;

                read = new StreamReader("productos.txt");
                
                textLine = read.ReadToEnd();
                read.Close();

                if (textLine != "")
                {
                    string[] productos = textLine.Split('&');
                    int i = 0;
                    while (i < productos.Length && productos[i] != "")
                    {
                        string[] items = productos[i].Split(';');
                        if (items[1].ToLower().Equals(txtCodProduct.Text.ToLower()))
                        {
                            encontrados++;
                            MessageBox.Show("Se ha encontrado un codigo similar en la lista");
                            break;
                        }
                        i++;
                    }
                }
                
                if (encontrados == 0){

                    int indice = dtgProducts.Rows.Add();
                    StreamWriter archivo = File.AppendText("productos.txt");
                    dtgProducts.Rows[indice].Cells[0].Value = txtNomProduct.Text;
                    dtgProducts.Rows[indice].Cells[1].Value = txtCodProduct.Text;
                    dtgProducts.Rows[indice].Cells[2].Value = txtValorProduct.Text;
                    dtgProducts.Rows[indice].Cells[3].Value = "0";
                    dtgProducts.Rows[indice].Cells[4].Value = "0";
                    dtgProducts.Rows[indice].Cells[5].Value = "0";
                    dtgProducts.Rows[indice].Cells[6].Value = "0";

                    archivo.Write($"{txtNomProduct.Text};{txtCodProduct.Text};{txtValorProduct.Text};0;0;0;0&");
                    archivo.Close();
                    
                }
            }
            else {
                MessageBox.Show("Falta datos por llenar");
            }
            
        }

        private void Button1_Click(object sender, EventArgs e){
            addProducts();
        }

    }
}
