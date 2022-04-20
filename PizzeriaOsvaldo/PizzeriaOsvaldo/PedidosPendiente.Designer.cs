namespace PizzeriaOsvaldo
{
    partial class PedidosPendiente
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
            this.lbTituloPedidosPen = new System.Windows.Forms.Label();
            this.btnSalirPedidosPen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloPedidosPen
            // 
            this.lbTituloPedidosPen.AutoSize = true;
            this.lbTituloPedidosPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPedidosPen.Location = new System.Drawing.Point(49, 29);
            this.lbTituloPedidosPen.Name = "lbTituloPedidosPen";
            this.lbTituloPedidosPen.Size = new System.Drawing.Size(678, 33);
            this.lbTituloPedidosPen.TabIndex = 4;
            this.lbTituloPedidosPen.Text = "PIZZERIA OSVALDO - PEDIDOS PENDIENTES";
            // 
            // btnSalirPedidosPen
            // 
            this.btnSalirPedidosPen.Location = new System.Drawing.Point(55, 311);
            this.btnSalirPedidosPen.Name = "btnSalirPedidosPen";
            this.btnSalirPedidosPen.Size = new System.Drawing.Size(114, 42);
            this.btnSalirPedidosPen.TabIndex = 8;
            this.btnSalirPedidosPen.Text = "Salir";
            this.btnSalirPedidosPen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 244);
            this.dataGridView1.TabIndex = 9;
            // 
            // PedidosPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalirPedidosPen);
            this.Controls.Add(this.lbTituloPedidosPen);
            this.Name = "PedidosPendiente";
            this.Text = "PedidosPendiente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloPedidosPen;
        private System.Windows.Forms.Button btnSalirPedidosPen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}