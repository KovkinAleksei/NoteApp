using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;
using System.IO;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        private string _path = "C:\\ProjectManagerTest.txt";

        /// <summary>
        /// Тест записи и чтения файла
        /// </summary>
        [Test(Description = "Тест записи и чтения файла")]
        public void ProjectManager_SaveAndRead()
        {
            var expected = new Project();
            var actual = new Project();
            var note = new Note();
            expected.CategoryIndex = 1;
            expected.NoteIndex = 0;
            note.Name = "title";
            expected.Notes.Add(note);

            ProjectManager.SaveInFile(_path, expected);
            actual = ProjectManager.ReadFile(_path);

            Assert.AreEqual(expected.CategoryIndex, actual.CategoryIndex,
                "Класс ProjectManager неверно записывает в файл и читает индекс выбранной категории заметки");
            Assert.AreEqual(expected.NoteIndex, actual.NoteIndex,
                "Класс ProjectManager неверно записывает в файл и читает индекс выбранной заметки");
            Assert.AreEqual(expected.Notes[0].Name, actual.Notes[0].Name,
                "Класс ProjectManager неверно записывает в файл и читает заметки");

            File.Delete(_path);
        }
    }
}
