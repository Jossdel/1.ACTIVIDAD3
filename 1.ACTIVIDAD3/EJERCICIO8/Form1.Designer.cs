namespace EJERCICIO8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOracion = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe una oración:";
            // 
            // txtOracion
            // 
            this.txtOracion.Location = new System.Drawing.Point(173, 160);
            this.txtOracion.Multiline = true;
            this.txtOracion.Name = "txtOracion";
            this.txtOracion.Size = new System.Drawing.Size(386, 66);
            this.txtOracion.TabIndex = 1;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(249, 252);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(237, 65);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(244, 357);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(254, 29);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Cantidad de palabras: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtOracion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOracion;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblResultado;
    }
}

