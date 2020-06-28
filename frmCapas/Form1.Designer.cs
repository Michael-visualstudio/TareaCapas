namespace frmCapas
{
    partial class frmCapas
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNmes = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNmes = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblResultnum = new System.Windows.Forms.Label();
            this.lblResultnmes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(21, 31);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(91, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Ingrese el numero";
            // 
            // lblNmes
            // 
            this.lblNmes.AutoSize = true;
            this.lblNmes.Location = new System.Drawing.Point(21, 80);
            this.lblNmes.Name = "lblNmes";
            this.lblNmes.Size = new System.Drawing.Size(122, 13);
            this.lblNmes.TabIndex = 1;
            this.lblNmes.Text = "Ingrese un valor del mes";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(195, 28);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(110, 20);
            this.txtNum.TabIndex = 2;
            // 
            // txtNmes
            // 
            this.txtNmes.Location = new System.Drawing.Point(195, 77);
            this.txtNmes.Name = "txtNmes";
            this.txtNmes.Size = new System.Drawing.Size(110, 20);
            this.txtNmes.TabIndex = 3;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(230, 120);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblResultnum
            // 
            this.lblResultnum.AutoSize = true;
            this.lblResultnum.Location = new System.Drawing.Point(21, 159);
            this.lblResultnum.Name = "lblResultnum";
            this.lblResultnum.Size = new System.Drawing.Size(0, 13);
            this.lblResultnum.TabIndex = 5;
            // 
            // lblResultnmes
            // 
            this.lblResultnmes.AutoSize = true;
            this.lblResultnmes.Location = new System.Drawing.Point(21, 191);
            this.lblResultnmes.Name = "lblResultnmes";
            this.lblResultnmes.Size = new System.Drawing.Size(0, 13);
            this.lblResultnmes.TabIndex = 6;
            // 
            // frmCapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 220);
            this.Controls.Add(this.lblResultnmes);
            this.Controls.Add(this.lblResultnum);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtNmes);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNmes);
            this.Controls.Add(this.lblNum);
            this.Name = "frmCapas";
            this.Text = "Capas Numeros";
            this.Load += new System.EventHandler(this.frmCapas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNmes;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNmes;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblResultnum;
        private System.Windows.Forms.Label lblResultnmes;
    }
}

