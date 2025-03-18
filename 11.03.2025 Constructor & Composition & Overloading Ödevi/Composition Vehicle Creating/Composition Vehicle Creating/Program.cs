using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Vehicle_Creating
{
    class PencereSayisi
    {
        public int PencereSayi { get; set; }
        public PencereSayisi(int pencereSayi)
        {
            PencereSayi = pencereSayi;
        }
    }
    class Marka
    {
        public string MarkaAdi { get; set; }
        public Marka(string markaAdi)
        {
            MarkaAdi = markaAdi;
        }
    }
    class Model
    {
        public string ModelAdi { get; set; }
        public Model(string modelAdi)
        {
            ModelAdi = modelAdi;
        }
    }
    class KapiSayisi
    {
        public int KapiSayi { get; set; }
        public KapiSayisi(int kapiSayi)
        {
            KapiSayi = kapiSayi;
        }
    }
    class Araba
    {
        public PencereSayisi PencereSayisi { get; set; }
        public Marka Marka { get; set; }
        public Model Model { get; set; }
        public KapiSayisi KapiSayisi { get; set; }
        public Araba(PencereSayisi pencereSayisi, Marka marka, Model model, KapiSayisi kapiSayisi)
        {
            PencereSayisi = pencereSayisi;
            Marka = marka;
            Model = model;
            KapiSayisi = kapiSayisi;
        }
        public void BilgileriYazdir()
        {
            Console.WriteLine("Araba Markası: " + Marka.MarkaAdi);
            Console.WriteLine("Araba Modeli: " + Model.ModelAdi);
            Console.WriteLine("Araba Pencere Sayısı: " + PencereSayisi.PencereSayi);
            Console.WriteLine("Araba Kapı Sayısı: " + KapiSayisi.KapiSayi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Marka marka = new Marka("Mercedes");
            Model model = new Model("C180");
            PencereSayisi pencereSayisi = new PencereSayisi(4);
            KapiSayisi kapiSayisi = new KapiSayisi(4);

            Araba araba = new Araba(pencereSayisi, marka, model, kapiSayisi);
            araba.BilgileriYazdir();
        }
    }
}
