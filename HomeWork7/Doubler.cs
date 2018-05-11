using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HomeWork7
{
    /// <summary>
    /// Class Doubler
    /// </summary>
    class Doubler
    {
        /// <summary>
        /// Current value
        /// </summary>
        int current;

        /// <summary>
        /// Target value
        /// </summary>
        int finish;

        /// <summary>
        /// Steps
        /// </summary>
        int steps;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="finish"></param>
        public Doubler()
        {
            Random random = new Random();
            finish = random.Next(1, 101);
            current = 1;
            steps = 0;
        }

        /// <summary>
        /// Properties Current, return current value
        /// </summary>
        public int Current
        {
            get
            {
                return current;
            }
        }

        /// <summary>
        /// Properties Finish, return finish value
        /// </summary>
        public int Finish
        {
            get
            {
                return finish;
            }
        }

        /// <summary>
        /// Properties Steps, return steps value
        /// </summary>
        public int Steps
        {
            get
            {
                return steps;
            }
        }

        /// <summary>
        /// Increment by 1
        /// </summary>
        public void Increment()
        {
            current++;
            steps++;
        }

        /// <summary>
        /// Doubling
        /// </summary>
        public void Doubling()
        {

            current *= 2;
            steps++;
        }

        public void Back(string logMessage)
        {
            string pattern = @"^Шаг: (\d*); (.*);.*: (\d*)";

            // Создаем регулярное выражения дя поиска тегов                
            Regex regex = new Regex(pattern);

            // Выводим найденные адреса на экран
            Match c = regex.Match(logMessage);
            //Console.WriteLine($"{c} {regex.Matches(s)}");
            //Console.WriteLine($"{c.Groups[1].Value}, {c.Groups[2].Value}, {c.Groups[3].Value}");
            steps = Int32.Parse(c.Groups[1].Value);
            current = Int32.Parse(c.Groups[3].Value);
        }

        /// <summary>
        /// Reset to default (1)
        /// </summary>
        public void Reset()
        {
            current = 1;
            steps++;
        }

        public string Log(string action)
        {
            return $"Шаг: {Steps.ToString()}; {action}; значение: {Current.ToString()}";
        }
    }
}
