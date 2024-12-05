namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento
{
    partial class frmBurbuja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtOrdenar = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(119, 241);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 47);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Ordenar valores";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtOrdenar
            // 
            this.txtOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenar.Location = new System.Drawing.Point(79, 199);
            this.txtOrdenar.Name = "txtOrdenar";
            this.txtOrdenar.Size = new System.Drawing.Size(185, 27);
            this.txtOrdenar.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(382, 202);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(21, 20);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese los valores del arreglo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Separado por comas)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Metodo Burbuja";
            // 
            // frmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtOrdenar);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "frmBurbuja";
            this.Text = "Metodo Burbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtOrdenar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}