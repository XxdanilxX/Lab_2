namespace Lab_2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            btStart1 = new Button();
            txtInformation1 = new TextBox();
            cbTypeFurniture = new ComboBox();
            tabPage2 = new TabPage();
            txtInformation2 = new TextBox();
            btStart2 = new Button();
            tabPage3 = new TabPage();
            btStart3 = new Button();
            txtInput = new TextBox();
            label1 = new Label();
            txtOutput = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 449);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Menu;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btStart1);
            tabPage1.Controls.Add(txtInformation1);
            tabPage1.Controls.Add(cbTypeFurniture);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Меблі Abstract Factory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 8);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Тип меблів";
            // 
            // btStart1
            // 
            btStart1.Location = new Point(26, 100);
            btStart1.Name = "btStart1";
            btStart1.Size = new Size(178, 61);
            btStart1.TabIndex = 3;
            btStart1.Text = "Пуск";
            btStart1.UseVisualStyleBackColor = true;
            btStart1.Click += btStart1_Click;
            // 
            // txtInformation1
            // 
            txtInformation1.Location = new Point(228, 31);
            txtInformation1.Multiline = true;
            txtInformation1.Name = "txtInformation1";
            txtInformation1.Size = new Size(537, 363);
            txtInformation1.TabIndex = 2;
            // 
            // cbTypeFurniture
            // 
            cbTypeFurniture.FormattingEnabled = true;
            cbTypeFurniture.Location = new Point(6, 31);
            cbTypeFurniture.Name = "cbTypeFurniture";
            cbTypeFurniture.Size = new Size(216, 28);
            cbTypeFurniture.TabIndex = 1;
            cbTypeFurniture.SelectedIndexChanged += cbTypeFurniture_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Menu;
            tabPage2.Controls.Add(txtInformation2);
            tabPage2.Controls.Add(btStart2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вікно Decorator ";
            // 
            // txtInformation2
            // 
            txtInformation2.Location = new Point(269, 25);
            txtInformation2.Multiline = true;
            txtInformation2.Name = "txtInformation2";
            txtInformation2.Size = new Size(512, 385);
            txtInformation2.TabIndex = 2;
            // 
            // btStart2
            // 
            btStart2.Location = new Point(43, 134);
            btStart2.Name = "btStart2";
            btStart2.Size = new Size(190, 131);
            btStart2.TabIndex = 0;
            btStart2.Text = "Start";
            btStart2.UseVisualStyleBackColor = false;
            btStart2.Click += btLib1_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Menu;
            tabPage3.Controls.Add(txtOutput);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(txtInput);
            tabPage3.Controls.Add(btStart3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 416);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Арифметичні вирази Interpreter ";
            // 
            // btStart3
            // 
            btStart3.Location = new Point(21, 92);
            btStart3.Name = "btStart3";
            btStart3.Size = new Size(188, 62);
            btStart3.TabIndex = 0;
            btStart3.Text = "Старт";
            btStart3.UseVisualStyleBackColor = true;
            btStart3.Click += btStart3_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(3, 34);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(241, 27);
            txtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Вираз:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(250, 34);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(518, 370);
            txtOutput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Лабораторна робота №2 Андросов";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        private void cbTypeFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Button btStart1;
        private TextBox txtInformation1;
        private ComboBox cbTypeFurniture;
        private TabPage tabPage2;
        private TextBox txtInformation2;
        private Button btStart2;
        private TabPage tabPage3;
        private TextBox txtOutput;
        private Label label1;
        private TextBox txtInput;
        private Button btStart3;
    }
}