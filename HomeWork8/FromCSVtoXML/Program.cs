#region Автор
// Щеглов Григорий
#endregion

#region Описание задачи
/*
    3. *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 */
#endregion

#region Список для CSV файла
/*
    Иван,Петров,НГТУ,ФМА,Электромеханики,20,3,31,Кемерово
    Дмитрий,Иванов,НГУ,МФ,Матанализа,19,2,45,Новосибирск
    Александр,Сидоров,СибГУТИ,ФРТ,Радиотехники,22,5,12,Томск
    Екатерина,Москвина,НГПУ,ФФ,Русского языка,21,1,117,Новокузнецк
    Дарья,Николаенко,НГМУ,ЛФ,Хирургии,20,3,221,Омск 
 */
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FromCSVtoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = LoadFromCSV("students.csv");
            SaveToXML(students, "students1.xml");
        }

        static List<Student> LoadFromCSV(string fileName)
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] line = sr.ReadLine().Split(',');
                    students.Add(new Student(line[0], line[1], line[2], line[3], line[4], int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]), line[8]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
            return students;
        }

        static void SaveToXML(List<Student> students, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(stream, students);
            stream.Close();
        }
    }

    [Serializable]
    public class Student
    {
        public string _firstName;
        public string _lastName;
        public string _university;
        public string _faculty;
        public string _department;
        public int _age;
        public int _course;
        public int _group;
        public string _city;

        public Student()
        {
        }

        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            _lastName = lastName;
            _firstName = firstName;
            _university = university;
            _faculty = faculty;
            _course = course;
            _department = department;
            _group = group;
            _city = city;
            _age = age;
        }
    }
}
