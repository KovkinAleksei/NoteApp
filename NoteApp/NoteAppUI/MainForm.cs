using System;
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
    public partial class MainForm : Form
    {
        private Project _project = new Project();
        private string _path = "C:\\NoteApp.txt";
        private bool _pressedF1;
        private bool _pressedDelete;

        public MainForm()
        {
            InitializeComponent();

            // Чтение файла
            _project = ProjectManager.ReadFile(_path);

            // Сортировка заметок по времени их изменения
            _project.SortNotes();

            // Перед выделением заметки скрыть описывающие её элементы
            DisableNoteElements();

            // Добавление элементов выпадающего списка категорий заметок
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.Add("Documents");
            CategoryComboBox.Items.Add("Finance");
            CategoryComboBox.Items.Add("Health and sport");
            CategoryComboBox.Items.Add("Home");
            CategoryComboBox.Items.Add("Other");
            CategoryComboBox.Items.Add("People");
            CategoryComboBox.Items.Add("Work");
            CategoryComboBox.SelectedIndex = 0;

            // Выбор категории заметок
            CategoryComboBox.SelectedIndex = _project.CategoryIndex;

            // Выбор заметки
            if (NotesListBox.Items.Count > _project.NoteIndex)
                NotesListBox.SelectedIndex = _project.NoteIndex;

            // Добавление подсказок к кнопкам
            ToolTip removeToolTip = new ToolTip();
            removeToolTip.SetToolTip(RemoveNoteButton, "Remove note");

            ToolTip editToolTip = new ToolTip();
            editToolTip.SetToolTip(EditNoteButton, "Edit note");

            ToolTip addToolTip = new ToolTip();
            addToolTip.SetToolTip(AddNoteButton, "Add note");
        }

        /// <summary>
        /// Скрывает элементы, описывающие записку
        /// </summary>
        private void DisableNoteElements()
        {
            NameLabel.Visible = false;
            CategoryLabel.Visible = false;
            NoteCategoryLabel.Visible = false;
            CreatingTimeLabel.Visible = false;
            CreatingDateTimePicker.Visible = false;
            ModifiedTimeLabel.Visible = false;
            ModifyingDateTimePicker.Visible = false;
            NoteTextBox.Visible = false;
            EditNoteButton.Enabled = false;
            editNoteToolStripMenuItem.Enabled = false;
            RemoveNoteButton.Enabled = false;
            removeNoteToolStripMenuItem.Enabled = false;
            _project.CurrentNoteIndex = -1;
        }

        /// <summary>
        /// Создаёт новую заметку
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            // Проверка количества созданных заметок
            if (_project.Notes.Count >= 200)
            {
                MessageBox.Show("You have reached the limit of 200 created notes", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вывод формы создания заметки 
            EditForm editForm = new EditForm();
            Note newNote = new Note();
            editForm.Note = newNote;
            editForm.ShowDialog();

            // Отмена создания новой заметки
            if (editForm.DialogResult == DialogResult.Cancel)
                return;

            // Передача созданной заметки главному окну
            newNote.Name = editForm.Note.Name;
            newNote.Category = editForm.Note.Category;
            newNote.NoteText = editForm.Note.NoteText;
            newNote.CreatingTime = DateTime.Now;

            // Добавление новой заметки в список всех заметок
            NotesListBox.Items.Insert(0, newNote.Name);
            _project.Notes.Insert(0, newNote);
            NotesListBox.SetSelected(0, true);
        }

        /// <summary>
        /// Выделение заметки в списке всех заметок
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка выбранной заметки в списке заметок
            if (NotesListBox.SelectedIndex == -1)
                return;

            // Проверка выбранной категории в выпадающем списке
            if (CategoryComboBox.SelectedIndex == -1)
                return;

            // Выбор заметки из списка заметок
            Note selectedNote = new Note();

            if (CategoryComboBox.SelectedIndex == 0)
            {
                selectedNote = _project.Notes[NotesListBox.SelectedIndex];
                _project.CurrentNote = _project.Notes[NotesListBox.SelectedIndex];
            }
            else
            {
                int noteIndex = 0;

                for (int j = 0; j < _project.Notes.Count; j++)
                {
                    if (CategoryToString(_project.Notes[j].Category) == (string)CategoryComboBox.SelectedItem)
                    {
                        if (noteIndex++ == NotesListBox.SelectedIndex)
                        {
                            selectedNote = _project.Notes[j];
                            _project.CurrentNote = _project.Notes[j];
                            break;
                        }
                    }
                }
            }

            // Доступ к кнопкам редактирования и удаления заметки
            EditNoteButton.Enabled = true;
            editNoteToolStripMenuItem.Enabled = true;
            RemoveNoteButton.Enabled = true;
            removeNoteToolStripMenuItem.Enabled = true;

            // Вывод названия заметки
            NameLabel.Visible = true;
            NameLabel.Text = selectedNote.Name;

            // Вывод категории заметки
            CategoryLabel.Visible = true;
            NoteCategoryLabel.Visible = true;
            NoteCategoryLabel.Text = CategoryToString(selectedNote.Category);

            // Выставление времени создания заметки
            CreatingDateTimePicker.Visible = true;
            CreatingTimeLabel.Visible = true;
            CreatingDateTimePicker.Value = selectedNote.CreatingTime;

            // Выставление времени изменения заметки
            ModifiedTimeLabel.Visible = true;
            ModifyingDateTimePicker.Visible = true;
            ModifyingDateTimePicker.Value = selectedNote.ModifyingTime;

            // Вывод текста заметки
            NoteTextBox.Visible = true;
            NoteTextBox.Text = selectedNote.NoteText;
        }

        /// <summary>
        /// Перевод NoteCategory в строку - название категории заметки
        /// </summary>
        private string CategoryToString(NoteCategory category)
        {
            switch (category)
            {
                case NoteCategory.documents:
                    return "Documents";
                    break;

                case NoteCategory.finance:
                    return "Finance";
                    break;

                case NoteCategory.healthAndSport:
                    return "Health and sport";
                    break;

                case NoteCategory.home:
                    return "Home";
                    break;

                case NoteCategory.other:
                    return "Other";
                    break;

                case NoteCategory.people:
                    return "People";
                    break;

                case NoteCategory.work:
                    return "Work";
                    break;

                default:
                    return "Not defined";
                    break;
            }
        }

        /// <summary>
        /// Перевод string названия категории заметки в NoteCategory
        /// </summary>
        private NoteCategory StringToCategory(string category)
        {
            switch (category)
            {
                case "Documents":
                    return NoteCategory.documents;
                    break;

                case "Finance":
                    return NoteCategory.finance;
                    break;

                case "Health and sport":
                    return NoteCategory.healthAndSport;
                    break;

                case "Home":
                    return NoteCategory.home;
                    break;

                case "Other":
                    return NoteCategory.other;
                    break;

                case "People":
                    return NoteCategory.people;
                    break;

                case "Work":
                    return NoteCategory.work;
                    break;

                default:
                    return NoteCategory.other;
                    break;
            }
        }

        /// <summary>
        /// Редактирование заметки
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = NotesListBox.SelectedIndex;

            // Вывод формы редактирования заметки
            EditForm editForm = new EditForm();
            Note selectedNote = new Note();
            selectedNote = _project.CurrentNote;
            editForm.Note = selectedNote;
            editForm.ShowDialog();

            // Отмена изменений заметки
            if (editForm.DialogResult == DialogResult.Cancel)
                return;

            // Обновление заметки в главном окне
            Note editedNote = new Note();
            editedNote = editForm.Note;
            NotesListBox.Items.RemoveAt(selectedIndex);
            NotesListBox.Items.Insert(0, editedNote.Name);

            // Обновление заметок в списке всех заметок
            _project.Notes.RemoveAt(_project.CurrentNoteIndex);
            _project.Notes.Insert(0, editedNote);
            NotesListBox.SetSelected(0, true);

            // Обновление списка заметок выбранной категории
            int savedIndex = CategoryComboBox.SelectedIndex;
            CategoryComboBox.SelectedIndex = 0;
            CategoryComboBox.SelectedIndex = savedIndex;

            // Выделение выбранной заметки, если она не скрылась
            if (NameLabel.Text != null && selectedNote.Category == editedNote.Category)
                NotesListBox.SetSelected(0, true);
            else
            {
                DisableNoteElements();
                NotesListBox.SetSelected(0, false);
            }
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            // Вывод предупреждения
            DialogResult deletingResult = MessageBox.Show("Do you really want to delete this note?", "Deleting a note",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Отмена удаления заметки
            if (deletingResult == DialogResult.No)
                return;

            // Удаление заметки
            var selectedIndex = NotesListBox.SelectedIndex;
            _project.Notes.RemoveAt(_project.CurrentNoteIndex);
            NotesListBox.Items.Clear();

            // Обновление списка заметок
            for (int k = 0; k < _project.Notes.Count; k++)
                NotesListBox.Items.Add(_project.Notes[k].Name);

            // Скрыть элементы, описывающие заметку
            DisableNoteElements();
        }

        /// <summary>
        /// Выбор категории показываемых заметок
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Запоминание выбранной заметки
            Note currentNote = new Note();
            currentNote.Name = _project.CurrentNote.Name;
            currentNote.Category = _project.CurrentNote.Category;
            currentNote.NoteText = _project.CurrentNote.NoteText;
            currentNote.CreatingTime = _project.CurrentNote.CreatingTime;
            currentNote.ModifyingTime = _project.CurrentNote.ModifyingTime;

            if (currentNote.NoteText == null)
                currentNote.NoteText = "";

            // Показать все заметки
            if (CategoryComboBox.SelectedIndex == 0)
            {
                NotesListBox.Items.Clear();

                for (int k = 0; k < _project.Notes.Count; k++)
                    NotesListBox.Items.Add(_project.Notes[k].Name);

                if (_project.CurrentNoteIndex >= 0 && _project.CurrentNoteIndex < _project.Notes.Count)
                    NotesListBox.SetSelected(_project.CurrentNoteIndex, true);

                return;
            }

            // Скрыть заметки других категорий
            for (int i = 0; i < NotesListBox.Items.Count; i++)
            {
                if (CategoryToString(_project.Notes[i].Category) != (string)CategoryComboBox.SelectedItem)
                {
                    // Скрыть элементы, описывающие заметку, если она выделена
                    if (NotesListBox.SelectedIndex == i || NotesListBox.SelectedIndex == -1)
                        DisableNoteElements();

                    // Скрыть заметку
                    NotesListBox.Items.RemoveAt(i);

                    i = -1;
                }
            }

            // Показать заметки данной категории
            NotesListBox.Items.Clear();

            for (int a = 0; a < _project.Notes.Count; a++)
                if (CategoryToString(_project.Notes[a].Category) == (string)CategoryComboBox.SelectedItem)
                    NotesListBox.Items.Add(_project.Notes[a].Name);

            // Выделение выбранной заметки
            for (int b = 0; b < NotesListBox.Items.Count; b++)
            {
                Note selectedNote = new Note();
                NotesListBox.SetSelected(b, true);
                selectedNote.Name = NameLabel.Text;
                selectedNote.Category = StringToCategory(NoteCategoryLabel.Text);
                selectedNote.NoteText = NoteTextBox.Text;
                selectedNote.CreatingTime = CreatingDateTimePicker.Value;
                selectedNote.ModifyingTime = ModifyingDateTimePicker.Value;

                if (currentNote == selectedNote)
                    return;
                else
                    NotesListBox.SetSelected(b, false);
            }

            // Скрыть элементы, описывающие уже скрытую из списка заметку
            DisableNoteElements();
        }

        /// <summary>
        /// Вывод формы о программе
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Нажатие горячих клавиш
        /// </summary>
        private void Shortcut_KeyDown(object sender, KeyEventArgs e)
        {
            // Вывод окна о программе при нажатии F1
            if (e.KeyCode == Keys.F1 && !_pressedF1)
            {
                _pressedF1 = true;
                AboutForm aboutForm = new AboutForm();
                aboutForm.ShowDialog();
            }

            // Удаление заметки при нажатии Delete
            if (e.KeyCode == Keys.Delete && !_pressedDelete && RemoveNoteButton.Enabled)
            {
                // Вывод предупреждения
                DialogResult deletingResult = MessageBox.Show("Do you really want to delete this note?", "Deleting a note",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Отмена удаления заметки
                if (deletingResult == DialogResult.No)
                    return;

                // Удаление заметки
                var selectedIndex = NotesListBox.SelectedIndex;
                _project.Notes.RemoveAt(_project.CurrentNoteIndex);
                NotesListBox.Items.Clear();

                // Обновление списка заметок
                for (int k = 0; k < _project.Notes.Count; k++)
                    NotesListBox.Items.Add(_project.Notes[k].Name);

                // Обновление списка заметок выбранной категории
                int savedIndex = CategoryComboBox.SelectedIndex;
                CategoryComboBox.SelectedIndex = 0;
                CategoryComboBox.SelectedIndex = savedIndex;

                // Скрыть элементы, описывающие заметку
                DisableNoteElements();
            }
        }

        /// <summary>
        /// Прекращение нажатия клавиш
        /// </summary>
        private void Shorcut_KeyUp(object sender, KeyEventArgs e)
        {
            _pressedF1 = false;
            _pressedDelete = false;
        }

        /// <summary>
        /// Сохранение заметок в файл
        /// </summary>
        private void Save(Project project, int CategoryIndex, int ChosenNoteIndex)
        {
            project.CategoryIndex = CategoryComboBox.SelectedIndex;
            project.NoteIndex = NotesListBox.SelectedIndex;
            ProjectManager.SaveInFile(_path, project);
        }

        /// <summary>
        /// Выход из программы нажатием на кнопку Exit
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вывод пердупреждения
            DialogResult exitResult = MessageBox.Show("Do you really want to quit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Отмена выхода
            if (exitResult == DialogResult.No)
                return;

            // Сохранение
            Save(_project, CategoryComboBox.SelectedIndex, NotesListBox.SelectedIndex);

            // Выход
            Application.Exit();
        }

        /// <summary>
        /// Выход из программы закрытием формы (нажатием на крест)
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохранение
            Save(_project, CategoryComboBox.SelectedIndex, NotesListBox.SelectedIndex);
        }
    }
}
