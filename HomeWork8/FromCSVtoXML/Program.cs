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
            var fileName = "students.csv";
            List<Student> students = LoadFromCSV(fileName);
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
