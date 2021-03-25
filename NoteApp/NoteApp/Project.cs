using System;
using System.Collections.Generic;

namespace NoteApp
{
    public class Project
    {
        private List<Note> _notes;
        private int _selectedCategoryIndex;
        private int _selectedNoteIndex;
        private Note _currentNote;
        private int _currentNoteIndex;

        public Project()
        {
            _notes = new List<Note>();
            _selectedNoteIndex = -1;
            _selectedCategoryIndex = 0;
            _currentNote = new Note();
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
        /// Возвращает или задаёт выбранную в данный момент заметку
        /// </summary>
        public Note CurrentNote
        {
            get
            {
                return _currentNote;
            }

            set
            {
                _currentNote.Name = value.Name;
                _currentNote.Category = value.Category;
                _currentNote.NoteText = value.NoteText;
                _currentNote.CreatingTime = value.CreatingTime;
                _currentNote.ModifyingTime = value.ModifyingTime;

                for (int i = 0; i < _notes.Count; i++)
                    if (_notes[i] == _currentNote)
                        _currentNoteIndex = i;
            }
        }

        /// <summary>
        /// Возвращает или задаёт индекс выбранной в данный момент заметки
        /// </summary>
        public int CurrentNoteIndex
        {
            get
            {
                return _currentNoteIndex;
            }

            set
            {
                _currentNoteIndex = value;
            }
        }

        /// <summary>
        /// Сортирует заметки в списке по их времени изменения
        /// </summary>
        public void SortNotes()
        {
            for (int i = 0; i < _notes.Count - 1; i++)
                if (_notes[i].ModifyingTime.CompareTo(_notes[i + 1].ModifyingTime) < 0)
                {
                    Note firstNote = _notes[i];
                    Note secondNote = _notes[i + 1];
                    _notes.RemoveAt(i);
                    _notes.Insert(i, secondNote);
                    _notes.RemoveAt(i + 1);
                    _notes.Insert(i + 1, firstNote);
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
