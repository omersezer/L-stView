using LVKullanimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LVKullanimi.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfa : ContentPage
    {
        List<Rehber> liste = new List<Rehber>();
        public AnaSayfa()
        {
            InitializeComponent();
            ListeDoldur(liste);
            listRehber.BindingContext = liste;
        }
        public void ListeDoldur(List<Rehber> list)
        {
            list.Add(new Rehber
            {
                Ad = "Ömer",
                Soyad = "Sezer",
                Numara = "21423423525",
                Mail = "oomersezer@gmail.com",
                Adres = "asdadasdasd"
            });
            list.Add(new Rehber
            {
                Ad = "Mehmet",
                Soyad = "Şükrü",
                Numara = "2141241241",

            });
            list.Add(new Rehber
            {
                Ad = "Ahmet",
                Soyad = "Veli",
                Numara = "34235235"
            });
        }
    }
}