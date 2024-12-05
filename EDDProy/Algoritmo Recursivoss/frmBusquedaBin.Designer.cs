namespace EDDemo.Estructuras_Lineales
{
    partial class frmBusquedaBin
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
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(502, 378);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(182, 24);
            this.txtTiempo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tiempo de ejecucion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "(Ejemplo: 1, 2, 3, ...)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingrese el numero que desee buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Búsqueda binaria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingrese los valores";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(562, 222);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Buscar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(462, 293);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(253, 48);
            this.txtResultado.TabIndex = 13;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(502, 192);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(182, 24);
            this.txtBuscar.TabIndex = 12;
            // 
            // txtArreglo
            // 
            this.txtArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArreglo.Location = new System.Drawing.Point(502, 142);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(182, 24);
            this.txtArreglo.TabIndex = 11;
            // 
            // frmBusquedaBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtArreglo);
            this.Name = "frmBusquedaBin";
            this.Text = "Busqueda Binaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtArreglo;
    }
}