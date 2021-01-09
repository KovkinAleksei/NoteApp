using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    class ProjectManager
    {
        /// <summary>
        /// Сохранение записок в файл
        /// </summary>
        public static void SaveInFile(Project project, string path)
        {
            // Создание сериализатора
            JsonSerializer serializer = new JsonSerializer();

            // Открытие потока для записи
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter write = new JsonTextWriter(sw))
            {
                // Запись записок в файл
                serializer.Serialize(write, project);
            }
        }

        /// <summary>
        /// Чтение записок из файла
        /// </summary>
        public static Project ReadFile(string path)
        {
            Project project;

            // Создание сериализатора
            JsonSerializer serializer = new JsonSerializer();

            // Открытие потока для чтения
            using (StreamReader sr = new StreamReader(path))
            using (JsonReader read = new JsonTextReader(sr))
            {
                // Чтение записок из файла
                project = (Project)serializer.Deserialize<Project>(read);
            }

            return project;
        }
    }
}
