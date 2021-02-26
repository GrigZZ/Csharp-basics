using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Form2 form = new Form2();
            Application.Run(form);
        }
    }

    [Serializable]
    public class Question
    {
        private string _text;
        private bool _trueFalse;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public bool TrueFalse
        {
            get { return _trueFalse; }
            set { _trueFalse = value; }
        }

        public Question()
        {

        }

        public Question(string text, bool trueFalse)
        {
            _text = text;
            _trueFalse = trueFalse;
        }
    }

    class TrueFalse
    {
        private string _fileName;
        private List<Question> _questions;

        public string FileName
        {
            set { _fileName = value; }
        }

        public int Count => _questions.Count;

        public Question this[int index] => _questions[index];

        public TrueFalse(string fileName)
        {
            _fileName = fileName;
            _questions = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            if (_questions == null)
                return;

            _questions.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (_questions != null && index < _questions.Count && index >= 0)
                _questions.RemoveAt(index);
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream stream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(stream, _questions);
            stream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            _questions = xmlFormat.Deserialize(stream) as List<Question>;
            stream.Close();
        }
    }
}
