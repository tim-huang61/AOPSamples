using System;

namespace AOPSample.Model
{
    public class FileAccess : IFileAccess
    {
        private string _file;

        public FileAccess(string filename)
        {
            _file = filename;
        }

        public void Create()
        {
            Console.WriteLine($"Create a file : {_file}");
        }

        public void Delete()
        {
            Console.WriteLine($"Delete a file :{_file}");
        }

        public void Read()
        {
            Console.WriteLine($"Read from a file :{_file}"); 
        }

        public void Write()
        {
            Console.WriteLine($"Write to a file :{_file}"); 
        }
    }
}