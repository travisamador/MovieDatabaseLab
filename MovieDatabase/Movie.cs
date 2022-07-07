using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        public int Length { get; set; }
        public int release { get; set; }
        public string leadRole { get; set; }
       
        //Constructor
        public Movie(string _title, string _category, int _length, int _release, string _leadRole)
        {
            Title = _title;
            Category = _category;
            Length = _length;
            release = _release;
            leadRole = _leadRole;
        }
        public void giveInfo()
        {
            Console.WriteLine($"{Title}, Runtime:{Length} minutes, Released:{release}, Starring:{leadRole}");
        }
    }
}
