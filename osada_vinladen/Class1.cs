using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osada_vinladen
{
    internal class Anagram : INotifyPropertyChanged
    {
        public string slowo1;
        public string slowo2;
        public string wynik;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Anagram()
        {
            Slowo1 = "";
            Slowo2 = "";
            Wynik = "";

        }
        public string Slowo1
        {
            get { return slowo1; }
            set
            {
                slowo1 = value;
                checkPropertyChangeEvent("Pierwsze słowo");
            }
        }
        public string Slowo2
        {
            get { return slowo2; }
            set
            {
                slowo2 = value;
                checkPropertyChangeEvent("Drugie słowo");
            }
        }
        public string Wynik
        {
            get { return wynik; }
            set
            {
                wynik = value;
                checkPropertyChangeEvent("Wynik");
            }
        }

        public void checkPropertyChangeEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string SprawdzAna()
        {
            slowo1.ToUpper();
            slowo2.ToUpper();
            char[] slowko1 = slowo1.ToCharArray();
            char[] slowko2 = slowo2.ToCharArray();
            if (slowko1.Length == slowko2.Length)
            {

                Array.Sort(slowko1);
                Array.Sort(slowko2);
                bool isEqual;
                if (isEqual = Enumerable.SequenceEqual(slowko1, slowko2))
                {
                    wynik = "To są Anagramy";
                    return wynik;

                }
                else
                {
                    wynik = "To Nie Są Anagramy";
                    return wynik;
                }


            }
            else
            {
                wynik = "Nie wiem czy to Anagramy";
                return wynik;
            }

        }
    }
}
