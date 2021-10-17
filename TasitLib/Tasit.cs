using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasitLib
{//OKAN ERDEM -193801025
    public class Tasit
    {
        public Tasit(string marka, int kapisayisi, int koltuksayisi) 
        {
            this.Marka = marka;
            this.KapiSayisi = kapisayisi;
            this.KoltukSayisi = koltuksayisi;
            
        }

        private string marka;
        public string Marka { get => marka; set => marka = value.ToUpper(); }
        private int kapisayisi;
        public int KapiSayisi { get => kapisayisi; set => kapisayisi = value; }
        private int koltuksayisi;
        public int KoltukSayisi { get => koltuksayisi; set => koltuksayisi = value; }


        public virtual string TasitBil()
        {
            return $"Marka: {this.Marka}\nKapi Sayisi: {this.KapiSayisi}\nKoltuk Sayisi: {this.KoltukSayisi}\n";
        }
    }
}
