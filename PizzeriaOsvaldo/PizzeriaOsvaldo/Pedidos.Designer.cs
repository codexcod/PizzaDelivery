namespace PizzeriaOsvaldo
{
    partial class frmPedidos
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
            this.lbTituloPedidos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPedidosPendientes = new System.Windows.Forms.Button();
            this.btnVerPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloPedidos
            // 
            this.lbTituloPedidos.AutoSize = true;
            this.lbTituloPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbTituloPedidos.Location = new System.Drawing.Point(49, 29);
            this.lbTituloPedidos.Name = "lbTituloPedidos";
            this.lbTituloPedidos.Size = new System.Drawing.Size(475, 33);
            this.lbTituloPedidos.TabIndex = 0;
            this.lbTituloPedidos.Text = "PIZZERIA OSVALDO - PEDIDOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(521, 311);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 48);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnPedidosPendientes
            // 
            this.btnPedidosPendientes.Location = new System.Drawing.Point(22, 95);
            this.btnPedidosPendientes.Name = "btnPedidosPendientes";
            this.btnPedidosPendientes.Size = new System.Drawing.Size(132, 50);
            this.btnPedidosPendientes.TabIndex = 3;
            this.btnPedidosPendientes.Text = "Pedidos Pendientes";
            this.btnPedidosPendientes.UseVisualStyleBackColor = true;
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(22, 173);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(132, 48);
            this.btnVerPedido.TabIndex = 4;
            this.btnVerPedido.Text = "Ver Pedido";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.Controls.Add(this.btnVerPedido);
            this.Controls.Add(this.btnPedidosPendientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbTituloPedidos);
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloPedidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPedidosPendientes;
        private System.Windows.Forms.Button btnVerPedido;
    }
}