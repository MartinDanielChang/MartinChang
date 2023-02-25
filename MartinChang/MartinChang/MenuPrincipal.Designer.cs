
namespace MartinChang
{
    partial class MenuPrincipal
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
            this.btnFormulario1 = new System.Windows.Forms.Button();
            this.btnFormulario2 = new System.Windows.Forms.Button();
            this.btnFormulario3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormulario1
            // 
            this.btnFormulario1.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFormulario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario1.Location = new System.Drawing.Point(70, 40);
            this.btnFormulario1.Name = "btnFormulario1";
            this.btnFormulario1.Size = new System.Drawing.Size(75, 43);
            this.btnFormulario1.TabIndex = 0;
            this.btnFormulario1.Text = "Fromulario 1";
            this.btnFormulario1.UseVisualStyleBackColor = false;
            this.btnFormulario1.Click += new System.EventHandler(this.btnFormulario1_Click);
            // 
            // btnFormulario2
            // 
            this.btnFormulario2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFormulario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFormulario2.Location = new System.Drawing.Point(70, 109);
            this.btnFormulario2.Name = "btnFormulario2";
            this.btnFormulario2.Size = new System.Drawing.Size(75, 43);
            this.btnFormulario2.TabIndex = 1;
            this.btnFormulario2.Text = "Formulario 2";
            this.btnFormulario2.UseVisualStyleBackColor = false;
            this.btnFormulario2.Click += new System.EventHandler(this.btnFormulario2_Click);
            // 
            // btnFormulario3
            // 
            this.btnFormulario3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario3.Location = new System.Drawing.Point(70, 177);
            this.btnFormulario3.Name = "btnFormulario3";
            this.btnFormulario3.Size = new System.Drawing.Size(75, 39);
            this.btnFormulario3.TabIndex = 2;
            this.btnFormulario3.Text = "Formulario 3";
            this.btnFormulario3.UseVisualStyleBackColor = true;
            this.btnFormulario3.Click += new System.EventHandler(this.btnFormulario3_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(213, 253);
            this.Controls.Add(this.btnFormulario3);
            this.Controls.Add(this.btnFormulario2);
            this.Controls.Add(this.btnFormulario1);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormulario1;
        private System.Windows.Forms.Button btnFormulario2;
        private System.Windows.Forms.Button btnFormulario3;
    }
}

