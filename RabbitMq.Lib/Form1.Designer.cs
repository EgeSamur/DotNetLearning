namespace RabbitMq.Lib
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
            panel1 = new Panel();
            connectButton = new Button();
            connectTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            queueNameTextBox = new TextBox();
            label5 = new Label();
            declareButton = new Button();
            panel3 = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            rotingKeytextBox = new TextBox();
            label10 = new Label();
            bindQueuebutton = new Button();
            label6 = new Label();
            panel4 = new Panel();
            DeclareQueueTypecomboBox = new ComboBox();
            label8 = new Label();
            declarev2button = new Button();
            NameTextBox = new TextBox();
            label7 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            label14 = new Label();
            label13 = new Label();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            useCountercheckBox = new CheckBox();
            publishButton = new Button();
            ExchangeNameTypetextBox2 = new TextBox();
            routingKeyTextBox = new TextBox();
            label12 = new Label();
            label11 = new Label();
            connectionStatusLabel = new Label();
            ExchangeComboBox = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(connectButton);
            panel1.Controls.Add(connectTextBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 39);
            panel1.TabIndex = 0;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(404, 7);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 23);
            connectButton.TabIndex = 3;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // connectTextBox
            // 
            connectTextBox.Location = new Point(121, 8);
            connectTextBox.Name = "connectTextBox";
            connectTextBox.Size = new Size(268, 23);
            connectTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Connection String";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Connection";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(176, 15);
            label3.TabIndex = 4;
            label3.Text = "Queue / Exchange Declare & Bind";
            // 
            // panel2
            // 
            panel2.Controls.Add(queueNameTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(declareButton);
            panel2.Location = new Point(12, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 114);
            panel2.TabIndex = 5;
            // 
            // queueNameTextBox
            // 
            queueNameTextBox.Location = new Point(3, 44);
            queueNameTextBox.Name = "queueNameTextBox";
            queueNameTextBox.Size = new Size(222, 23);
            queueNameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 19);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 5;
            label5.Text = "Queue Name";
            // 
            // declareButton
            // 
            declareButton.Location = new Point(150, 15);
            declareButton.Name = "declareButton";
            declareButton.Size = new Size(75, 23);
            declareButton.TabIndex = 4;
            declareButton.Text = "Declare";
            declareButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(12, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 280);
            panel3.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(141, 152);
            label9.Name = "label9";
            label9.Size = new Size(126, 15);
            label9.TabIndex = 8;
            label9.Text = "Bind Queue & Exchange";
            // 
            // panel5
            // 
            panel5.Controls.Add(rotingKeytextBox);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(bindQueuebutton);
            panel5.Location = new Point(141, 170);
            panel5.Name = "panel5";
            panel5.Size = new Size(228, 96);
            panel5.TabIndex = 9;
            // 
            // rotingKeytextBox
            // 
            rotingKeytextBox.Location = new Point(3, 28);
            rotingKeytextBox.Name = "rotingKeytextBox";
            rotingKeytextBox.Size = new Size(222, 23);
            rotingKeytextBox.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 5;
            label10.Text = "Routing Key";
            // 
            // bindQueuebutton
            // 
            bindQueuebutton.Location = new Point(3, 57);
            bindQueuebutton.Name = "bindQueuebutton";
            bindQueuebutton.Size = new Size(222, 23);
            bindQueuebutton.TabIndex = 4;
            bindQueuebutton.Text = "Bind Queue";
            bindQueuebutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 4);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 6;
            label6.Text = "Declare Queue";
            // 
            // panel4
            // 
            panel4.Controls.Add(DeclareQueueTypecomboBox);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(declarev2button);
            panel4.Controls.Add(NameTextBox);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(264, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 114);
            panel4.TabIndex = 7;
            // 
            // DeclareQueueTypecomboBox
            // 
            DeclareQueueTypecomboBox.FormattingEnabled = true;
            DeclareQueueTypecomboBox.Location = new Point(59, 47);
            DeclareQueueTypecomboBox.Name = "DeclareQueueTypecomboBox";
            DeclareQueueTypecomboBox.Size = new Size(156, 23);
            DeclareQueueTypecomboBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 47);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 8;
            label8.Text = "Type";
            // 
            // declarev2button
            // 
            declarev2button.Location = new Point(140, 73);
            declarev2button.Name = "declarev2button";
            declarev2button.Size = new Size(75, 23);
            declarev2button.TabIndex = 4;
            declarev2button.Text = "Declarev2";
            declarev2button.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(59, 16);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(156, 23);
            NameTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 19);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 5;
            label7.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 4);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "Declare Queue";
            // 
            // panel6
            // 
            panel6.Controls.Add(ExchangeComboBox);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(richTextBox1);
            panel6.Controls.Add(useCountercheckBox);
            panel6.Controls.Add(publishButton);
            panel6.Controls.Add(ExchangeNameTypetextBox2);
            panel6.Controls.Add(routingKeyTextBox);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(12, 373);
            panel6.Name = "panel6";
            panel6.Size = new Size(495, 298);
            panel6.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(79, 235);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 12;
            label14.Text = "Repeat";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(79, 81);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 11;
            label13.Text = "Message";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(76, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 23);
            comboBox1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(76, 104);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(336, 132);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // useCountercheckBox
            // 
            useCountercheckBox.AutoSize = true;
            useCountercheckBox.Location = new Point(248, 256);
            useCountercheckBox.Name = "useCountercheckBox";
            useCountercheckBox.Size = new Size(91, 19);
            useCountercheckBox.TabIndex = 5;
            useCountercheckBox.Text = "Use Counter";
            useCountercheckBox.UseVisualStyleBackColor = true;
            // 
            // publishButton
            // 
            publishButton.Location = new Point(345, 252);
            publishButton.Name = "publishButton";
            publishButton.Size = new Size(75, 23);
            publishButton.TabIndex = 4;
            publishButton.Text = "Publish";
            publishButton.UseVisualStyleBackColor = true;
            // 
            // ExchangeNameTypetextBox2
            // 
            ExchangeNameTypetextBox2.Location = new Point(147, 14);
            ExchangeNameTypetextBox2.Name = "ExchangeNameTypetextBox2";
            ExchangeNameTypetextBox2.Size = new Size(100, 23);
            ExchangeNameTypetextBox2.TabIndex = 3;
            // 
            // routingKeyTextBox
            // 
            routingKeyTextBox.Location = new Point(147, 44);
            routingKeyTextBox.Name = "routingKeyTextBox";
            routingKeyTextBox.Size = new Size(220, 23);
            routingKeyTextBox.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(70, 47);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 1;
            label12.Text = "Routing Key";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 17);
            label11.Name = "label11";
            label11.Size = new Size(128, 15);
            label11.TabIndex = 0;
            label11.Text = "Exchange Name / Type";
            // 
            // connectionStatusLabel
            // 
            connectionStatusLabel.AutoSize = true;
            connectionStatusLabel.Location = new Point(12, 684);
            connectionStatusLabel.Name = "connectionStatusLabel";
            connectionStatusLabel.Size = new Size(98, 15);
            connectionStatusLabel.TabIndex = 8;
            connectionStatusLabel.Text = "Connection State";
            // 
            // ExchangeComboBox
            // 
            ExchangeComboBox.FormattingEnabled = true;
            ExchangeComboBox.Location = new Point(248, 15);
            ExchangeComboBox.Name = "ExchangeComboBox";
            ExchangeComboBox.Size = new Size(118, 23);
            ExchangeComboBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 708);
            Controls.Add(connectionStatusLabel);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button connectButton;
        private TextBox connectTextBox;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox queueNameTextBox;
        private Label label5;
        private Button declareButton;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
        private TextBox NameTextBox;
        private Label label7;
        private Button declarev2button;
        private Label label4;
        private Label label9;
        private Panel panel5;
        private TextBox rotingKeytextBox;
        private Label label10;
        private Button bindQueuebutton;
        private ComboBox DeclareQueueTypecomboBox;
        private Label label8;
        private Panel panel6;
        private RichTextBox richTextBox1;
        private CheckBox useCountercheckBox;
        private Button publishButton;
        private TextBox ExchangeNameTypetextBox2;
        private TextBox routingKeyTextBox;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;
        private ComboBox comboBox1;
        private Label connectionStatusLabel;
        private ComboBox ExchangeComboBox;
    }
}
