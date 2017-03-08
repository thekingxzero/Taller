namespace Taller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResultadoCalculadora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero2Calculadora = new System.Windows.Forms.TextBox();
            this.comboOperacionCalculadora = new System.Windows.Forms.ComboBox();
            this.txtNumero1Calculadora = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNumeroConversor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultadoConversor = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelResultadoCalculadora);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNumero2Calculadora);
            this.tabPage1.Controls.Add(this.comboOperacionCalculadora);
            this.tabPage1.Controls.Add(this.txtNumero1Calculadora);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculadora";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A";
            // 
            // labelResultadoCalculadora
            // 
            this.labelResultadoCalculadora.AutoSize = true;
            this.labelResultadoCalculadora.Location = new System.Drawing.Point(405, 60);
            this.labelResultadoCalculadora.Name = "labelResultadoCalculadora";
            this.labelResultadoCalculadora.Size = new System.Drawing.Size(0, 13);
            this.labelResultadoCalculadora.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // txtNumero2Calculadora
            // 
            this.txtNumero2Calculadora.Location = new System.Drawing.Point(259, 59);
            this.txtNumero2Calculadora.Name = "txtNumero2Calculadora";
            this.txtNumero2Calculadora.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2Calculadora.TabIndex = 2;
            this.txtNumero2Calculadora.TextChanged += new System.EventHandler(this.txtNumero2Calculadora_TextChanged);
            this.txtNumero2Calculadora.MouseLeave += new System.EventHandler(this.txtNumero2Calculadora_MouseLeave);
            // 
            // comboOperacionCalculadora
            // 
            this.comboOperacionCalculadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperacionCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboOperacionCalculadora.FormattingEnabled = true;
            this.comboOperacionCalculadora.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.comboOperacionCalculadora.Location = new System.Drawing.Point(122, 59);
            this.comboOperacionCalculadora.Name = "comboOperacionCalculadora";
            this.comboOperacionCalculadora.Size = new System.Drawing.Size(121, 21);
            this.comboOperacionCalculadora.TabIndex = 0;
            this.comboOperacionCalculadora.TextUpdate += new System.EventHandler(this.comboOperacionCalculadora_TextUpdate);
            this.comboOperacionCalculadora.DropDownClosed += new System.EventHandler(this.comboOperacionCalculadora_DropDownClosed);
            this.comboOperacionCalculadora.Click += new System.EventHandler(this.comboOperacionCalculadora_Click);
            this.comboOperacionCalculadora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboOperacionCalculadora_MouseClick);
            // 
            // txtNumero1Calculadora
            // 
            this.txtNumero1Calculadora.Location = new System.Drawing.Point(6, 60);
            this.txtNumero1Calculadora.Name = "txtNumero1Calculadora";
            this.txtNumero1Calculadora.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1Calculadora.TabIndex = 0;
            this.txtNumero1Calculadora.TextChanged += new System.EventHandler(this.txtNumero1Calculadora_TextChanged);
            this.txtNumero1Calculadora.MouseLeave += new System.EventHandler(this.txtNumero1Calculadora_MouseLeave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblResultadoConversor);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtNumeroConversor);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Convertidor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Resultado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Binario A Decimal",
            "Binario A Hexadecimal",
            "Decimal A Binario",
            "Decimal A Hexadecimal",
            "Hexadecimal A Binario",
            "Hexadecimal A Decimal"});
            this.comboBox1.Location = new System.Drawing.Point(135, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // txtNumeroConversor
            // 
            this.txtNumeroConversor.Location = new System.Drawing.Point(17, 51);
            this.txtNumeroConversor.Name = "txtNumeroConversor";
            this.txtNumeroConversor.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroConversor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tipo de Conversion";
            // 
            // lblResultadoConversor
            // 
            this.lblResultadoConversor.AutoSize = true;
            this.lblResultadoConversor.Location = new System.Drawing.Point(307, 58);
            this.lblResultadoConversor.Name = "lblResultadoConversor";
            this.lblResultadoConversor.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoConversor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Taller N° 1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelResultadoCalculadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero2Calculadora;
        private System.Windows.Forms.ComboBox comboOperacionCalculadora;
        private System.Windows.Forms.TextBox txtNumero1Calculadora;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultadoConversor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroConversor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

