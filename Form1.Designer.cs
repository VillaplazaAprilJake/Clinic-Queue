namespace Clinic_Queue
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            txtName = new Label();
            txtAge = new Label();
            txtReason = new Label();
            cmbPatientType = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(95, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(150, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(79, 15);
            txtName.TabIndex = 4;
            txtName.Text = "Patient Name";
            txtName.Click += label1_Click;
            // 
            // txtAge
            // 
            txtAge.AutoSize = true;
            txtAge.Location = new Point(173, 107);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(28, 15);
            txtAge.TabIndex = 5;
            txtAge.Text = "Age";
            // 
            // txtReason
            // 
            txtReason.AutoSize = true;
            txtReason.Location = new Point(150, 166);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(88, 15);
            txtReason.TabIndex = 6;
            txtReason.Text = "Reason for Visit";
            txtReason.Click += label3_Click;
            // 
            // cmbPatientType
            // 
            cmbPatientType.AutoSize = true;
            cmbPatientType.Location = new Point(150, 229);
            cmbPatientType.Name = "cmbPatientType";
            cmbPatientType.Size = new Size(72, 15);
            cmbPatientType.TabIndex = 7;
            cmbPatientType.Text = "Patient Type";
            // 
            // button1
            // 
            button1.Location = new Point(95, 331);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(189, 331);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 107);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 12;
            label3.Text = "Queue Number";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 148);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 13;
            label4.Text = "Patient Type";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 192);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 14;
            label5.Text = "Priority";
            // 
            // listBox1
            // 
            listBox1.AccessibleName = "";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(467, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(298, 139);
            listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbPatientType);
            Controls.Add(txtReason);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label txtName;
        private Label txtAge;
        private Label txtReason;
        private Label cmbPatientType;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
    }
}
