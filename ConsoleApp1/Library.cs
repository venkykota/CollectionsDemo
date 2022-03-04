using System;

namespace ConsoleApp1
{
    public class Library
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public override string ToString()
        {
            return $" {ISBN}, {Author} ";
        }
    }
}