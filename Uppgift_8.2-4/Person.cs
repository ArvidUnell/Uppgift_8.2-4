using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_8._2_4
{
    internal class Person
    {
        private string förnamn;
        private string efternamn;
        public string Förnamn
        {
            get
            {
                return förnamn;
            }
            set
            {
                förnamn = value;
            }
        }
        public string Efternamn
        {
            get
            {
                return efternamn;
            }
            set
            {
                efternamn = value;
            }
        }

        public string FulltNamn()
        {
            return förnamn + " " + efternamn;
        }


        private DateTime födelsedatum;
        public DateTime Födelsedatum
        {
            get
            {
                return födelsedatum;
            }
            set
            {
                födelsedatum = value;
            }
        }
        public bool ÄrMyndig()
        {
            if (DateTime.Now.Year - födelsedatum.Year < 18)
            {
                return false;
            }
            if (DateTime.Now.Year - födelsedatum.Year > 18)
            {
                return true;
            }
            return DateTime.Now.DayOfYear >= födelsedatum.DayOfYear;
        }


        private float längd;
        public float Längd
        {
            get
            {
                return längd;
            }
            set
            {
                if (value < 0)
                {
                    längd = 0;
                }
                else
                {
                    längd = value;
                }
            }
        }

        private int vikt;
        public int Vikt
        {
            get
            {
                return vikt;
            }
            set
            {
                if (value < 0)
                {
                    vikt = 0;
                }
                else
                {
                    vikt = value;
                }
            }
        }

        public float BMI()
        {
            return vikt / (längd * längd);
        }
    }
}
