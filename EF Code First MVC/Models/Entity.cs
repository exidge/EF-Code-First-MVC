using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

    //id imieNazwisko takObiad takNocleg takOplata dataPrzyjazdu dataOdjazdu
    public class Uczestnik
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public bool takObiad { get; set; }
        public bool takNocleg { get; set; }
        public bool takOplata { get; set; }
        public DateTime dataPrzyjazdu { get; set; }
        public DateTime dataOdjazdu { get; set; }
    }

    

