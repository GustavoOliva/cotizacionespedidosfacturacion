namespace cotizacionpedidofacturacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.navegador1 = new Navegador.Navegador();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idProducto = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPredictivo1 = new dllconnectionDataBase.DataGridViewPredictivo();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(30, 27);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.nombreBD = null;
            this.navegador1.nombreTabla = null;
            this.navegador1.pass = null;
            this.navegador1.servidor = null;
            this.navegador1.Size = new System.Drawing.Size(684, 58);
            this.navegador1.TabIndex = 3;
            this.navegador1.usuario = null;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(482, 202);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(221, 22);
            this.total.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "ID Producto";
            // 
            // idProducto
            // 
            this.idProducto.Location = new System.Drawing.Point(140, 119);
            this.idProducto.Name = "idProducto";
            this.idProducto.Size = new System.Drawing.Size(220, 22);
            this.idProducto.TabIndex = 32;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(140, 202);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(220, 22);
            this.precio.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Precio";
            // 
            // idVendedor
            // 
            this.idVendedor.Location = new System.Drawing.Point(482, 156);
            this.idVendedor.Name = "idVendedor";
            this.idVendedor.Size = new System.Drawing.Size(221, 22);
            this.idVendedor.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID Vendedor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(482, 119);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(221, 22);
            this.fecha.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha:";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(140, 159);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(220, 22);
            this.cantidad.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cantidad";
            // 
            // dataGridViewPredictivo1
            // 
            this.dataGridViewPredictivo1.Location = new System.Drawing.Point(53, 314);
            this.dataGridViewPredictivo1.Name = "dataGridViewPredictivo1";
            this.dataGridViewPredictivo1.NombreCampo = "idCotizacion";
            this.dataGridViewPredictivo1.NombreTabla = "cotizaciones";
            this.dataGridViewPredictivo1.Size = new System.Drawing.Size(894, 383);
            this.dataGridViewPredictivo1.TabIndex = 2;
            this.dataGridViewPredictivo1.Load += new System.EventHandler(this.dataGridViewPredictivo1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 709);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idProducto);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridViewPredictivo1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private dllconnectionDataBase.DataGridViewPredictivo dataGridViewPredictivo1;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idProducto;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label1;
    }
}

