namespace Session1Daniel
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.chbEstacionamento = new System.Windows.Forms.CheckBox();
            this.chbWifi = new System.Windows.Forms.CheckBox();
            this.chbCafeManha = new System.Windows.Forms.CheckBox();
            this.llblMaisProcurados = new System.Windows.Forms.LinkLabel();
            this.llblOrdemAlfabetica = new System.Windows.Forms.LinkLabel();
            this.llblMenorPreco = new System.Windows.Forms.LinkLabel();
            this.dbSession1DanielDataSet = new Session1Daniel.dbSession1DanielDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSession1DanielDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(934, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(371, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 29);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 29);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(519, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 29);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Pesquise com um endereço, bairro ou o hotel";
            this.textBox1.Enter += new System.EventHandler(this.RemoveText);
            this.textBox1.Leave += new System.EventHandler(this.AddText);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Check-out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Check-in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Continue aqui sua pesquisa :)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlPrincipal);
            this.groupBox1.Controls.Add(this.chbEstacionamento);
            this.groupBox1.Controls.Add(this.chbWifi);
            this.groupBox1.Controls.Add(this.chbCafeManha);
            this.groupBox1.Controls.Add(this.llblMaisProcurados);
            this.groupBox1.Controls.Add(this.llblOrdemAlfabetica);
            this.groupBox1.Controls.Add(this.llblMenorPreco);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 534);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.Location = new System.Drawing.Point(22, 50);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1049, 465);
            this.pnlPrincipal.TabIndex = 6;
            // 
            // chbEstacionamento
            // 
            this.chbEstacionamento.AutoSize = true;
            this.chbEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEstacionamento.Location = new System.Drawing.Point(918, 11);
            this.chbEstacionamento.Name = "chbEstacionamento";
            this.chbEstacionamento.Size = new System.Drawing.Size(164, 28);
            this.chbEstacionamento.TabIndex = 5;
            this.chbEstacionamento.Text = "Estacionamento";
            this.chbEstacionamento.UseVisualStyleBackColor = true;
            // 
            // chbWifi
            // 
            this.chbWifi.AutoSize = true;
            this.chbWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWifi.Location = new System.Drawing.Point(839, 10);
            this.chbWifi.Name = "chbWifi";
            this.chbWifi.Size = new System.Drawing.Size(65, 28);
            this.chbWifi.TabIndex = 4;
            this.chbWifi.Text = "Wi-fi";
            this.chbWifi.UseVisualStyleBackColor = true;
            // 
            // chbCafeManha
            // 
            this.chbCafeManha.AutoSize = true;
            this.chbCafeManha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCafeManha.Location = new System.Drawing.Point(668, 11);
            this.chbCafeManha.Name = "chbCafeManha";
            this.chbCafeManha.Size = new System.Drawing.Size(156, 28);
            this.chbCafeManha.TabIndex = 3;
            this.chbCafeManha.Text = "Café da manhã";
            this.chbCafeManha.UseVisualStyleBackColor = true;
            // 
            // llblMaisProcurados
            // 
            this.llblMaisProcurados.AutoSize = true;
            this.llblMaisProcurados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMaisProcurados.Location = new System.Drawing.Point(314, 11);
            this.llblMaisProcurados.Name = "llblMaisProcurados";
            this.llblMaisProcurados.Size = new System.Drawing.Size(150, 24);
            this.llblMaisProcurados.TabIndex = 2;
            this.llblMaisProcurados.TabStop = true;
            this.llblMaisProcurados.Text = "Mais procurados";
            // 
            // llblOrdemAlfabetica
            // 
            this.llblOrdemAlfabetica.AutoSize = true;
            this.llblOrdemAlfabetica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblOrdemAlfabetica.Location = new System.Drawing.Point(149, 11);
            this.llblOrdemAlfabetica.Name = "llblOrdemAlfabetica";
            this.llblOrdemAlfabetica.Size = new System.Drawing.Size(152, 24);
            this.llblOrdemAlfabetica.TabIndex = 1;
            this.llblOrdemAlfabetica.TabStop = true;
            this.llblOrdemAlfabetica.Text = "Ordem alfabética";
            // 
            // llblMenorPreco
            // 
            this.llblMenorPreco.AutoSize = true;
            this.llblMenorPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMenorPreco.Location = new System.Drawing.Point(18, 11);
            this.llblMenorPreco.Name = "llblMenorPreco";
            this.llblMenorPreco.Size = new System.Drawing.Size(119, 24);
            this.llblMenorPreco.TabIndex = 0;
            this.llblMenorPreco.TabStop = true;
            this.llblMenorPreco.Text = "Menor preço";
            // 
            // dbSession1DanielDataSet
            // 
            this.dbSession1DanielDataSet.DataSetName = "dbSession1DanielDataSet";
            this.dbSession1DanielDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1112, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSession1DanielDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbEstacionamento;
        private System.Windows.Forms.CheckBox chbWifi;
        private System.Windows.Forms.CheckBox chbCafeManha;
        private System.Windows.Forms.LinkLabel llblMaisProcurados;
        private System.Windows.Forms.LinkLabel llblOrdemAlfabetica;
        private System.Windows.Forms.LinkLabel llblMenorPreco;
        private System.Windows.Forms.Panel pnlPrincipal;
        private dbSession1DanielDataSet dbSession1DanielDataSet;
    }
}