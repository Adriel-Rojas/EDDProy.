namespace EDDemo.Estructuras_Lineales
{
    partial class frmListaSimple
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
            this.btnVaciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstLISTAsim = new System.Windows.Forms.ListBox();
            this.btnAGfinal = new System.Windows.Forms.Button();
            this.btnAGinicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDATO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVaciar
            // 
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(321, 353);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(145, 33);
            this.btnVaciar.TabIndex = 16;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lista Simple";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(310, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Quitar Posicion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstLISTAsim
            // 
            this.lstLISTAsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLISTAsim.FormattingEnabled = true;
            this.lstLISTAsim.ItemHeight = 20;
            this.lstLISTAsim.Location = new System.Drawing.Point(525, 148);
            this.lstLISTAsim.Name = "lstLISTAsim";
            this.lstLISTAsim.Size = new System.Drawing.Size(120, 224);
            this.lstLISTAsim.TabIndex = 13;
            // 
            // btnAGfinal
            // 
            this.btnAGfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGfinal.Location = new System.Drawing.Point(321, 250);
            this.btnAGfinal.Name = "btnAGfinal";
            this.btnAGfinal.Size = new System.Drawing.Size(145, 33);
            this.btnAGfinal.TabIndex = 12;
            this.btnAGfinal.Text = "Agregar Final";
            this.btnAGfinal.UseVisualStyleBackColor = true;
            this.btnAGfinal.Click += new System.EventHandler(this.btnAGfinal_Click);
            // 
            // btnAGinicio
            // 
            this.btnAGinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGinicio.Location = new System.Drawing.Point(321, 193);
            this.btnAGinicio.Name = "btnAGinicio";
            this.btnAGinicio.Size = new System.Drawing.Size(145, 33);
            this.btnAGinicio.TabIndex = 11;
            this.btnAGinicio.Text = "Agregar Inicio";
            this.btnAGinicio.UseVisualStyleBackColor = true;
            this.btnAGinicio.Click += new System.EventHandler(this.btnAGinicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese un valor";
            // 
            // txtDATO
            // 
            this.txtDATO.Location = new System.Drawing.Point(345, 147);
            this.txtDATO.Name = "txtDATO";
            this.txtDATO.Size = new System.Drawing.Size(100, 22);
            this.txtDATO.TabIndex = 9;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstLISTAsim);
            this.Controls.Add(this.btnAGfinal);
            this.Controls.Add(this.btnAGinicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDATO);
            this.Name = "frmListaSimple";
            this.Text = "frmListaSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstLISTAsim;
        private System.Windows.Forms.Button btnAGfinal;
        private System.Windows.Forms.Button btnAGinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDATO;
    }
}