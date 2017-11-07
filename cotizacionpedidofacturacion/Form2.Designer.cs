namespace cotizacionpedidofacturacion
{
    partial class Form2
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
            this.dataGridViewPredictivo1 = new dllconnectionDataBase.DataGridViewPredictivo();
            this.SuspendLayout();
            // 
            // dataGridViewPredictivo1
            // 
            this.dataGridViewPredictivo1.Location = new System.Drawing.Point(99, 63);
            this.dataGridViewPredictivo1.Name = "dataGridViewPredictivo1";
            this.dataGridViewPredictivo1.NombreCampo = null;
            this.dataGridViewPredictivo1.NombreTabla = null;
            this.dataGridViewPredictivo1.Size = new System.Drawing.Size(889, 378);
            this.dataGridViewPredictivo1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 554);
            this.Controls.Add(this.dataGridViewPredictivo1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dllconnectionDataBase.DataGridViewPredictivo dataGridViewPredictivo1;
    }
}