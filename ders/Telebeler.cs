using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{
    public class Telebe
    {
       
        public Telebe(string Ad , string Soyad,int Yas , Double Boy, string Unvan ) 
        { 
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Yas = Yas; 
            this.Boy = Boy;
            this.Unvan = Unvan;      
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public double Boy { get; set; }
        public string Unvan {  get; set; }
    }
}
