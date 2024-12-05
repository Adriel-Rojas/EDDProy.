namespace EDDemo.Estructuras_Lineales
{
    partial class frmSecuenciaFib
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(467, 191);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(143, 135);
            this.txtResultado.TabIndex = 17;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(455, 402);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(164, 24);
            this.txtTiempo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tiempo de ejecucion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado de Secuencia";
            // 
            // txtIndice
            // 
            this.txtIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndice.Location = new System.Drawing.Point(455, 67);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(164, 24);
            this.txtIndice.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(455, 122);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(164, 31);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Generar Secuencia";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese un numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Secuencia de Fibonacci";
            // 
            // frmSecuenciaFib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSecuenciaFib";
            this.Text = "frmSecuenciaFib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}