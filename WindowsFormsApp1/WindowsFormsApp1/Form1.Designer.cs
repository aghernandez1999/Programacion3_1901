namespace WindowsFormsApp1
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_mostrar = new System.Windows.Forms.ComboBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tamaño = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(52, 64);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la cantidad de estudiantes que va a ingresar";
            // 
            // cbx_mostrar
            // 
            this.cbx_mostrar.FormattingEnabled = true;
            this.cbx_mostrar.Location = new System.Drawing.Point(150, 209);
            this.cbx_mostrar.Name = "cbx_mostrar";
            this.cbx_mostrar.Size = new System.Drawing.Size(251, 21);
            this.cbx_mostrar.TabIndex = 4;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(52, 193);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(89, 31);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar datos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mostrar nombre y edad en orden alfabetico";
            // 
            // btn_tamaño
            // 
            this.btn_tamaño.Location = new System.Drawing.Point(52, 114);
            this.btn_tamaño.Name = "btn_tamaño";
            this.btn_tamaño.Size = new System.Drawing.Size(89, 31);
            this.btn_tamaño.TabIndex = 7;
            this.btn_tamaño.Text = "Tamaño";
            this.btn_tamaño.UseVisualStyleBackColor = true;
            this.btn_tamaño.Click += new System.EventHandler(this.btn_tamaño_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Luego de ingresar la cantidad presione \"Tamaño\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tamaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.cbx_mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_mostrar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tamaño;
        private System.Windows.Forms.Label label2;
    }
}

