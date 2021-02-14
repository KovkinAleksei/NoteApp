using System;
using System.Collections.Generic;

namespace NoteApp
{
    public class Project
    {
        private List<Note> _notes;
        private int _selectedCategoryIndex;
        private int _selectedNoteIndex;

        public Project()
        {
            _notes = new List<Note>();
            _selectedNoteIndex = -1;
            _selectedCategoryIndex = 0;
        }

        /// <summary>
        /// Возвращает список заметок
        /// </summary>
        public List<Note> Notes
        {
            get
            {
                return _notes;
            }
        }

        /// <summary>
        /// Возвращает/устанавливает индекс выбранной категоррии заметки
        /// </summary>
        public int CategoryIndex
        {
            get
            {
                return _selectedCategoryIndex;
            }

            set
            {
                _selectedCategoryIndex = value;
            }
        }

        /// <summary>
        ///  Возвращает/устанавливает индекс выбранной заметки
        /// </summary>
        public int NoteIndex
        {
            get
            {
                return _selectedNoteIndex;
            }

            set
            {
                _selectedNoteIndex = value;
            }
        }
    }
}
