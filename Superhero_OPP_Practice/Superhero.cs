using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_OPP_Practice
{
    class Superhero
    {
        private string strengthLevel;
        private int hasMoney;
        private string hasCape;
        private string isKnown;

        public string StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }
        public int HasMoney
        {
            get { return this.hasMoney; }
            set { this.hasMoney = value; }
        }
        public string HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        public string IsKnown
        {
            get { return this.isKnown; }
        }

        public Superhero()
        {

        }
        public Superhero(int hasMoney, string isKnown, string strengthLevel)
        {
            this.hasMoney = hasMoney;
            this.isKnown = isKnown;
            this.strengthLevel = strengthLevel;
        }
        public void isHit()
        {
            strengthLevel = "Damaged. ";
            Console.WriteLine(strengthLevel);
        }
        public void lostCape()
        {
            hasCape = "Oh no! It's gone! ";
            Console.WriteLine(hasCape);
        }
    }
}
