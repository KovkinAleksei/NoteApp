using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Сохранение записок в файл
        /// </summary>
        public static void SaveInFile(string path, Project project)
        {
            // Создание сериализатора
            JsonSerializer serializer = new JsonSerializer();

            // Открытие потока для записи
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter write = new JsonTextWriter(sw))
            {
                // Запись в файл
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
            try
            {
                using (StreamReader sr = new StreamReader(path))
                using (JsonReader read = new JsonTextReader(sr))
                {
                    // Чтение записок из файла
                    project = (Project)serializer.Deserialize<Project>(read);
                }

                return project;
            }
            catch (Exception ex)
            {
                return new Project();
            }
        }
    }
}
