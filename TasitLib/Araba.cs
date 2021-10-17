using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TasitLib
{//OKAN ERDEM -193801025
    public class Araba : Tasit
    {
        
       
        public Araba(string marka, int kapisayisi, int koltuksayisi, string vitesturu, string yakitturu, string kasatipi, int yil) : base(marka, kapisayisi, koltuksayisi)
        {
            this.VitesTuru = vitesturu;
            this.YakitTuru = yakitturu;
            this.KasaTipi = kasatipi;
            this.Yili = yil;
        }


        public string VitesTuru { get; set; }
        public string YakitTuru { get; set; }
        public string KasaTipi { get; set; }
        public int Yili { get; set; }

        public override string TasitBil()
        {
            return base.TasitBil() + $"Vites Türü: {this.VitesTuru}\nYakıt Türü: {this.YakitTuru}\nKasa Tipi: {this.KasaTipi}\nYılı: {this.Yili}";
        }

    }
}
