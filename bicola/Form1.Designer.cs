namespace bicola
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAddH = new System.Windows.Forms.Button();
            this.btnAddT = new System.Windows.Forms.Button();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.btnDelT = new System.Windows.Forms.Button();
            this.btnDelH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(12, 12);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(254, 20);
            this.txtDato.TabIndex = 0;
            // 
            // btnAddH
            // 
            this.btnAddH.Location = new System.Drawing.Point(12, 38);
            this.btnAddH.Name = "btnAddH";
            this.btnAddH.Size = new System.Drawing.Size(124, 23);
            this.btnAddH.TabIndex = 1;
            this.btnAddH.Text = "Agregar Frente";
            this.btnAddH.UseVisualStyleBackColor = true;
            this.btnAddH.Click += new System.EventHandler(this.btnAddH_Click);
            // 
            // btnAddT
            // 
            this.btnAddT.Location = new System.Drawing.Point(142, 38);
            this.btnAddT.Name = "btnAddT";
            this.btnAddT.Size = new System.Drawing.Size(124, 23);
            this.btnAddT.TabIndex = 2;
            this.btnAddT.Text = "Agregar Final";
            this.btnAddT.UseVisualStyleBackColor = true;
            this.btnAddT.Click += new System.EventHandler(this.btnAddT_Click);
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(12, 79);
            this.txtCola.Multiline = true;
            this.txtCola.Name = "txtCola";
            this.txtCola.ReadOnly = true;
            this.txtCola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCola.Size = new System.Drawing.Size(254, 204);
            this.txtCola.TabIndex = 3;
            // 
            // btnDelT
            // 
            this.btnDelT.Location = new System.Drawing.Point(142, 289);
            this.btnDelT.Name = "btnDelT";
            this.btnDelT.Size = new System.Drawing.Size(124, 23);
            this.btnDelT.TabIndex = 4;
            this.btnDelT.Text = "Eliminar Final";
            this.btnDelT.UseVisualStyleBackColor = true;
            this.btnDelT.Click += new System.EventHandler(this.btnDelT_Click);
            // 
            // btnDelH
            // 
            this.btnDelH.Location = new System.Drawing.Point(12, 289);
            this.btnDelH.Name = "btnDelH";
            this.btnDelH.Size = new System.Drawing.Size(124, 23);
            this.btnDelH.TabIndex = 5;
            this.btnDelH.Text = "Eliminar Frente";
            this.btnDelH.UseVisualStyleBackColor = true;
            this.btnDelH.Click += new System.EventHandler(this.btnDelH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 320);
            this.Controls.Add(this.btnDelH);
            this.Controls.Add(this.btnDelT);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.btnAddT);
            this.Controls.Add(this.btnAddH);
            this.Controls.Add(this.txtDato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAddH;
        private System.Windows.Forms.Button btnAddT;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnDelT;
        private System.Windows.Forms.Button btnDelH;
    }
}

