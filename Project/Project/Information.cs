using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Information 
    {
        public string Name { get; set; }
        public string Student { get; set; }

        public string Facebook { get; set; }

        public string Email { get; set; }

        public Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }

        public string getName() { return this.Name; }
        public string getStudent() { return this.Student; }
        public string getFacebook() { return this.Facebook; }
        public string getEmail() { return this.Email; }


    }
}
