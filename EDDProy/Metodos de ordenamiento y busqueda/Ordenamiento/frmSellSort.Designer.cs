namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento
{
    partial class frmSellSort
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtOrdenar = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Metodo SellSort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "(Separado por comas)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese los valores del arreglo ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(391, 201);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(21, 20);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "...";
            // 
            // txtOrdenar
            // 
            this.txtOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenar.Location = new System.Drawing.Point(88, 198);
            this.txtOrdenar.Name = "txtOrdenar";
            this.txtOrdenar.Size = new System.Drawing.Size(185, 27);
            this.txtOrdenar.TabIndex = 7;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(128, 240);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 47);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar valores";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // frmSellSort
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
            this.Name = "frmSellSort";
            this.Text = "Metodo SellSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtOrdenar;
        private System.Windows.Forms.Button btnOrdenar;
    }
}