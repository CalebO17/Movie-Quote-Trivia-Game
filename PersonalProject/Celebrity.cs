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
                if (name == null || name =="")
                {
                    name = "Jeff";
                }
                return name;
            }
            set
            {
                name = value;
            }
        }

        private DateTime birthday;

        public Image image { get; set; }
        public Celebrity (string initialName, DateTime initialBirthday, Image initialImage)
        {
            name = initialName;
            birthday = initialBirthday;
            image = initialImage;
        }

    }

}


