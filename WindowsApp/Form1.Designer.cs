namespace WindowsApp
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
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnClienteIndividuo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(157, 149);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(162, 86);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnClienteIndividuo
            // 
            this.btnClienteIndividuo.Location = new System.Drawing.Point(445, 149);
            this.btnClienteIndividuo.Name = "btnClienteIndividuo";
            this.btnClienteIndividuo.Size = new System.Drawing.Size(166, 86);
            this.btnClienteIndividuo.TabIndex = 1;
            this.btnClienteIndividuo.Text = "Cliente";
            this.btnClienteIndividuo.UseVisualStyleBackColor = true;
            this.btnClienteIndividuo.Click += new System.EventHandler(this.btnClienteIndividuo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClienteIndividuo);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnClienteIndividuo;
    }
}

