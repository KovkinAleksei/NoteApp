﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class EditForm : Form
    {
        Note _note;

        public Note Note
        {
            // Возврат заметки
            get
            {
                return _note;
            }

            // Создание заметки
            set
            {
                _note = value;

                // Заполнение названия заметки в форме
                TitleTextBox.Text = _note.Name;
                EditingTextBox.Text = _note.NoteText;
                CategoryComboBox.SelectedIndex = (int)_note.Category;
            }
        }

        /// <summary>
        /// Окно создания или редактирования заметки
        /// </summary>
        public EditForm()
        {
            InitializeComponent();

            // Добавление элементов выпадающего списка категорий заметок
            CategoryComboBox.Items.Add("Documents");
            CategoryComboBox.Items.Add("Finance");
            CategoryComboBox.Items.Add("Health and sport");
            CategoryComboBox.Items.Add("Home");
            CategoryComboBox.Items.Add("People");
            CategoryComboBox.Items.Add("Work");
            CategoryComboBox.Items.Add("Other");
        }

        /// <summary>
        /// Изменение названия записки
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Name = TitleTextBox.Text;
            }
            catch(Exception ex)
            {
                TitleTextBox.Text = TitleTextBox.Text.Remove(TitleTextBox.Text.Length - 1);
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Изменение текста заметки
        /// </summary>
        private void EditingTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.NoteText = EditingTextBox.Text;
        }

        /// <summary>
        /// Выбор категории заметки
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1)
                return;

            _note.Category = (NoteCategory)CategoryComboBox.SelectedIndex;
        }

        /// <summary>
        /// Сохранение изменений в заметке
        /// </summary>
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Отмена изменений в заметке
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
          //  _note = _oldNote;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}