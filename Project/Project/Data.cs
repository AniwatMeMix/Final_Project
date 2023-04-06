using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    internal class Data
    {
        public class Login
        {
            private string username;
            private string password;
            

            public Login(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

            public bool IsValid()
            {
                return (username == "MeMix" && password == "FreeWifi");
            }

        }
    }  
}
