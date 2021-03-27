using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Тест класса Note
    /// </summary>
    [TestFixture]
    class NoteTest
    {
        /// <summary>
        /// Положительный тест сеттера Name
        /// </summary>
        [Test(Description = "Положительный тест сеттера Name")]
        public void NameSet_CorrectValue()
        {
            var expectedName = "title";
            var note = new Note();
            note.Name = expectedName;

            Assert.AreEqual(DateTime.Now, note.ModifyingTime, "Сеттер Name задаёт " +
                "неправильное время изменения заметки");

            var actualName = note.Name;
            Assert.AreEqual(expectedName, actualName, "Сеттер Name задаёт неправильное название");
        }

        /// <summary>
        /// Негативный тест сеттера Name
        /// </summary>
        [Test(Description = "Негативный тест сеттера Name")]
        public void NameSet_longTitle()
        {
            var wrongTitle = "123456789 123456789 123456789 123456789 123456789 1";
            var note = new Note();

            Assert.Throws<ArgumentException>(() => { note.Name = wrongTitle; },
                "В сеттере Name должно возникать исключение при присваивании названия длиннее 50 символов");
        }

        /// <summary>
        /// Тест геттера Name
        /// </summary>
        [Test(Description = "Тест геттера Name")]
        public void NameGet()
        {
            var expected = "title";
            var note = new Note();
            note.Name = expected;

            var actual = note.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное значение");
        }

        /// <summary>
        /// Тест сеттера Category
        /// </summary>
        [Test(Description = "Тест сеттера Category")]
        public void CategorySet()
        {
            var expected = NoteCategory.documents;
            var note = new Note();
            note.Category = NoteCategory.documents;
            Assert.AreEqual(DateTime.Now, note.ModifyingTime, "Сеттер Category задаёт неправильное время изменения заметки");

            var actual = note.Category;
            Assert.AreEqual(expected, actual, "Сеттер Category задаёт неправильную категорию заметки");
        }

        /// <summary>
        /// Тест геттера Category
        /// </summary>
        [Test(Description = "Тест геттера Category")]
        public void CategoryGet()
        {
            var expected = NoteCategory.documents;
            var note = new Note();
            note.Category = expected;
            var actual = note.Category;

            Assert.AreEqual(expected, actual, "Геттер Category возвращает неправильное значение");
        }

        /// <summary>
        /// Тест сеттера NoteText
        /// </summary>
        [Test(Description = "Тест сеттера NoteText")]
        public void NoteTextSet()
        {
            var expected = "text";
            var note = new Note();
            note.NoteText = expected;
            Assert.AreEqual(DateTime.Now, note.ModifyingTime, "Сеттер NoteText задаёт неправильное время изменения заметки");

            var actual = note.NoteText;
            Assert.AreEqual(expected, actual, "Сеттер NoteText задаёт неправильный текст заметки");
        }

        /// <summary>
        /// Тест геттера NoteText
        /// </summary>
        [Test(Description = "Тест геттера NoteText")]
        public void NoteTextGet()
        {
            var expected = "text";
            var note = new Note();
            note.NoteText = expected;
            var actual = note.NoteText;

            Assert.AreEqual(expected, actual, "Геттер NoteText возвращает неправильное значение");
        }

        /// <summary>
        /// Тест сеттера CreatingTime
        /// </summary>
        [Test(Description = "Тест сеттера CreatingTime")]
        public void CreatingTimeSet()
        {
            var expected = DateTime.Now;
            var note = new Note();
            note.CreatingTime = expected;
            var actual = note.CreatingTime;

            Assert.AreEqual(expected, actual, "Сеттер CreatingTime задаёт неправильное время создания заметки");
        }

        /// <summary>
        /// Тест геттера CreatingTime
        /// </summary>
        [Test(Description = "Тест геттера CreatingTime")]
        public void CreatingTimeGet()
        {
            var expected = DateTime.Now;
            var note = new Note();
            note.CreatingTime = expected;
            var actual = note.CreatingTime;

            Assert.AreEqual(expected, actual, "Геттер CreatingTime возвращает неправильное время создания заметки");
        }

        /// <summary>
        /// Тест сеттера ModifyingTime
        /// </summary>
        [Test(Description = "Тест сеттера ModifyingTime")]
        public void ModifyingTimeSet()
        {
            var expected = DateTime.Now;
            var note = new Note();
            note.ModifyingTime = expected;
            var actual = note.ModifyingTime;

            Assert.AreEqual(expected, actual, "Сеттер CreatingTime задаёт неправильное время создания заметки");
        }

        /// <summary>
        /// Тест геттера ModifyingTime
        /// </summary>
        [Test(Description = "Тест геттера ModifyingTime")]
        public void ModifyingTimeGet()
        {
            var expected = DateTime.Now;
            var note = new Note();
            note.ModifyingTime = expected;
            var actual = note.ModifyingTime;

            Assert.AreEqual(expected, actual, "Геттер CreatingTime возвращает неправильное время создания заметки");
        }

        /// <summary>
        /// Тест конструктора Note()
        /// </summary>
        [Test(Description = "Тест конструктора Note()")]
        public void Constructor()
        {
            var expected = new Note();
            expected.Name = "Без названия";
            expected.Category = NoteCategory.other;
            var actual = new Note();

            Assert.AreEqual(expected.Name, actual.Name, "Конструктор Note() неправильно создаёт название заметки");
            Assert.AreEqual(expected.Category, actual.Category, "Конструктор Note() неправильно создаёт категорию заметки");
        }
    }
}