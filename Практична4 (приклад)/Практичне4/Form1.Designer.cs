namespace Практичне4
{
    partial class frmClasses
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtProf = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            txtResult = new TextBox();
            btAdd = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProf);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(40, 38);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(338, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 151);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 5;
            label3.Text = "Професія";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 21);
            label2.TabIndex = 4;
            label2.Text = "Вік";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 3;
            label1.Text = "Ім'я";
            // 
            // txtProf
            // 
            txtProf.Location = new Point(141, 147);
            txtProf.Margin = new Padding(4);
            txtProf.Name = "txtProf";
            txtProf.Size = new Size(174, 29);
            txtProf.TabIndex = 2;
            txtProf.TextChanged += txtProf_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(141, 88);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(174, 29);
            txtAge.TabIndex = 1;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 31);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 29);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(445, 38);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(433, 277);
            txtResult.TabIndex = 1;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(40, 278);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(338, 37);
            btAdd.TabIndex = 2;
            btAdd.Text = "Додати";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // frmClasses
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 494);
            Controls.Add(btAdd);
            Controls.Add(txtResult);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmClasses";
            Text = "Перелік";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtProf;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtResult;
        private Button btAdd;
    }
}
