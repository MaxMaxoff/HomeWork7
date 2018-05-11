using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Game
    {
        int number;
        Random random = new Random();

        public int Number
        {
            get { return number; }
        }

        public Game()
        {
            number = random.Next(1,101);
        }

        public int Status(int number)
        {            
            if (this.number < number) return -1;
            if (this.number > number) return 1;            
            return 0;
        }
    }
}
