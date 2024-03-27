using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{

    public class University
    {

        public string Name { get; set; }
        
        
        public static List<Telebe> students { get; set; } = new List<Telebe>();
        /// <summary>
        /// Static keywordu istifade ettiyime gore bu metod yalniz Class uzerinden Cagrila bilir
        /// </summary>
        public static void CreateTelebe(Telebe telebe)
        {


            students.Add(telebe);
        }
        public void MelumatiGoster()
        {

            foreach (Telebe i in students)
            {
                Console.WriteLine($"Ad: {i.Ad} Soyad: {i.Soyad} Yas: {i.Yas} Boy:{i.Boy} Unvan:{i.Unvan}");

            }




        }








    }








}