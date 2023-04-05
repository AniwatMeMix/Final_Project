using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Information 
    {
        protected string Name { get; set; }
        protected string Student { get; set; }

        protected string Facebook { get; set; }

        protected string Email { get; set; }

        protected Bitmap _image;

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
