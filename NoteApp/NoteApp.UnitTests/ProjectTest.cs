using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        /// <summary>
        /// Тест геттера Notes
        /// </summary>
        [Test(Description = "Тест геттера Notes")]
        public void NotesGet()
        {
            var project = new Project();
            var note = new Note();
            var expected = new List<Note>();
            expected.Add(note);

            project.Notes.Add(note);

            var actual = project.Notes;
            Assert.AreEqual(expected, actual, "Геттер Notes возвращает неправильный список заметок");
        }

        /// <summary>
        /// Тест сеттера CategoryIndex
        /// </summary>
        [Test(Description = "Тест сеттера CategoryIndex")]
        public void CategoryIndexSet()
        {
            var expected = 1;
            var project = new Project();
            project.CategoryIndex = expected;

            var actual = project.CategoryIndex;
            Assert.AreEqual(expected, actual, "Сеттер CategoryIndex задаёт неправильный индекс");
        }

        /// <summary>
        /// Тест геттера CategoryIndex
        /// </summary>
        [Test(Description = "Тест геттера CategoryIndex")]
        public void CategoryIndexGet()
        {
            var expected = 1;
            var project = new Project();
            project.CategoryIndex = expected;

            var actual = project.CategoryIndex;
            Assert.AreEqual(expected, actual, "Геттер CategoryIndex возвращает неправильный индекс");
        }

        /// <summary>
        /// Тест сеттера NoteIndex
        /// </summary>
        [Test(Description = "Тест сеттера NoteIndex")]
        public void NoteIndex()
        {
            var expected = 1;
            var project = new Project();
            project.NoteIndex = expected;

            var actual = project.NoteIndex;
            Assert.AreEqual(expected, actual, "Сеттер NoteIndex задаёт неправильный индекс");
        }

        /// <summary>
        /// Тест геттера NoteIndex
        /// </summary>
        [Test(Description = "Тест геттера NoteIndex")]
        public void NoteIndexGet()
        {
            var expected = 1;
            var project = new Project();
            project.NoteIndex = expected;

            var actual = project.NoteIndex;
            Assert.AreEqual(expected, actual, "Геттер NoteIndex возвращает неправильный индекс");
        }

        /// <summary>
        /// Тест конструктора Project()
        /// </summary>
        [Test(Description = "Тест конструктора Project()")]
        public void Constructor()
        {
            var expectedNotesList = new List<Note>();
            var expected = new Project();
            expected.CategoryIndex = 0;
            expected.NoteIndex = -1;

            var actual = new Project();
            Assert.AreEqual(expectedNotesList, actual.Notes, "Конструктор Project() неправильно создаёт " +
                "список заметок");
            Assert.AreEqual(expected.NoteIndex, actual.NoteIndex, "Конструктор Project() неправильно " +
                "создаёт индекс выбранной заметки");
            Assert.AreEqual(expected.CategoryIndex, actual.CategoryIndex, "Конструктор Project() неправильно " +
                "создаёт индекс выбранной категории заметок");
        }
    }
}
