namespace leosouza
{
    partial class Form4
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txttab = new System.Windows.Forms.TextBox();
            this.txtdig = new System.Windows.Forms.TextBox();
            this.lbltab = new System.Windows.Forms.Label();
            this.lbldig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(283, 298);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(127, 33);
            this.btnvoltar.TabIndex = 35;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(446, 298);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(127, 33);
            this.btnlimpar.TabIndex = 34;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(104, 298);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(127, 33);
            this.btncalcular.TabIndex = 33;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txttab
            // 
            this.txttab.Enabled = false;
            this.txttab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttab.Location = new System.Drawing.Point(252, 196);
            this.txttab.Name = "txttab";
            this.txttab.Size = new System.Drawing.Size(354, 26);
            this.txttab.TabIndex = 32;
            // 
            // txtdig
            // 
            this.txtdig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdig.Location = new System.Drawing.Point(394, 119);
            this.txtdig.Name = "txtdig";
            this.txtdig.Size = new System.Drawing.Size(310, 26);
            this.txtdig.TabIndex = 31;
            // 
            // lbltab
            // 
            this.lbltab.AutoSize = true;
            this.lbltab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab.Location = new System.Drawing.Point(106, 196);
            this.lbltab.Name = "lbltab";
            this.lbltab.Size = new System.Drawing.Size(104, 20);
            this.lbltab.TabIndex = 30;
            this.lbltab.Text = "A tabuada é :";
            // 
            // lbldig
            // 
            this.lbldig.AutoSize = true;
            this.lbldig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldig.Location = new System.Drawing.Point(97, 122);
            this.lbldig.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbldig.Name = "lbldig";
            this.lbldig.Size = new System.Drawing.Size(288, 20);
            this.lbldig.TabIndex = 29;
            this.lbldig.Text = "Digite um número para ver sua tabuada";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttab);
            this.Controls.Add(this.txtdig);
            this.Controls.Add(this.lbltab);
            this.Controls.Add(this.lbldig);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txttab;
        private System.Windows.Forms.TextBox txtdig;
        private System.Windows.Forms.Label lbltab;
        private System.Windows.Forms.Label lbldig;
    }
}