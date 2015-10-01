using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestLabo2
{
    public class PrivateContact : Person
    {
        public string NumTelPrive { get; set; }
        public string MailPrive { get; set; }
        public DateTime DateNaiss { get; set; }

        public PrivateContact(string nom, string prenom, string numTelPrive, string mailPrive) : base(nom, prenom)
        {
            NumTelPrive = numTelPrive;
            MailPrive = mailPrive;
        }

        public PrivateContact(string nom, string prenom, string numTelPrive, string mailPrive, DateTime dateNaiss) : base(nom, prenom)
        {
            NumTelPrive = numTelPrive;
            MailPrive = mailPrive;
            DateNaiss = dateNaiss;
        }

        public override bool BirthdayWish()
        {
            return (DateTime.Today.Month == DateNaiss.Month && DateTime.Today.Day == DateNaiss.Day);
        }
        
        public override string ToString()
        {
            return base.ToString() + "(" + NumTelPrive + ")\n" + MailPrive;
        }
    }
}
