using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход по ссылке на e-mail автора
        /// </summary>
        private void eMailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                eMailLinkLabel.LinkVisited = true;
                System.Diagnostics.Process.Start("mailto:akovkin6@gmail.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        /// <summary>
        /// Переход по ссылке на GutHum автора
        /// </summary>
        private void GitHubLinkLabe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                GitHubLinkLabel.LinkVisited = true;
                System.Diagnostics.Process.Start("https://github.com/KovkinAleksei/NoteApp");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }
}
