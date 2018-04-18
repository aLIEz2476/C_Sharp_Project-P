using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate_Class
{
    class Beginer
    {
        string beginSkill = "kick";
        public Beginer()
        {
            Console.WriteLine("Beginer Skill : " + beginSkill);
        }
    }

    class Warrior : Beginer
    {
        bool WarriorAura = false;
        string warriorSkill = "Slash";
        public Warrior()
        {
            Console.WriteLine("Warrior Skill : " + warriorSkill);
            WarriorPassive();
        }
        public void WarriorPassive()
        {
            WarriorAura = true;
        }
    }

    class Archer : Beginer
    {
        bool ArcherAura = false;
        string archerSkill = "SnipeShot";
        public Archer()
        {
            Console.WriteLine("Archer Skill : " + archerSkill);
            ArcherPassive();
        }
        public void ArcherPassive()
        {
            ArcherAura = true;
        }
    }

    class Berserker : Warrior
    {
        string berserkerSkill = "Rage Attack";
        public Berserker()
        {
            Console.WriteLine("Berserker Skill : " + berserkerSkill);
        }
    }

    class Ranger:Archer
    {
        string rangerSkill = "Multiple Shot";
        public Ranger()
        {
            Console.WriteLine("Ranger Skill : " + rangerSkill);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beginer begin = new Beginer();
            Warrior war = new Warrior();
            Archer ar = new Archer();
            Berserker ber = new Berserker();
            Ranger ran = new Ranger();
        }
    }
}
