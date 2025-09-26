using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    internal class Film
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        private string description;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != "")
                {
                    description = value;
                }
            }
        }

        private string director;

        public string Director
        { 
            get
            {
                return director;
            }
            set
            {
                if (value != "")
                {
                    director = value;
                }
            }
        }

        public DateTime releaseDate;

        

        public Film(string name, string description, string director)
        {
            Name = name;
            Description = description;
            Director = director;
        }

        public Film()
        {
            Name = "Pulp Fiction";
            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.";
            Director = "Quentin Tarantino";
            releaseDate = new DateTime(1994, 10, 04);
        }


    }
}
