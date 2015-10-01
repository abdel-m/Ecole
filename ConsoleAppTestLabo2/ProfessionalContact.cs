using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestLabo2
{
    public class ProfessionalContact : Person
    {
        public string Profession { get; set; }
        public string NumTelPro { get; set; }
        public string MailPro { get; set; }

        public ProfessionalContact(string nom, string prenom, string profession, string numTelPro, string mailPro) : base(nom, prenom)
        {
            Profession = profession;
            NumTelPro = numTelPro;
            MailPro = mailPro;
        }

        public override string ToString()
        {
            return base.ToString() + "(" + NumTelPro + ")\n" + Profession + "\n" + MailPro;
        }

        public override bool BirthdayWish()
        {
            return false;
        }
    }
}
