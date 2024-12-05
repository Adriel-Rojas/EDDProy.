namespace EDDemo.Estructuras_Lineales
{
    partial class frmSumarArreglo
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tiempo de ejecucion";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(500, 374);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(173, 24);
            this.txtTiempo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "(Ejemplo 1, 2, 3, ...)";
            // 
            // txtArreglo
            // 
            this.txtArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArreglo.Location = new System.Drawing.Point(500, 162);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(173, 24);
            this.txtArreglo.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(532, 215);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(491, 280);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(191, 60);
            this.txtResultado.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese numeros como arreglo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sumar los elementos de un arreglo";
            // 
            // frmSumarArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArreglo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSumarArreglo";
            this.Text = "frmSumarArreglo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}