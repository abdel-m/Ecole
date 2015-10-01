using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact pc1 = new PrivateContact("vdb", "julien", "0478252525", "julien.vdb@gmail.com");
            PrivateContact pc2 = new PrivateContact("nicolay", "julien", "0478252525", "julien.vdb@gmail.com", DateTime.Now);

            ProfessionalContact proContact1 = new ProfessionalContact("jean", "martin", "consultant", "0478236363", "jeanmartin@gmail.com");
            ProfessionalContact proContact2 = new ProfessionalContact("terence", "nico", "consultant", "0478236363", "terencenico@gmail.com");
            ProfessionalContact proContact3 = new ProfessionalContact("florent", "dachi", "indépendanr", "0478236363", "flodachi@gmail.com");

            Console.WriteLine(pc1 + (pc1.BirthdayWish()?" Bon anniversaire !":""));
            Console.WriteLine(pc2 + (pc2.BirthdayWish() ? " Bon anniversaire !" : ""));
            Console.Read();
        }
    }
}
