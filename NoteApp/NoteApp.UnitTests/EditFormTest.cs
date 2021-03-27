using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteAppUI;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class EditFormTest
    {
        /// <summary>
        /// Тест сеттера Note
        /// </summary>
        [Test(Description = "Тест сеттера Note")]
        public void NoteSet()
        {
            var expected = new Note();
            var editNote = new EditForm();
            expected.Name = "title";
            expected.Category = NoteCategory.documents;
            expected.NoteText = "Text";

            editNote.Note = expected;
            var actual = editNote.Note;

            Assert.AreEqual(expected.Name, actual.Name,
                "Сеттер Note неправильно задаёт название заметки");
            Assert.AreEqual(expected.Category, actual.Category,
                "Сеттер Note неправильно задаёт категорию заметки");
            Assert.AreEqual(expected.NoteText, actual.NoteText,
                "Сеттер Note неправильно задаёт текст заметки");
            Assert.AreEqual(expected.CreatingTime, actual.CreatingTime,
                "Сеттер Note неправильно задаёт время создания заметки");
            Assert.AreEqual(expected.ModifyingTime.Second, actual.ModifyingTime.Second,
                "Сеттер Note неправильно задаёт время изменения заметки");
        }

        /// <summary>
        /// Тест геттера Note
        /// </summary>
        [Test(Description = "Тест геттера Note")]
        public void NoteGet()
        {
            var expected = new Note();
            var editNote = new EditForm();
            expected.Name = "title";
            expected.Category = NoteCategory.documents;
            expected.NoteText = "Text";

            editNote.Note = expected;
            var actual = editNote.Note;

            Assert.AreEqual(expected.Name, actual.Name,
                "Геттер Note неправильно возвращает название заметки");
            Assert.AreEqual(expected.Category, actual.Category,
                "Геттер Note неправильно возвращает категорию заметки");
            Assert.AreEqual(expected.NoteText, actual.NoteText,
                "Геттер Note неправильно возвращает текст заметки");
            Assert.AreEqual(expected.CreatingTime, actual.CreatingTime,
                "Геттер Note неправильно возвращает время создания заметки");
            Assert.AreEqual(expected.ModifyingTime.Second, actual.ModifyingTime.Second,
                "Геттер Note неправильно возвращает время изменения заметки");
        }
    }
}
