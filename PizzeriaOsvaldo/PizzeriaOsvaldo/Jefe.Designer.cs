namespace PizzeriaOsvaldo
{
    partial class frmJefe
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
            this.btnSalirJefe = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.lbTituloPedidosPen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalirJefe
            // 
            this.btnSalirJefe.Location = new System.Drawing.Point(24, 321);
            this.btnSalirJefe.Name = "btnSalirJefe";
            this.btnSalirJefe.Size = new System.Drawing.Size(190, 79);
            this.btnSalirJefe.TabIndex = 9;
            this.btnSalirJefe.Text = "Salir";
            this.btnSalirJefe.UseVisualStyleBackColor = true;
            this.btnSalirJefe.Click += new System.EventHandler(this.btnSalirJefe_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(113, 140);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(258, 120);
            this.btnBalance.TabIndex = 10;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(420, 140);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(258, 120);
            this.btnStock.TabIndex = 11;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // lbTituloPedidosPen
            // 
            this.lbTituloPedidosPen.AutoSize = true;
            this.lbTituloPedidosPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPedidosPen.Location = new System.Drawing.Point(49, 29);
            this.lbTituloPedidosPen.Name = "lbTituloPedidosPen";
            this.lbTituloPedidosPen.Size = new System.Drawing.Size(413, 33);
            this.lbTituloPedidosPen.TabIndex = 12;
            this.lbTituloPedidosPen.Text = "PIZZERIA OSVALDO - JEFE";
            // 
            // frmJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.Controls.Add(this.lbTituloPedidosPen);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnSalirJefe);
            this.Name = "frmJefe";
            this.Text = "Jefe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirJefe;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lbTituloPedidosPen;
    }
}