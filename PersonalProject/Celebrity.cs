using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    internal class Celebrity
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
                if (value != "" && value!= null)
                {
                    name = value;
                }
            }
        }

        public DateTime Birthday { get; set; }


        private List<Film> films;

        public List<Film> Films
        {
            get
            {
                return films;
            }
        }

        public Celebrity(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
            films = new List<Film>();
        }

    }

}


