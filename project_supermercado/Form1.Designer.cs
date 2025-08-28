namespace project_supermercado
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
            this.textboxMaxing1 = new Catedra.CustomControls.TextboxMaxing();
            this.SuspendLayout();
            // 
            // textboxMaxing1
            // 
            this.textboxMaxing1.BackColor = System.Drawing.SystemColors.Window;
            this.textboxMaxing1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textboxMaxing1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textboxMaxing1.BorderSize = 2;
            this.textboxMaxing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMaxing1.ForeColor = System.Drawing.Color.DimGray;
            this.textboxMaxing1.Location = new System.Drawing.Point(113, 109);
            this.textboxMaxing1.Margin = new System.Windows.Forms.Padding(4);
            this.textboxMaxing1.Multiline = false;
            this.textboxMaxing1.Name = "textboxMaxing1";
            this.textboxMaxing1.Padding = new System.Windows.Forms.Padding(7);
            this.textboxMaxing1.PasswordChar = false;
            this.textboxMaxing1.Size = new System.Drawing.Size(250, 31);
            this.textboxMaxing1.TabIndex = 0;
            this.textboxMaxing1.Texts = "";
            this.textboxMaxing1.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxMaxing1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Catedra.CustomControls.TextboxMaxing textboxMaxing1;
    }
}

