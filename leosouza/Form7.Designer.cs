namespace leosouza
{
    partial class Form7
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
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.txtf = new System.Windows.Forms.TextBox();
            this.lblf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimp
            // 
            this.btnlimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnlimp.Location = new System.Drawing.Point(583, 301);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(112, 35);
            this.btnlimp.TabIndex = 16;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnvolt.Location = new System.Drawing.Point(763, 301);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(112, 35);
            this.btnvolt.TabIndex = 15;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btncalc.Location = new System.Drawing.Point(422, 301);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(112, 35);
            this.btncalc.TabIndex = 14;
            this.btncalc.Text = "Apresentar";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // txtf
            // 
            this.txtf.Enabled = false;
            this.txtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtf.Location = new System.Drawing.Point(680, 210);
            this.txtf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(369, 30);
            this.txtf.TabIndex = 13;
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblf.Location = new System.Drawing.Point(128, 215);
            this.lblf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(544, 25);
            this.lblf.TabIndex = 12;
            this.lblf.Text = "A temperatura de Graus celsius para fahrenheit de 10 em 10: ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1177, 547);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.lblf);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Label lblf;
    }
}