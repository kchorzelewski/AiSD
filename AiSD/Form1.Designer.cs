namespace AiSD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sbButton = new System.Windows.Forms.Button();
            this.ssButton = new System.Windows.Forms.Button();
            this.siButton = new System.Windows.Forms.Button();
            this.smButton = new System.Windows.Forms.Button();
            this.sqButton = new System.Windows.Forms.Button();
            this.generujButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.Color.White;
            this.inputTextBox.Location = new System.Drawing.Point(10, 9);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(110, 23);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(10, 59);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(110, 23);
            this.outputTextBox.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(210, 16);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(312, 9);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown1.TabIndex = 3;
            // 
            // sbButton
            // 
            this.sbButton.Location = new System.Drawing.Point(10, 117);
            this.sbButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbButton.Name = "sbButton";
            this.sbButton.Size = new System.Drawing.Size(82, 22);
            this.sbButton.TabIndex = 4;
            this.sbButton.Text = "SB";
            this.sbButton.UseVisualStyleBackColor = true;
            this.sbButton.Click += new System.EventHandler(this.sbButton_Click);
            // 
            // ssButton
            // 
            this.ssButton.Location = new System.Drawing.Point(98, 117);
            this.ssButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ssButton.Name = "ssButton";
            this.ssButton.Size = new System.Drawing.Size(82, 22);
            this.ssButton.TabIndex = 5;
            this.ssButton.Text = "SS";
            this.ssButton.UseVisualStyleBackColor = true;
            this.ssButton.Click += new System.EventHandler(this.ssButton_Click);
            // 
            // siButton
            // 
            this.siButton.Location = new System.Drawing.Point(186, 117);
            this.siButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siButton.Name = "siButton";
            this.siButton.Size = new System.Drawing.Size(82, 22);
            this.siButton.TabIndex = 6;
            this.siButton.Text = "SI";
            this.siButton.UseVisualStyleBackColor = true;
            this.siButton.Click += new System.EventHandler(this.siButton_Click);
            // 
            // smButton
            // 
            this.smButton.Location = new System.Drawing.Point(273, 117);
            this.smButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.smButton.Name = "smButton";
            this.smButton.Size = new System.Drawing.Size(82, 22);
            this.smButton.TabIndex = 7;
            this.smButton.Text = "SM";
            this.smButton.UseVisualStyleBackColor = true;
            this.smButton.Click += new System.EventHandler(this.smButton_Click);
            // 
            // sqButton
            // 
            this.sqButton.Location = new System.Drawing.Point(360, 117);
            this.sqButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sqButton.Name = "sqButton";
            this.sqButton.Size = new System.Drawing.Size(82, 22);
            this.sqButton.TabIndex = 8;
            this.sqButton.Text = "SQ";
            this.sqButton.UseVisualStyleBackColor = true;
            // 
            // generujButton
            // 
            this.generujButton.Location = new System.Drawing.Point(312, 44);
            this.generujButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generujButton.Name = "generujButton";
            this.generujButton.Size = new System.Drawing.Size(131, 22);
            this.generujButton.TabIndex = 9;
            this.generujButton.Text = "Generuj";
            this.generujButton.UseVisualStyleBackColor = true;
            this.generujButton.Click += new System.EventHandler(this.generujButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Czas:";
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(380, 78);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(22, 15);
            this.czas.TabIndex = 11;
            this.czas.Text = ". . .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 154);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generujButton);
            this.Controls.Add(this.sqButton);
            this.Controls.Add(this.smButton);
            this.Controls.Add(this.siButton);
            this.Controls.Add(this.ssButton);
            this.Controls.Add(this.sbButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Button sbButton;
        private Button ssButton;
        private Button siButton;
        private Button smButton;
        private Button sqButton;
        private Button generujButton;
        private Label label1;
        private Label czas;
    }
}