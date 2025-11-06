using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    internal class Film
    {
        public string name {  get; set; }

        private string description;

        private string director;

        private DateTime releaseDate;

        public Image image {  get; set; }
        public Film(string initialName, string initialDescription, string initialDirector, DateTime initialReleaseDate, Image initialImage)
        {
            name = initialName;
            description = initialDescription;
            director = initialDirector;
            releaseDate = initialReleaseDate;
            image = initialImage;
        }


    }
}
