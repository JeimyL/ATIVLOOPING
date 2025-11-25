namespace leosouza
{
    partial class Form8
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
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtlimpar = new System.Windows.Forms.Button();
            this.txtareat = new System.Windows.Forms.TextBox();
            this.lblareatot = new System.Windows.Forms.Label();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.lblcomp = new System.Windows.Forms.Label();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.lbllarg = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtarea
            // 
            this.txtarea.Enabled = false;
            this.txtarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtarea.Location = new System.Drawing.Point(588, 225);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(219, 30);
            this.txtarea.TabIndex = 23;
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblarea.Location = new System.Drawing.Point(327, 229);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(214, 26);
            this.lblarea.TabIndex = 22;
            this.lblarea.Text = "A area do comodo é:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnvoltar.Location = new System.Drawing.Point(824, 388);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(145, 50);
            this.btnvoltar.TabIndex = 21;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtlimpar
            // 
            this.txtlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtlimpar.Location = new System.Drawing.Point(578, 388);
            this.txtlimpar.Name = "txtlimpar";
            this.txtlimpar.Size = new System.Drawing.Size(145, 50);
            this.txtlimpar.TabIndex = 20;
            this.txtlimpar.Text = "Limpar";
            this.txtlimpar.UseVisualStyleBackColor = true;
            this.txtlimpar.Click += new System.EventHandler(this.txtlimpar_Click);
            // 
            // txtareat
            // 
            this.txtareat.Enabled = false;
            this.txtareat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtareat.Location = new System.Drawing.Point(588, 296);
            this.txtareat.Name = "txtareat";
            this.txtareat.Size = new System.Drawing.Size(219, 30);
            this.txtareat.TabIndex = 19;
            // 
            // lblareatot
            // 
            this.lblareatot.AutoSize = true;
            this.lblareatot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblareatot.Location = new System.Drawing.Point(276, 299);
            this.lblareatot.Name = "lblareatot";
            this.lblareatot.Size = new System.Drawing.Size(288, 26);
            this.lblareatot.TabIndex = 18;
            this.lblareatot.Text = "A area total da residência é: ";
            // 
            // txtcomp
            // 
            this.txtcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtcomp.Location = new System.Drawing.Point(588, 152);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(219, 30);
            this.txtcomp.TabIndex = 17;
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblcomp.Location = new System.Drawing.Point(237, 155);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(345, 26);
            this.lblcomp.TabIndex = 16;
            this.lblcomp.Text = "Digite o comprimento do cômodo: ";
            // 
            // txtlarg
            // 
            this.txtlarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtlarg.Location = new System.Drawing.Point(588, 110);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(219, 30);
            this.txtlarg.TabIndex = 15;
            // 
            // lbllarg
            // 
            this.lbllarg.AutoSize = true;
            this.lbllarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbllarg.Location = new System.Drawing.Point(256, 110);
            this.lbllarg.Name = "lbllarg";
            this.lbllarg.Size = new System.Drawing.Size(285, 26);
            this.lbllarg.TabIndex = 14;
            this.lbllarg.Text = "Digite a largura do cômodo: ";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btncalcular.Location = new System.Drawing.Point(347, 388);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(145, 50);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1206, 548);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtlimpar);
            this.Controls.Add(this.txtareat);
            this.Controls.Add(this.lblareatot);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.lbllarg);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button txtlimpar;
        private System.Windows.Forms.TextBox txtareat;
        private System.Windows.Forms.Label lblareatot;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.Label lbllarg;
        private System.Windows.Forms.Button btncalcular;
    }
}