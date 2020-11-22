namespace CrudAluno.Professor
{
    partial class frmProfessor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCurso4 = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso3 = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso1 = new System.Windows.Forms.ComboBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numUDAdobe = new System.Windows.Forms.NumericUpDown();
            this.numUDMicrosoft = new System.Windows.Forms.NumericUpDown();
            this.numUDLinux = new System.Windows.Forms.NumericUpDown();
            this.numUDCisco = new System.Windows.Forms.NumericUpDown();
            this.btnNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAdobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMicrosoft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLinux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCisco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(140, 12);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(216, 20);
            this.txtNomeAluno.TabIndex = 68;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(119, 13);
            this.lblNome.TabIndex = 67;
            this.lblNome.Text = "Digite o nome do aluno:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(362, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 66;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 453);
            this.dataGridView1.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 70;
            this.button1.Text = "Exibir Alunos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(94, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 111;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 110;
            // 
            // comboBoxCurso4
            // 
            this.comboBoxCurso4.FormattingEnabled = true;
            this.comboBoxCurso4.Items.AddRange(new object[] {
            "Curso Microsoft"});
            this.comboBoxCurso4.Location = new System.Drawing.Point(224, 184);
            this.comboBoxCurso4.Name = "comboBoxCurso4";
            this.comboBoxCurso4.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCurso4.TabIndex = 109;
            // 
            // comboBoxCurso3
            // 
            this.comboBoxCurso3.FormattingEnabled = true;
            this.comboBoxCurso3.Items.AddRange(new object[] {
            "Curso Linux"});
            this.comboBoxCurso3.Location = new System.Drawing.Point(224, 157);
            this.comboBoxCurso3.Name = "comboBoxCurso3";
            this.comboBoxCurso3.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCurso3.TabIndex = 108;
            // 
            // comboBoxCurso2
            // 
            this.comboBoxCurso2.FormattingEnabled = true;
            this.comboBoxCurso2.Items.AddRange(new object[] {
            "Curso Adobe"});
            this.comboBoxCurso2.Location = new System.Drawing.Point(15, 157);
            this.comboBoxCurso2.Name = "comboBoxCurso2";
            this.comboBoxCurso2.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCurso2.TabIndex = 107;
            // 
            // comboBoxCurso1
            // 
            this.comboBoxCurso1.FormattingEnabled = true;
            this.comboBoxCurso1.Items.AddRange(new object[] {
            "Curso Cisco"});
            this.comboBoxCurso1.Location = new System.Drawing.Point(15, 184);
            this.comboBoxCurso1.Name = "comboBoxCurso1";
            this.comboBoxCurso1.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCurso1.TabIndex = 106;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(208, 86);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(67, 13);
            this.lblFinal.TabIndex = 105;
            this.lblFinal.Text = "Fim do curso";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(12, 86);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(76, 13);
            this.lblInicio.TabIndex = 104;
            this.lblInicio.Text = "Inicio do curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "curso(s) escolhdo(s) pela(o) aluna(o)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 43);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 20);
            this.txtEmail.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Nota curso Adobe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Nota curso Linux";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Notas Microsoft";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 117;
            this.label7.Text = "Nota curso Cisco";
            // 
            // numUDAdobe
            // 
            this.numUDAdobe.Location = new System.Drawing.Point(155, 293);
            this.numUDAdobe.Name = "numUDAdobe";
            this.numUDAdobe.Size = new System.Drawing.Size(120, 20);
            this.numUDAdobe.TabIndex = 121;
            // 
            // numUDMicrosoft
            // 
            this.numUDMicrosoft.Location = new System.Drawing.Point(155, 386);
            this.numUDMicrosoft.Name = "numUDMicrosoft";
            this.numUDMicrosoft.Size = new System.Drawing.Size(120, 20);
            this.numUDMicrosoft.TabIndex = 122;
            // 
            // numUDLinux
            // 
            this.numUDLinux.Location = new System.Drawing.Point(155, 355);
            this.numUDLinux.Name = "numUDLinux";
            this.numUDLinux.Size = new System.Drawing.Size(120, 20);
            this.numUDLinux.TabIndex = 123;
            // 
            // numUDCisco
            // 
            this.numUDCisco.Location = new System.Drawing.Point(155, 324);
            this.numUDCisco.Name = "numUDCisco";
            this.numUDCisco.Size = new System.Drawing.Size(120, 20);
            this.numUDCisco.TabIndex = 124;
            // 
            // btnNota
            // 
            this.btnNota.Location = new System.Drawing.Point(344, 430);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(93, 33);
            this.btnNota.TabIndex = 125;
            this.btnNota.Text = "Adicionar nota";
            this.btnNota.UseVisualStyleBackColor = true;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 533);
            this.Controls.Add(this.btnNota);
            this.Controls.Add(this.numUDCisco);
            this.Controls.Add(this.numUDLinux);
            this.Controls.Add(this.numUDMicrosoft);
            this.Controls.Add(this.numUDAdobe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxCurso4);
            this.Controls.Add(this.comboBoxCurso3);
            this.Controls.Add(this.comboBoxCurso2);
            this.Controls.Add(this.comboBoxCurso1);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmProfessor";
            this.Text = "formProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAdobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMicrosoft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLinux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxCurso4;
        private System.Windows.Forms.ComboBox comboBoxCurso3;
        private System.Windows.Forms.ComboBox comboBoxCurso2;
        private System.Windows.Forms.ComboBox comboBoxCurso1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numUDAdobe;
        private System.Windows.Forms.NumericUpDown numUDMicrosoft;
        private System.Windows.Forms.NumericUpDown numUDLinux;
        private System.Windows.Forms.NumericUpDown numUDCisco;
        private System.Windows.Forms.Button btnNota;
    }
}