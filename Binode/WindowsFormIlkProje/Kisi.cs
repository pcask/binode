﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormIlkProje
{
    public class Kisi
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string Uzmanlik { get; set; }


        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
