namespace EDDemo.Estructuras_Lineales
{
    partial class frmCircDoble
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
            this.lstLISTCircDoble = new System.Windows.Forms.ListBox();
            this.lblRESULTADO = new System.Windows.Forms.Label();
            this.btnVACIAR = new System.Windows.Forms.Button();
            this.btnQUITAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnMOSTRAR = new System.Windows.Forms.Button();
            this.txtPOSICION = new System.Windows.Forms.TextBox();
            this.txtVALOR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Listas circulares doblemente encadenadas";
            // 
            // lstLISTCircDoble
            // 
            this.lstLISTCircDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLISTCircDoble.FormattingEnabled = true;
            this.lstLISTCircDoble.ItemHeight = 20;
            this.lstLISTCircDoble.Location = new System.Drawing.Point(606, 190);
            this.lstLISTCircDoble.Name = "lstLISTCircDoble";
            this.lstLISTCircDoble.Size = new System.Drawing.Size(120, 204);
            this.lstLISTCircDoble.TabIndex = 20;
            // 
            // lblRESULTADO
            // 
            this.lblRESULTADO.AutoSize = true;
            this.lblRESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRESULTADO.Location = new System.Drawing.Point(602, 149);
            this.lblRESULTADO.Name = "lblRESULTADO";
            this.lblRESULTADO.Size = new System.Drawing.Size(118, 20);
            this.lblRESULTADO.TabIndex = 19;
            this.lblRESULTADO.Text = "Resultados...";
            // 
            // btnVACIAR
            // 
            this.btnVACIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVACIAR.Location = new System.Drawing.Point(297, 352);
            this.btnVACIAR.Name = "btnVACIAR";
            this.btnVACIAR.Size = new System.Drawing.Size(100, 31);
            this.btnVACIAR.TabIndex = 18;
            this.btnVACIAR.Text = "Vaciar";
            this.btnVACIAR.UseVisualStyleBackColor = true;
            this.btnVACIAR.Click += new System.EventHandler(this.btnVACIAR_Click);
            // 
            // btnQUITAR
            // 
            this.btnQUITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQUITAR.Location = new System.Drawing.Point(297, 304);
            this.btnQUITAR.Name = "btnQUITAR";
            this.btnQUITAR.Size = new System.Drawing.Size(100, 31);
            this.btnQUITAR.TabIndex = 17;
            this.btnQUITAR.Text = "Quitar";
            this.btnQUITAR.UseVisualStyleBackColor = true;
            this.btnQUITAR.Click += new System.EventHandler(this.btnQUITAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.Location = new System.Drawing.Point(297, 257);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(100, 31);
            this.btnAGREGAR.TabIndex = 16;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnMOSTRAR
            // 
            this.btnMOSTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMOSTRAR.Location = new System.Drawing.Point(446, 190);
            this.btnMOSTRAR.Name = "btnMOSTRAR";
            this.btnMOSTRAR.Size = new System.Drawing.Size(83, 31);
            this.btnMOSTRAR.TabIndex = 15;
            this.btnMOSTRAR.Text = "Mostrar";
            this.btnMOSTRAR.UseVisualStyleBackColor = true;
            this.btnMOSTRAR.Click += new System.EventHandler(this.btnMOSTRAR_Click);
            // 
            // txtPOSICION
            // 
            this.txtPOSICION.Location = new System.Drawing.Point(297, 199);
            this.txtPOSICION.Name = "txtPOSICION";
            this.txtPOSICION.Size = new System.Drawing.Size(100, 22);
            this.txtPOSICION.TabIndex = 14;
            // 
            // txtVALOR
            // 
            this.txtVALOR.Location = new System.Drawing.Point(297, 147);
            this.txtVALOR.Name = "txtVALOR";
            this.txtVALOR.Size = new System.Drawing.Size(100, 22);
            this.txtVALOR.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese una posicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese un valor";
            // 
            // frmCircDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstLISTCircDoble);
            this.Controls.Add(this.lblRESULTADO);
            this.Controls.Add(this.btnVACIAR);
            this.Controls.Add(this.btnQUITAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.btnMOSTRAR);
            this.Controls.Add(this.txtPOSICION);
            this.Controls.Add(this.txtVALOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCircDoble";
            this.Text = "frmCircDoble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstLISTCircDoble;
        private System.Windows.Forms.Label lblRESULTADO;
        private System.Windows.Forms.Button btnVACIAR;
        private System.Windows.Forms.Button btnQUITAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnMOSTRAR;
        private System.Windows.Forms.TextBox txtPOSICION;
        private System.Windows.Forms.TextBox txtVALOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}