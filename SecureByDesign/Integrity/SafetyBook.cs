using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureByDesign.Integrity
{
    internal class SafetyBook
    {
        public SafetyBook(string title, string description, string author)
        {
            Title = title;
            Description = description;
            Autor = author;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string Autor { get; private set; }
    }
}
