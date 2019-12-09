namespace InterfazLoginMasVenta
{
    partial class consultasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPorcentajeVenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCantMayorPromedio = new System.Windows.Forms.DataGridView();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPorcentajeVenta2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgProdMayProm = new System.Windows.Forms.DataGridView();
            this.nomProd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMenorYmayorVenta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbInfoProducto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCantMayorPromedio)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdMayProm)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lbPorcentajeVenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgCantMayorPromedio);
            this.panel1.Location = new System.Drawing.Point(18, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 228);
            this.panel1.TabIndex = 5;
            // 
            // lbPorcentajeVenta
            // 
            this.lbPorcentajeVenta.AutoSize = true;
            this.lbPorcentajeVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPorcentajeVenta.Location = new System.Drawing.Point(126, 32);
            this.lbPorcentajeVenta.Name = "lbPorcentajeVenta";
            this.lbPorcentajeVenta.Size = new System.Drawing.Size(0, 13);
            this.lbPorcentajeVenta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promedio de ventas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos con cantidad mayor al promedio de venta";
            // 
            // dtgCantMayorPromedio
            // 
            this.dtgCantMayorPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCantMayorPromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProducto,
            this.codigoProducto,
            this.cantProducto});
            this.dtgCantMayorPromedio.Location = new System.Drawing.Point(13, 51);
            this.dtgCantMayorPromedio.Name = "dtgCantMayorPromedio";
            this.dtgCantMayorPromedio.Size = new System.Drawing.Size(305, 163);
            this.dtgCantMayorPromedio.TabIndex = 0;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // codigoProducto
            // 
            this.codigoProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoProducto.HeaderText = "Codigo";
            this.codigoProducto.Name = "codigoProducto";
            // 
            // cantProducto
            // 
            this.cantProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantProducto.HeaderText = "Vendidos";
            this.cantProducto.Name = "cantProducto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lbPorcentajeVenta2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtgProdMayProm);
            this.panel2.Location = new System.Drawing.Point(428, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 228);
            this.panel2.TabIndex = 6;
            // 
            // lbPorcentajeVenta2
            // 
            this.lbPorcentajeVenta2.AutoSize = true;
            this.lbPorcentajeVenta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPorcentajeVenta2.Location = new System.Drawing.Point(127, 32);
            this.lbPorcentajeVenta2.Name = "lbPorcentajeVenta2";
            this.lbPorcentajeVenta2.Size = new System.Drawing.Size(35, 13);
            this.lbPorcentajeVenta2.TabIndex = 4;
            this.lbPorcentajeVenta2.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Promedio de ventas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Productos con promedio de venta mayor al promedio de venta total";
            // 
            // dtgProdMayProm
            // 
            this.dtgProdMayProm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdMayProm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomProd2,
            this.codProd2,
            this.porcentajeVenta});
            this.dtgProdMayProm.Location = new System.Drawing.Point(13, 51);
            this.dtgProdMayProm.Name = "dtgProdMayProm";
            this.dtgProdMayProm.Size = new System.Drawing.Size(305, 163);
            this.dtgProdMayProm.TabIndex = 0;
            // 
            // nomProd2
            // 
            this.nomProd2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomProd2.HeaderText = "Nombre";
            this.nomProd2.Name = "nomProd2";
            // 
            // codProd2
            // 
            this.codProd2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codProd2.HeaderText = "Codigo";
            this.codProd2.Name = "codProd2";
            // 
            // porcentajeVenta
            // 
            this.porcentajeVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.porcentajeVenta.HeaderText = "Porcentaje";
            this.porcentajeVenta.Name = "porcentajeVenta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.lbMenorYmayorVenta);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(428, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 152);
            this.panel3.TabIndex = 6;
            // 
            // lbMenorYmayorVenta
            // 
            this.lbMenorYmayorVenta.AutoSize = true;
            this.lbMenorYmayorVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorYmayorVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMenorYmayorVenta.Location = new System.Drawing.Point(16, 32);
            this.lbMenorYmayorVenta.Name = "lbMenorYmayorVenta";
            this.lbMenorYmayorVenta.Size = new System.Drawing.Size(0, 18);
            this.lbMenorYmayorVenta.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(13, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Productos con  mayor y menor numero de venta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.lbInfoProducto);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnBuscarProd);
            this.panel4.Controls.Add(this.txtCodProd);
            this.panel4.Location = new System.Drawing.Point(20, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 151);
            this.panel4.TabIndex = 7;
            // 
            // lbInfoProducto
            // 
            this.lbInfoProducto.AutoSize = true;
            this.lbInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInfoProducto.Location = new System.Drawing.Point(14, 62);
            this.lbInfoProducto.Name = "lbInfoProducto";
            this.lbInfoProducto.Size = new System.Drawing.Size(0, 18);
            this.lbInfoProducto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(17, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Consultar Producto";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(209, 32);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProd.TabIndex = 1;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(17, 32);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(176, 20);
            this.txtCodProd.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.label7.Size = new System.Drawing.Size(159, 40);
            this.label7.TabIndex = 9;
            this.label7.Text = "DASHBOARD";
            // 
            // consultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "consultasForm";
            this.Text = "consultasForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCantMayorPromedio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdMayProm)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCantMayorPromedio;
        private System.Windows.Forms.Label lbPorcentajeVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgProdMayProm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbMenorYmayorVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbInfoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeVenta;
        private System.Windows.Forms.Label lbPorcentajeVenta2;
        private System.Windows.Forms.Label label7;
    }
}