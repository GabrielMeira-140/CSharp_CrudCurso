namespace CrudAluno.Forms
{
    partial class Nota
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
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.numUDCisco = new System.Windows.Forms.NumericUpDown();
            this.numUDLinux = new System.Windows.Forms.NumericUpDown();
            this.numUDMicrosoft = new System.Windows.Forms.NumericUpDown();
            this.numUDAdobe = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLinux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMicrosoft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAdobe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(138, 12);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(242, 20);
            this.txtNomeAluno.TabIndex = 71;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(119, 13);
            this.lblNome.TabIndex = 70;
            this.lblNome.Text = "Digite o nome do aluno:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(305, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 69;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // numUDCisco
            // 
            this.numUDCisco.Location = new System.Drawing.Point(149, 157);
            this.numUDCisco.Name = "numUDCisco";
            this.numUDCisco.Size = new System.Drawing.Size(231, 20);
            this.numUDCisco.TabIndex = 132;
            // 
            // numUDLinux
            // 
            this.numUDLinux.Location = new System.Drawing.Point(149, 188);
            this.numUDLinux.Name = "numUDLinux";
            this.numUDLinux.Size = new System.Drawing.Size(231, 20);
            this.numUDLinux.TabIndex = 131;
            // 
            // numUDMicrosoft
            // 
            this.numUDMicrosoft.Location = new System.Drawing.Point(149, 219);
            this.numUDMicrosoft.Name = "numUDMicrosoft";
            this.numUDMicrosoft.Size = new System.Drawing.Size(231, 20);
            this.numUDMicrosoft.TabIndex = 130;
            // 
            // numUDAdobe
            // 
            this.numUDAdobe.Location = new System.Drawing.Point(149, 126);
            this.numUDAdobe.Name = "numUDAdobe";
            this.numUDAdobe.Size = new System.Drawing.Size(231, 20);
            this.numUDAdobe.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 128;
            this.label7.Text = "Nota curso Cisco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Notas Microsoft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "Nota curso Linux";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "Nota curso Adobe";
            // 
            // Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.numUDCisco);
            this.Controls.Add(this.numUDLinux);
            this.Controls.Add(this.numUDMicrosoft);
            this.Controls.Add(this.numUDAdobe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "Nota";
            this.Text = "Nota";
            ((System.ComponentModel.ISupportInitialize)(this.numUDCisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLinux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMicrosoft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAdobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.NumericUpDown numUDCisco;
        private System.Windows.Forms.NumericUpDown numUDLinux;
        private System.Windows.Forms.NumericUpDown numUDMicrosoft;
        private System.Windows.Forms.NumericUpDown numUDAdobe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}