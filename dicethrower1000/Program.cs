using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicethrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a format like 6d7 where 7 is the number of sides and 6 is the number of times rolled");
          string input =  Console.ReadLine();
            Console.WriteLine("rolling: " + input);
            changeInput(input);
            Console.WriteLine("Results per roll");
        }
        static void changeInput(string dice)
        {
            string firstNumber = null;
            string secondNumber1 = null;
            string secondnumber2 = null;
           var diceList = dice.ToList();
            foreach (char a in diceList)
            {
                if (a == 'd')
                {
                    break;
                }
                else {firstNumber = firstNumber + a;}
            }
            for (int i = diceList.Count-1; i > 0; i-- )
            {
                if (diceList[i] == 'd')
                {
                    break;
                }
                else { secondNumber1 = secondNumber1 + diceList[i]; }
            }
            for (int i = secondNumber1.Length-1; i >= 0; i--)
            {
                secondnumber2 = secondnumber2 + secondNumber1[i];
            }
            Console.WriteLine("first number = " + firstNumber + "second number is = " + secondnumber2);
            Console.ReadKey();
            int timesRolled = int.Parse(firstNumber);
            int numSides = int.Parse(secondnumber2);
            for (int i = 0; i < timesRolled; i++)
            {
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(1, numSides);
                int rollCount = i + 1;
                Console.WriteLine("Results per roll");
                Console.WriteLine("Roll " + rollCount + " = " + randomNumber);
                Console.ReadKey();
            }
            


        }
       
    }
}
