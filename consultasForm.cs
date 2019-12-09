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

namespace InterfazLoginMasVenta{

    public partial class consultasForm : Form{

        TextReader read;

        public consultasForm()
        {
            InitializeComponent();
            
                promedio = promedioDeventas();
                lbPorcentajeVenta.Text = $"{promedio}%";
                lbPorcentajeVenta2.Text = $"{promedio}%";
                chargeCantMayorAlPromedioDeVenta();
                lbMenorYmayorVenta.Text = menorYmMayorVenta();
                ChargeProductosConMayorPorcentaje();
            
        }


        double promedio;

        private void chargeCantMayorAlPromedioDeVenta() {
            read = new StreamReader("productos.txt");
            string textLine = read.ReadToEnd();
            read.Close();
            int indice;

            if (textLine != "") {
                string[] productos = textLine.Split('&');
                int i = 0;
                while (i<productos.Length && productos[i] != "") {
                    string[] items = productos[i].Split(';');
                    int ventas = Convert.ToInt32(items[3]);

                    if (ventas > promedio)
                    {
                        indice = dtgCantMayorPromedio.Rows.Add();
                        dtgCantMayorPromedio.Rows[indice].Cells[0].Value = items[0];
                        dtgCantMayorPromedio.Rows[indice].Cells[1].Value = items[1];
                        dtgCantMayorPromedio.Rows[indice].Cells[2].Value = items[3];
                    }
                    i++;
                }
            }
        }


        private double promedioDeventas() {
            read = new StreamReader("productos.txt");
            string textLine = read.ReadToEnd();
            read.Close();
            int indice;
            double vendidos = 0, ingresados = 0, sumaVentas = 0;
            double promedio = 0;

            if (textLine != ""){
                string[] productos = textLine.Split('&');
                int i = 0;
                while (i < productos.Length && productos[i] != "")
                {
                    string[] items = productos[i].Split(';');
                    vendidos += Convert.ToInt32(items[3]);
                    ingresados += Convert.ToInt32(items[4]);
                    i++;
                }

                if (ingresados == 0){
                    promedio = 0;
                }else{
                    promedio = Math.Round(((vendidos / ingresados) * 100));
                }
            }

            return promedio;
        }

        private string menorYmMayorVenta() {
            read = new StreamReader("productos.txt");
            string textLine, menorVent="", mayorVent=""; 
            string[] data;
            int mayor = 0, menor = 0, vendidos;

            textLine = read.ReadToEnd();
            read.Close();

            if (textLine != "")
            {
                string[] productos = textLine.Split('&');
                string[] items = productos[0].Split(';');
                mayor = menor = Convert.ToInt32(items[3]);
                    
                int i = 0;
                while (i < productos.Length && productos[i] != "")
                {
                    items = productos[i].Split(';');
                    vendidos = Convert.ToInt32(items[3]);

                    if (vendidos >= mayor)
                    {
                        mayor = vendidos;
                        mayorVent = $"\nCodigo: {items[1]} Cant: {items[3]}\n";
                    }

                    if (vendidos <= menor)
                    {
                        menor = vendidos;
                        menorVent = $"\nCodigo:{items[1]} Cant: {items[3]}";
                    }
                    i++;
                }
            }

            return $"\nMayor venta: {mayorVent}\nMenor venta:{menorVent}";
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            if (txtCodProd.Text != "")
            {
                
                string[] data;
                int encontrado = 0;

                read = new StreamReader("productos.txt");
                string textLine = read.ReadToEnd();
                read.Close();

                if (textLine != "") {
                    string[] productos = textLine.Split('&');
                    int i = 0;
                    while (i < productos.Length && productos[i] != "") {
                        string[] items = productos[i].Split(';');

                        if (items[1].ToLower().Equals(txtCodProd.Text.ToLower()))
                        {
                            encontrado++;
                            lbInfoProducto.Text = $"Producto: {items[0]}\nValor: {items[2]}\nStock: {items[5]}\nVendidos: {items[3]}";
                            break;
                        }
                        i++;
                    }

                    if (encontrado == 0)
                    {
                        MessageBox.Show("No se ha encontrado el producto en la lista");
                    }
                } 
            }
            else
            {
                MessageBox.Show("Debe ingresar un codigo de producto");
            }
        }

        private void ChargeProductosConMayorPorcentaje() {
            read = new StreamReader("productos.txt");
            string textLine = read.ReadToEnd();
            read.Close();
            if (textLine != "") {
                string[] productos = textLine.Split('&');
                int i = 0;
                while (i<productos.Length && productos[i] != "") {
                    string[] items = productos[i].Split(';');
                    double porcentaje = (Convert.ToDouble(items[3]) / Convert.ToDouble(items[4])) * 100;
                    if (porcentaje > promedio)
                    {
                        int indice = dtgProdMayProm.Rows.Add();
                        dtgProdMayProm.Rows[indice].Cells[0].Value = items[0];
                        dtgProdMayProm.Rows[indice].Cells[1].Value = items[1];
                        dtgProdMayProm.Rows[indice].Cells[2].Value = Convert.ToString(porcentaje);
                    }
                    i++;
                }

            } 
        }
    }
}

