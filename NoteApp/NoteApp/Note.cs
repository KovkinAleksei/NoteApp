using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp
{
    /// <summary>
    /// Заметка
    /// </summary>
    public class Note
    {
        private string _name;
        private NoteCategory _category;
        private string _noteText;
        private DateTime _creatingTime;
        private DateTime _modifyingTime;

        /// <summary>
        /// Сохраняет время создания заметки и название "Без названия"
        /// </summary>
        public Note()
        {
            _creatingTime = DateTime.Now;
            _modifyingTime = DateTime.Now;
            _name = "Без названия";
            _category = NoteCategory.other;
        }

        /// <summary>
        /// Возвращает или задаёт название заметки
        /// </summary>
        public string Name
        {
            // Возвращает название заметки
            get
            {
                return _name;
            }

            // Задаёт название заметки
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("The title can't be longer than 50 symbols");

                _name = value;
                _modifyingTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задаёт категорию заметки
        /// </summary>
        public NoteCategory Category
        {
            // Возвращает категорию заметки
            get
            {
                return _category;
            }

            // Задаёт категорию заметки
            set
            {
                _category = value;
                _modifyingTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задаёт текст записки
        /// </summary>
        public string NoteText
        {
            // Возвращает текст записки
            get
            {
                return _noteText;
            }

            // Задаёт текст записки
            set
            {
                _noteText = value;
                _modifyingTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задаёт время создания записки
        /// </summary>
        public DateTime CreatingTime
        {
            get
            {
                return _creatingTime;
            }

            set
            {
                _creatingTime = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт время изменения записки
        /// </summary>
        public DateTime ModifyingTime
        {
            get
            {
                return _modifyingTime;
            }

            set
            {
                _modifyingTime = value;
            }
        }

        /// <summary>
        /// Сравнение заметок
        /// </summary>
        public static bool operator ==(Note firstNote, Note secondNote)
        {
            if (firstNote.Name == secondNote.Name && firstNote.Category == secondNote.Category &&
                firstNote.CreatingTime.Date == secondNote.CreatingTime.Date &&
                firstNote.ModifyingTime.Date == secondNote.ModifyingTime.Date &&
                firstNote.NoteText == secondNote.NoteText)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Сравнение заметок
        /// </summary>
        public static bool operator !=(Note firstNote, Note secondNote)
        {
            if (firstNote.Name == secondNote.Name && firstNote.Category == secondNote.Category &&
               firstNote.CreatingTime.Date == secondNote.CreatingTime.Date &&
               firstNote.ModifyingTime.Date == secondNote.ModifyingTime.Date &&
               firstNote.NoteText == secondNote.NoteText)
                return false;
            else
                return true;
        }
    }
}
