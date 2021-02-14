namespace NoteAppUI
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CreatingTimeLabel = new System.Windows.Forms.Label();
            this.CreatingDataPicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedTimeLabel = new System.Windows.Forms.Label();
            this.ModifyingDataPicker = new System.Windows.Forms.DateTimePicker();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(37, 16);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(84, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(474, 20);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(12, 41);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(66, 16);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(84, 40);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(175, 21);
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.Text = "Other";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CreatingTimeLabel
            // 
            this.CreatingTimeLabel.AutoSize = true;
            this.CreatingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatingTimeLabel.Location = new System.Drawing.Point(12, 72);
            this.CreatingTimeLabel.Name = "CreatingTimeLabel";
            this.CreatingTimeLabel.Size = new System.Drawing.Size(59, 16);
            this.CreatingTimeLabel.TabIndex = 4;
            this.CreatingTimeLabel.Text = "Created:";
            // 
            // CreatingDataPicker
            // 
            this.CreatingDataPicker.Enabled = false;
            this.CreatingDataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatingDataPicker.Location = new System.Drawing.Point(84, 68);
            this.CreatingDataPicker.Name = "CreatingDataPicker";
            this.CreatingDataPicker.Size = new System.Drawing.Size(94, 20);
            this.CreatingDataPicker.TabIndex = 5;
            // 
            // ModifiedTimeLabel
            // 
            this.ModifiedTimeLabel.AutoSize = true;
            this.ModifiedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedTimeLabel.Location = new System.Drawing.Point(184, 72);
            this.ModifiedTimeLabel.Name = "ModifiedTimeLabel";
            this.ModifiedTimeLabel.Size = new System.Drawing.Size(63, 16);
            this.ModifiedTimeLabel.TabIndex = 6;
            this.ModifiedTimeLabel.Text = "Modified:";
            // 
            // ModifyingDataPicker
            // 
            this.ModifyingDataPicker.Enabled = false;
            this.ModifyingDataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifyingDataPicker.Location = new System.Drawing.Point(253, 72);
            this.ModifyingDataPicker.Name = "ModifyingDataPicker";
            this.ModifyingDataPicker.Size = new System.Drawing.Size(94, 20);
            this.ModifyingDataPicker.TabIndex = 7;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(410, 482);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(491, 482);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditingTextBox
            // 
            this.EditingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditingTextBox.Location = new System.Drawing.Point(12, 98);
            this.EditingTextBox.Multiline = true;
            this.EditingTextBox.Name = "EditingTextBox";
            this.EditingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditingTextBox.Size = new System.Drawing.Size(554, 382);
            this.EditingTextBox.TabIndex = 10;
            this.EditingTextBox.WordWrap = false;
            this.EditingTextBox.TextChanged += new System.EventHandler(this.EditingTextBox_TextChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 517);
            this.Controls.Add(this.EditingTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ModifyingDataPicker);
            this.Controls.Add(this.ModifiedTimeLabel);
            this.Controls.Add(this.CreatingDataPicker);
            this.Controls.Add(this.CreatingTimeLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.MinimumSize = new System.Drawing.Size(429, 320);
            this.Name = "EditForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CreatingTimeLabel;
        private System.Windows.Forms.DateTimePicker CreatingDataPicker;
        private System.Windows.Forms.Label ModifiedTimeLabel;
        private System.Windows.Forms.DateTimePicker ModifyingDataPicker;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox EditingTextBox;
    }
}