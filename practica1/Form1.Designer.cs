namespace practica1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cboxDestino = new System.Windows.Forms.ComboBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Original";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(110, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(92, 20);
            this.txtInput.TabIndex = 1;
            // 
            // cboxDestino
            // 
            this.cboxDestino.FormattingEnabled = true;
            this.cboxDestino.Items.AddRange(new object[] {
            "cm",
            "pie",
            "pulg",
            "m",
            "mi"});
            this.cboxDestino.Location = new System.Drawing.Point(287, 30);
            this.cboxDestino.Name = "cboxDestino";
            this.cboxDestino.Size = new System.Drawing.Size(59, 21);
            this.cboxDestino.TabIndex = 2;
            this.cboxDestino.SelectedIndexChanged += new System.EventHandler(this.cbx_select_SelectedIndexChanged);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(110, 86);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(38, 23);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(164, 86);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(38, 23);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(110, 167);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(38, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(110, 128);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(38, 23);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(223, 128);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(38, 23);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(223, 86);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(38, 23);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(164, 167);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(38, 23);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(164, 128);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(38, 23);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(223, 167);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(38, 23);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(110, 209);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(38, 23);
            this.btnPunto.TabIndex = 17;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(164, 209);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(38, 23);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(287, 86);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(90, 23);
            this.btnClean.TabIndex = 19;
            this.btnClean.Text = "Limpiar Campo";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(287, 193);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(90, 39);
            this.btnProcess.TabIndex = 20;
            this.btnProcess.Text = "Convertir";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(110, 261);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(267, 20);
            this.txtResult.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Resultado:";
            // 
            // cboxOrigen
            // 
            this.cboxOrigen.FormattingEnabled = true;
            this.cboxOrigen.Items.AddRange(new object[] {
            "cm",
            "pie",
            "pulg",
            "m",
            "mi"});
            this.cboxOrigen.Location = new System.Drawing.Point(214, 30);
            this.cboxOrigen.Name = "cboxOrigen";
            this.cboxOrigen.Size = new System.Drawing.Size(57, 21);
            this.cboxOrigen.TabIndex = 23;
            this.cboxOrigen.SelectedIndexChanged += new System.EventHandler(this.cboxOrigen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Destino";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(287, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 330);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.cboxDestino);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cboxDestino;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
    }
}

