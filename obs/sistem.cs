using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obs
{
    public class Ogrenci
    {
        public int Numara { get; set; }
        public string adSoyad { get; set; }
        public override string ToString()
        {
            return $"{Numara} - {adSoyad}";
        }
    }
    public interface IRaporlanabilir
    {
        string rapor();
    }
    public abstract class Ders : IRaporlanabilir
    {
        public string dersKodu { get; set; }
        public string dersAdi { get; set; }
        public int Kredi { get; set; }

        public abstract string rapor(); 
        public override string ToString()
        {
            return $"{dersKodu} - {dersAdi}";
        }
    }
    public class Zorunlu : Ders
    {
        public override string rapor()
        {
            return $"[Z] {dersKodu} {Kredi} kredi";
        }
    }
    public class Secmeli : Ders
    {
        public override string rapor()
        {
            return $"[S] {dersKodu} {Kredi} kredi";
        }
    }
    public class Not
    {
        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        public double Ort => Vize * 0.4 + Final * 0.6;
        public override string ToString()
        {
            return $"{Ders.dersAdi} - Vize: {Vize}, Final: {Final}, Ortalama: {Ort}";
        }
    }
}
