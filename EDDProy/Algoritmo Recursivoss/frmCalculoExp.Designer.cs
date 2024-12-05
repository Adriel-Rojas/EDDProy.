namespace EDDemo.Estructuras_Lineales
{
    partial class frmCalculoExp
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtExponente = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(475, 377);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(140, 24);
            this.txtTiempo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tiempo de ejecucion";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(491, 234);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 35);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(454, 300);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(180, 41);
            this.txtResultado.TabIndex = 16;
            // 
            // txtExponente
            // 
            this.txtExponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExponente.Location = new System.Drawing.Point(475, 175);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(140, 24);
            this.txtExponente.TabIndex = 15;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(475, 117);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(140, 24);
            this.txtBase.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingrese la Potencia a Elevar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese numero a Elevar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculo de un Exponente";
            // 
            // frmCalculoExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtExponente);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculoExp";
            this.Text = "frmCalculoExp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtExponente;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}