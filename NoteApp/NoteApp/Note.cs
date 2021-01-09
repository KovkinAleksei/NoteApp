using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp
{
    /// <summary>
    /// Заметка
    /// </summary>
    public class Note : ICloneable
    {
        private string name;
        private NoteCategory category;
        private string noteText;
        private DateTime creatingTime;
        private DateTime lastChangeTime;

        /// <summary>
        /// Конструктор заметки, сохраняет время её создания и название "Без названия"
        /// </summary>
        public Note()
        {
            creatingTime = DateTime.Now;
            lastChangeTime = DateTime.Now;
            name = "Без названия";
        }

        /// <summary>
        /// Свойство названия заметки
        /// </summary>
        public string Name
        {
            // Получить название заметки
            get
            {
                return name;
            }

            // Изменить название заметки
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException ("Название должно быть не длиннее 50 символов");

                name = value;
                lastChangeTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство категории заметки
        /// </summary>
        public NoteCategory Category
        {
            // Получить категорию заметки
            get
            {
                return category;
            }

            // Изменить категорию заметки
            set
            {
                category = value;
                lastChangeTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Свойство текста заметки
        /// </summary>
        public string NoteText
        {
            // Получить текст заметки
            get
            {
                return noteText;
            }

            // Изменить текст заметки
            set
            {
                noteText = value;
                lastChangeTime = DateTime.Now;
            }
        }
    }
}
