namespace NoteAppUI
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.NoteAppLabel = new System.Windows.Forms.Label();
            this.VesionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.eMailLabel = new System.Windows.Forms.Label();
            this.eMailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoteAppLabel
            // 
            this.NoteAppLabel.AutoSize = true;
            this.NoteAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteAppLabel.Location = new System.Drawing.Point(12, 9);
            this.NoteAppLabel.Name = "NoteAppLabel";
            this.NoteAppLabel.Size = new System.Drawing.Size(127, 31);
            this.NoteAppLabel.TabIndex = 0;
            this.NoteAppLabel.Text = "NoteApp";
            // 
            // VesionLabel
            // 
            this.VesionLabel.AutoSize = true;
            this.VesionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VesionLabel.Location = new System.Drawing.Point(15, 49);
            this.VesionLabel.Name = "VesionLabel";
            this.VesionLabel.Size = new System.Drawing.Size(48, 16);
            this.VesionLabel.TabIndex = 1;
            this.VesionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(15, 87);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(140, 16);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author: Aleksei Kovkin";
            // 
            // eMailLabel
            // 
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailLabel.Location = new System.Drawing.Point(15, 127);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(129, 16);
            this.eMailLabel.TabIndex = 3;
            this.eMailLabel.Text = "e-mail for feedback: ";
            // 
            // eMailLinkLabel
            // 
            this.eMailLinkLabel.AutoSize = true;
            this.eMailLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailLinkLabel.Location = new System.Drawing.Point(138, 127);
            this.eMailLinkLabel.Name = "eMailLinkLabel";
            this.eMailLinkLabel.Size = new System.Drawing.Size(138, 16);
            this.eMailLinkLabel.TabIndex = 4;
            this.eMailLinkLabel.TabStop = true;
            this.eMailLinkLabel.Text = "akovkin6@gmail.com";
            this.eMailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eMailLinkLabel_LinkClicked);
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHubLabel.Location = new System.Drawing.Point(15, 143);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(52, 16);
            this.GitHubLabel.TabIndex = 5;
            this.GitHubLabel.Text = "GitHub:";
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHubLinkLabel.Location = new System.Drawing.Point(62, 143);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(151, 16);
            this.GitHubLinkLabel.TabIndex = 6;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "KovkinAleksei/NoteApp";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabe_LinkClicked);
            // 
            // YearLabel
            // 
            this.YearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.Location = new System.Drawing.Point(12, 241);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(138, 16);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "2021 Aleksei Kovkin ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 266);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.eMailLinkLabel);
            this.Controls.Add(this.eMailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VesionLabel);
            this.Controls.Add(this.NoteAppLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(414, 305);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteAppLabel;
        private System.Windows.Forms.Label VesionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label eMailLabel;
        private System.Windows.Forms.LinkLabel eMailLinkLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label YearLabel;
    }
}