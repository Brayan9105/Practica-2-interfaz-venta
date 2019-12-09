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
    public partial class ventasForm : Form
    {
        public ventasForm()
        {
            InitializeComponent();
        }

        TextReader read;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtCodProd.Text != ""){
                string textLine;
                string[] data;
                //int encontrado = 0;

                read = new StreamReader("productos.txt");
                textLine = read.ReadToEnd();
                read.Close();
                if (textLine != "") {
                    string[] productos = textLine.Split('&');
                    int i = 0;
                    while (i < productos.Length && productos[i] != "") {
                        string[] items = productos[i].Split(';');

                        if (items[1].ToLower().Equals(txtCodProd.Text.ToLower()))
                        {
                            //encontrado++;
                            txtNomProd.Text = items[0];
                            txtStockProd.Text = items[5];
                            txtValorUniProd.Text = items[2];
                            break;
                        }
                        i++;
                    }
                }
            }else {
                MessageBox.Show("Debe ingresar un codigo de producto");
            }
        }

        private void TxtCantProd_TextChanged(object sender, EventArgs e)
        {
            if (txtCantProd.Text == "") {
                txtTotalProd.Text = "0";
            }

            if (txtCodProd.Text != "" && txtCantProd.Text != "")
            {
                txtTotalProd.Text = $"{Convert.ToInt32(txtCantProd.Text) * Convert.ToInt32(txtValorUniProd.Text)}";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtNomProd.Text != "") {
                if (Convert.ToInt32(txtCantProd.Text) <= Convert.ToInt32(txtStockProd.Text)) {
                    read = new StreamReader("productos.txt");
                    string textLine, nuevosDatos="";

                    textLine = read.ReadToEnd();
                    read.Close();
                    string[] productos = textLine.Split('&');

                    int i = 0;
                    while (i < productos.Length && productos[i] != "") {
                        string[] items = productos[i].Split(';');
                        if (items[1].ToLower().Equals(txtCodProd.Text.ToLower())) {
                            int nuevoVenta = Convert.ToInt32(items[3]) + Convert.ToInt32(txtCantProd.Text);
                            double porcentaje = (nuevoVenta / Convert.ToDouble(items[4])) * 100;
                            nuevosDatos += $"{items[0]};{items[1]};{items[2]};{nuevoVenta};{items[4]};{Convert.ToInt32(items[5]) - Convert.ToInt32(txtCantProd.Text)};{porcentaje}&";
                        }else{
                            nuevosDatos += $"{items[0]};{items[1]};{items[2]};{items[3]};{items[4]};{items[5]};{items[6]}&";
                        }
                        i++;
                    }

                    TextWriter archivo = new StreamWriter("productos.txt");
                    archivo.Write(nuevosDatos);
                    archivo.Close();
                    MessageBox.Show("Venta exitosa");
                    txtCantProd.Text = "";
                    txtCodProd.Text = "";
                    txtStockProd.Text = "";
                    txtValorUniProd.Text = "";
                    txtNomProd.Text = "";
                }
                else
                {
                    MessageBox.Show("Stock insuficiente");
                }
            }
        }
    }
}
