namespace NoteDannyApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NewButton = new Button();
            SaveButton = new Button();
            ReadButton = new Button();
            DeleteButton = new Button();
            ClearButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            titleBox = new TextBox();
            noteBox = new TextBox();
            prevNotes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)prevNotes).BeginInit();
            SuspendLayout();
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.FromArgb(128, 255, 128);
            NewButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NewButton.Location = new Point(12, 466);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(102, 34);
            NewButton.TabIndex = 0;
            NewButton.Text = "New Note";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += button1_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Lime;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(294, 466);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 34);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save Note";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.BackColor = Color.DodgerBlue;
            ReadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReadButton.Location = new Point(147, 466);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(102, 34);
            ReadButton.TabIndex = 2;
            ReadButton.Text = "Read Note";
            ReadButton.UseVisualStyleBackColor = false;
            ReadButton.Click += ReadButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(589, 466);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 34);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(255, 255, 128);
            ClearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.Location = new Point(443, 466);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(102, 34);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(443, 7);
            label1.Name = "label1";
            label1.Size = new Size(146, 26);
            label1.TabIndex = 5;
            label1.Text = "Your Notes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 6;
            label2.Text = "Title :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(85, 26);
            label3.TabIndex = 7;
            label3.Text = "NOTES :";
            // 
            // titleBox
            // 
            titleBox.BackColor = SystemColors.ControlLight;
            titleBox.Location = new Point(12, 38);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(312, 27);
            titleBox.TabIndex = 8;
            titleBox.TextChanged += textBox1_TextChanged;
            // 
            // noteBox
            // 
            noteBox.BackColor = SystemColors.ControlDark;
            noteBox.Location = new Point(12, 115);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(312, 345);
            noteBox.TabIndex = 9;
            // 
            // prevNotes
            // 
            prevNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prevNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prevNotes.Location = new Point(345, 38);
            prevNotes.Name = "prevNotes";
            prevNotes.RowHeadersWidth = 51;
            prevNotes.RowTemplate.Height = 29;
            prevNotes.Size = new Size(346, 422);
            prevNotes.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(703, 512);
            Controls.Add(prevNotes);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(ReadButton);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Name = "Form1";
            Text = "NoteDannyApp";
            TransparencyKey = Color.Gray;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)prevNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewButton;
        private Button SaveButton;
        private Button ReadButton;
        private Button DeleteButton;
        private Button ClearButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox titleBox;
        private TextBox noteBox;
        private DataGridView prevNotes;
    }
}