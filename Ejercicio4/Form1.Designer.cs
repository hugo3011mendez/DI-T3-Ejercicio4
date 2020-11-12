namespace Ejercicio4
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
            this.txtSeleccionarDir = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSeleccionarDir = new System.Windows.Forms.Button();
            this.lblSeleccionarDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeleccionarDir
            // 
            this.txtSeleccionarDir.Location = new System.Drawing.Point(193, 12);
            this.txtSeleccionarDir.Name = "txtSeleccionarDir";
            this.txtSeleccionarDir.Size = new System.Drawing.Size(568, 20);
            this.txtSeleccionarDir.TabIndex = 0;
            this.txtSeleccionarDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSeleccionarDir_KeyUp);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(193, 81);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(568, 345);
            this.txtInfo.TabIndex = 1;
            // 
            // btnSeleccionarDir
            // 
            this.btnSeleccionarDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSeleccionarDir.Location = new System.Drawing.Point(12, 48);
            this.btnSeleccionarDir.Name = "btnSeleccionarDir";
            this.btnSeleccionarDir.Size = new System.Drawing.Size(142, 80);
            this.btnSeleccionarDir.TabIndex = 2;
            this.btnSeleccionarDir.Text = "Seleccionar Directorio";
            this.btnSeleccionarDir.UseVisualStyleBackColor = true;
            this.btnSeleccionarDir.Click += new System.EventHandler(this.btnSeleccionarDir_Click);
            // 
            // lblSeleccionarDir
            // 
            this.lblSeleccionarDir.AutoSize = true;
            this.lblSeleccionarDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSeleccionarDir.Location = new System.Drawing.Point(83, 12);
            this.lblSeleccionarDir.Name = "lblSeleccionarDir";
            this.lblSeleccionarDir.Size = new System.Drawing.Size(104, 20);
            this.lblSeleccionarDir.TabIndex = 3;
            this.lblSeleccionarDir.Text = "Escribe aquí :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeleccionarDir);
            this.Controls.Add(this.btnSeleccionarDir);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtSeleccionarDir);
            this.Name = "Form1";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeleccionarDir;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnSeleccionarDir;
        private System.Windows.Forms.Label lblSeleccionarDir;
    }
}

