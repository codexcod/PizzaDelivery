namespace PizzeriaOsvaldo
{
    partial class Balance
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
            this.btnSalirBalance = new System.Windows.Forms.Button();
            this.lbTituloPedidosPen = new System.Windows.Forms.Label();
            this.btnPerdida = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.lstIngresos = new System.Windows.Forms.ListView();
            this.lstPerdida = new System.Windows.Forms.ListView();
            this.lbIngreso = new System.Windows.Forms.Label();
            this.lbPerdida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirBalance
            // 
            this.btnSalirBalance.Location = new System.Drawing.Point(12, 321);
            this.btnSalirBalance.Name = "btnSalirBalance";
            this.btnSalirBalance.Size = new System.Drawing.Size(190, 79);
            this.btnSalirBalance.TabIndex = 10;
            this.btnSalirBalance.Text = "Salir";
            this.btnSalirBalance.UseVisualStyleBackColor = true;
            this.btnSalirBalance.Click += new System.EventHandler(this.btnSalirBalance_Click);
            // 
            // lbTituloPedidosPen
            // 
            this.lbTituloPedidosPen.AutoSize = true;
            this.lbTituloPedidosPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPedidosPen.Location = new System.Drawing.Point(18, 42);
            this.lbTituloPedidosPen.Name = "lbTituloPedidosPen";
            this.lbTituloPedidosPen.Size = new System.Drawing.Size(479, 33);
            this.lbTituloPedidosPen.TabIndex = 13;
            this.lbTituloPedidosPen.Text = "PIZZERIA OSVALDO - BALANCE";
            // 
            // btnPerdida
            // 
            this.btnPerdida.Location = new System.Drawing.Point(287, 321);
            this.btnPerdida.Name = "btnPerdida";
            this.btnPerdida.Size = new System.Drawing.Size(192, 79);
            this.btnPerdida.TabIndex = 14;
            this.btnPerdida.Text = "Agregar Egreso";
            this.btnPerdida.UseVisualStyleBackColor = true;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(564, 321);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(175, 79);
            this.btnIngreso.TabIndex = 15;
            this.btnIngreso.Text = "Agregar Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(366, 282);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(37, 13);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "Total: ";
            this.lbTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // lstIngresos
            // 
            this.lstIngresos.Location = new System.Drawing.Point(221, 102);
            this.lstIngresos.Name = "lstIngresos";
            this.lstIngresos.Size = new System.Drawing.Size(134, 154);
            this.lstIngresos.TabIndex = 17;
            this.lstIngresos.UseCompatibleStateImageBehavior = false;
            this.lstIngresos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lstPerdida
            // 
            this.lstPerdida.Location = new System.Drawing.Point(406, 102);
            this.lstPerdida.Name = "lstPerdida";
            this.lstPerdida.Size = new System.Drawing.Size(134, 154);
            this.lstPerdida.TabIndex = 18;
            this.lstPerdida.UseCompatibleStateImageBehavior = false;
            // 
            // lbIngreso
            // 
            this.lbIngreso.AutoSize = true;
            this.lbIngreso.Location = new System.Drawing.Point(218, 86);
            this.lbIngreso.Name = "lbIngreso";
            this.lbIngreso.Size = new System.Drawing.Size(47, 13);
            this.lbIngreso.TabIndex = 19;
            this.lbIngreso.Text = "Ingresos";
            // 
            // lbPerdida
            // 
            this.lbPerdida.AutoSize = true;
            this.lbPerdida.Location = new System.Drawing.Point(403, 86);
            this.lbPerdida.Name = "lbPerdida";
            this.lbPerdida.Size = new System.Drawing.Size(45, 13);
            this.lbPerdida.TabIndex = 20;
            this.lbPerdida.Text = "Egresos";
            this.lbPerdida.Click += new System.EventHandler(this.lbPerdida_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.Controls.Add(this.lbPerdida);
            this.Controls.Add(this.lbIngreso);
            this.Controls.Add(this.lstPerdida);
            this.Controls.Add(this.lstIngresos);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnPerdida);
            this.Controls.Add(this.lbTituloPedidosPen);
            this.Controls.Add(this.btnSalirBalance);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirBalance;
        private System.Windows.Forms.Label lbTituloPedidosPen;
        private System.Windows.Forms.Button btnPerdida;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label lbTotal;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ListView lstIngresos;
        private System.Windows.Forms.ListView lstPerdida;
        private System.Windows.Forms.Label lbIngreso;
        private System.Windows.Forms.Label lbPerdida;
    }
}