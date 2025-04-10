namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            kilkistsportBox = new TextBox();
            bronzaBox = new TextBox();
            crainaBox = new TextBox();
            zolotoBox = new TextBox();
            sribloBox = new TextBox();
            addButton = new Button();
            resultBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sribloBox);
            groupBox1.Controls.Add(zolotoBox);
            groupBox1.Controls.Add(crainaBox);
            groupBox1.Controls.Add(bronzaBox);
            groupBox1.Controls.Add(kilkistsportBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 37);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(467, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Країна:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(172, 21);
            label2.TabIndex = 1;
            label2.Text = "Кількість спортсменів: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 204);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 2;
            label3.Text = "Срібні медалі:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 147);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 3;
            label4.Text = "Золоті медалі:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 251);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 4;
            label5.Text = "Бронзові медалі:";
            // 
            // kilkistsportBox
            // 
            kilkistsportBox.Location = new Point(258, 94);
            kilkistsportBox.Name = "kilkistsportBox";
            kilkistsportBox.Size = new Size(185, 29);
            kilkistsportBox.TabIndex = 5;
            // 
            // bronzaBox
            // 
            bronzaBox.Location = new Point(258, 248);
            bronzaBox.Name = "bronzaBox";
            bronzaBox.Size = new Size(185, 29);
            bronzaBox.TabIndex = 6;
            // 
            // crainaBox
            // 
            crainaBox.Location = new Point(258, 47);
            crainaBox.Name = "crainaBox";
            crainaBox.Size = new Size(185, 29);
            crainaBox.TabIndex = 7;
            crainaBox.TextChanged += textBox3_TextChanged;
            // 
            // zolotoBox
            // 
            zolotoBox.Location = new Point(258, 144);
            zolotoBox.Name = "zolotoBox";
            zolotoBox.Size = new Size(185, 29);
            zolotoBox.TabIndex = 8;
            // 
            // sribloBox
            // 
            sribloBox.Location = new Point(258, 201);
            sribloBox.Name = "sribloBox";
            sribloBox.Size = new Size(185, 29);
            sribloBox.TabIndex = 9;
            // 
            // addButton
            // 
            addButton.Location = new Point(43, 380);
            addButton.Name = "addButton";
            addButton.Size = new Size(467, 44);
            addButton.TabIndex = 1;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(547, 48);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(436, 300);
            resultBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(resultBox);
            Controls.Add(addButton);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Перелік";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox sribloBox;
        private TextBox zolotoBox;
        private TextBox crainaBox;
        private TextBox bronzaBox;
        private TextBox kilkistsportBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button addButton;
        private TextBox resultBox;
    }
}
