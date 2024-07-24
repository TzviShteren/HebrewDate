namespace HebrewDateTest
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
            label1 = new Label();
            DayComboBox = new ComboBox();
            DayMonthComboBox = new ComboBox();
            label2 = new Label();
            MonthComboBox = new ComboBox();
            label3 = new Label();
            YearComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            AddButton = new Button();
            ShowButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(894, 159);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "היום בשבוע";
            // 
            // DayComboBox
            // 
            DayComboBox.FormattingEnabled = true;
            DayComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            DayComboBox.Location = new Point(871, 227);
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(124, 33);
            DayComboBox.TabIndex = 1;
            // 
            // DayMonthComboBox
            // 
            DayMonthComboBox.FormattingEnabled = true;
            DayMonthComboBox.Location = new Point(686, 227);
            DayMonthComboBox.Name = "DayMonthComboBox";
            DayMonthComboBox.Size = new Size(124, 33);
            DayMonthComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 159);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "היום בחודש";
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "חשוון", "כסלו", "טבת", "שבט", "אדר א'", "אדר ב'", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(446, 227);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(190, 33);
            MonthComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 159);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 4;
            label3.Text = "חודש";
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            YearComboBox.Location = new Point(246, 227);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(124, 33);
            YearComboBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 159);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 6;
            label4.Text = "שנה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 40);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 8;
            label5.Text = "כתיבת תאריך";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(69, 303);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 74);
            AddButton.TabIndex = 9;
            AddButton.Text = "הוסף";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.Location = new Point(69, 186);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(112, 74);
            ShowButton.TabIndex = 10;
            ShowButton.Text = "הצג";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 627);
            Controls.Add(ShowButton);
            Controls.Add(AddButton);
            Controls.Add(label5);
            Controls.Add(YearComboBox);
            Controls.Add(label4);
            Controls.Add(MonthComboBox);
            Controls.Add(label3);
            Controls.Add(DayMonthComboBox);
            Controls.Add(label2);
            Controls.Add(DayComboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox DayComboBox;
        private ComboBox DayMonthComboBox;
        private Label label2;
        private ComboBox MonthComboBox;
        private Label label3;
        private ComboBox YearComboBox;
        private Label label4;
        private Label label5;
        private Button AddButton;
        private Button ShowButton;
    }
}
