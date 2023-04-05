using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Contact : Information
    {
        public Contact() 
        {
            this.Name = "แอดมิน อนิวัตติ์ ณ หนองคาย";
            this.Student = "คณะสหวิทยาการ มหาวิทยาลัยขอนแก่น";
            this._image = Properties.Resources.man;
            this.Facebook = "Aniwat na Nongkhai";
            this.Email = "Aniwat.n@kkumail.com";
        }
    }
}
