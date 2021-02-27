namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ModifyingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedTimeLabel = new System.Windows.Forms.Label();
            this.CreatingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatingTimeLabel = new System.Windows.Forms.Label();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1002, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "Menu";
            this.MainMenuStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.MainMenuStrip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.NoteTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ModifyingDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatingDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreatingTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteCategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 586);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.splitContainer1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 16;
            this.NotesListBox.Location = new System.Drawing.Point(6, 43);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(271, 484);
            this.NotesListBox.TabIndex = 4;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            this.NotesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.NotesListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.BackgroundImage")));
            this.RemoveNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveNoteButton.Location = new System.Drawing.Point(69, 554);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(27, 24);
            this.RemoveNoteButton.TabIndex = 0;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            this.RemoveNoteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.RemoveNoteButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.BackgroundImage")));
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.Location = new System.Drawing.Point(36, 554);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(27, 24);
            this.EditNoteButton.TabIndex = 3;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            this.EditNoteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.EditNoteButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.BackgroundImage")));
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNoteButton.Location = new System.Drawing.Point(6, 554);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(27, 24);
            this.AddNoteButton.TabIndex = 2;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            this.AddNoteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.AddNoteButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCategoryLabel.Location = new System.Drawing.Point(3, 11);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(102, 16);
            this.ShowCategoryLabel.TabIndex = 1;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(111, 10);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(166, 21);
            this.CategoryComboBox.TabIndex = 0;
            this.CategoryComboBox.Text = "All";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.CategoryComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.NameLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(703, 59);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(90, 31);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTextBox.HideSelection = false;
            this.NoteTextBox.Location = new System.Drawing.Point(9, 110);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(697, 464);
            this.NoteTextBox.TabIndex = 8;
            this.NoteTextBox.WordWrap = false;
            this.NoteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.NoteTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            // 
            // ModifyingDateTimePicker
            // 
            this.ModifyingDateTimePicker.Enabled = false;
            this.ModifyingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifyingDateTimePicker.Location = new System.Drawing.Point(238, 87);
            this.ModifyingDateTimePicker.Name = "ModifyingDateTimePicker";
            this.ModifyingDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.ModifyingDateTimePicker.TabIndex = 7;
            // 
            // ModifiedTimeLabel
            // 
            this.ModifiedTimeLabel.AutoSize = true;
            this.ModifiedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedTimeLabel.Location = new System.Drawing.Point(169, 91);
            this.ModifiedTimeLabel.Name = "ModifiedTimeLabel";
            this.ModifiedTimeLabel.Size = new System.Drawing.Size(63, 16);
            this.ModifiedTimeLabel.TabIndex = 6;
            this.ModifiedTimeLabel.Text = "Modified:";
            // 
            // CreatingDateTimePicker
            // 
            this.CreatingDateTimePicker.Enabled = false;
            this.CreatingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatingDateTimePicker.Location = new System.Drawing.Point(71, 87);
            this.CreatingDateTimePicker.Name = "CreatingDateTimePicker";
            this.CreatingDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.CreatingDateTimePicker.TabIndex = 5;
            // 
            // CreatingTimeLabel
            // 
            this.CreatingTimeLabel.AutoSize = true;
            this.CreatingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatingTimeLabel.Location = new System.Drawing.Point(9, 91);
            this.CreatingTimeLabel.Name = "CreatingTimeLabel";
            this.CreatingTimeLabel.Size = new System.Drawing.Size(59, 16);
            this.CreatingTimeLabel.TabIndex = 4;
            this.CreatingTimeLabel.Text = "Created:";
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteCategoryLabel.Location = new System.Drawing.Point(68, 65);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(72, 16);
            this.NoteCategoryLabel.TabIndex = 3;
            this.NoteCategoryLabel.Text = "Something";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(6, 65);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(66, 16);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 31);
            this.TitleLabel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 610);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1018, 649);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1_KeyUp);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NoteCategoryLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.DateTimePicker ModifyingDateTimePicker;
        private System.Windows.Forms.Label ModifiedTimeLabel;
        private System.Windows.Forms.DateTimePicker CreatingDateTimePicker;
        private System.Windows.Forms.Label CreatingTimeLabel;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

