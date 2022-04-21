namespace PizzeriaOsvaldo
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnJefe = new System.Windows.Forms.Button();
            this.btnGerente = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(55, 344);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(203, 64);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "VER PEDIDOS\r\n";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnJefe
            // 
            this.btnJefe.Location = new System.Drawing.Point(277, 344);
            this.btnJefe.Name = "btnJefe";
            this.btnJefe.Size = new System.Drawing.Size(195, 64);
            this.btnJefe.TabIndex = 1;
            this.btnJefe.Text = "JEFE";
            this.btnJefe.UseVisualStyleBackColor = true;
            this.btnJefe.Click += new System.EventHandler(this.btnJefe_Click);
            // 
            // btnGerente
            // 
            this.btnGerente.Location = new System.Drawing.Point(491, 344);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(204, 64);
            this.btnGerente.TabIndex = 2;
            this.btnGerente.Text = "GERENTE";
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(49, 29);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(471, 33);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "PIZZERIA OSVALDO - SISTEMA";
            this.lbTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnGerente);
            this.Controls.Add(this.btnJefe);
            this.Controls.Add(this.btnPedidos);
            this.Name = "FrmPrincipal";
            this.Text = "Pizzeria Osvaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnJefe;
        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.Label lbTitulo;

    }
}

