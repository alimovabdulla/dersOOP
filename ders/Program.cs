using Ders;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
Telebe Abdullah = new Telebe("Abdullah", "Alimov", 19, 1.80, "Axundov");
Telebe Ivan = new Telebe("Ivan", "Petrovic", 25, 1.60, "Dubay");
Telebe Vasya = new Telebe("Vasya", "Baranov", 22, 1.51, "Ufa");
Telebe Ayxan = new Telebe("Ayxan", "Muslumov", 20, 1.70, "Yoxdu");
Telebe Rafiq = new Telebe("Rafiq", "BAbayev", 18, 1.86, "Mastaga");
Telebe Natasha = new Telebe("Natasha", "Vladimirovna", 20, 1.70, "Moscow");


University university = new University();
university.Name = "Amsterdam";
University.CreateTelebe(Abdullah);
university.MelumatiGoster();

