
namespace programacionejercicio
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ascendenteebutton = new System.Windows.Forms.Button();
            this.descendentebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ingresarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // ascendenteebutton
            // 
            this.ascendenteebutton.Location = new System.Drawing.Point(173, 270);
            this.ascendenteebutton.Name = "ascendenteebutton";
            this.ascendenteebutton.Size = new System.Drawing.Size(120, 48);
            this.ascendenteebutton.TabIndex = 1;
            this.ascendenteebutton.Text = "Ascendente";
            this.ascendenteebutton.UseVisualStyleBackColor = true;
            this.ascendenteebutton.Click += new System.EventHandler(this.ascendenteebutton_Click);
            // 
            // descendentebutton
            // 
            this.descendentebutton.Location = new System.Drawing.Point(306, 270);
            this.descendentebutton.Name = "descendentebutton";
            this.descendentebutton.Size = new System.Drawing.Size(120, 48);
            this.descendentebutton.TabIndex = 5;
            this.descendentebutton.Text = "Descendente";
            this.descendentebutton.UseVisualStyleBackColor = true;
            this.descendentebutton.Click += new System.EventHandler(this.descendentebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de nombres";
            // 
            // ingresarbutton
            // 
            this.ingresarbutton.Location = new System.Drawing.Point(173, 94);
            this.ingresarbutton.Name = "ingresarbutton";
            this.ingresarbutton.Size = new System.Drawing.Size(120, 75);
            this.ingresarbutton.TabIndex = 8;
            this.ingresarbutton.Text = "Ingresar Nombre y Edad";
            this.ingresarbutton.UseVisualStyleBackColor = true;
            this.ingresarbutton.Click += new System.EventHandler(this.ingresarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.ingresarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descendentebutton);
            this.Controls.Add(this.ascendenteebutton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ascendenteebutton;
        private System.Windows.Forms.Button descendentebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ingresarbutton;
    }
}

