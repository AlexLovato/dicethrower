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
        {//tell them the format
            Console.WriteLine("type a format like 6d7 where 7 is the number of sides and 6 is the number of times rolled");

            //recieve their input
          string input =  Console.ReadLine();
            Console.WriteLine("rolling: " + input);
            changeInput(input);
            Console.WriteLine("Results per roll");
        }
        static void changeInput(string dice)
        {
            //set up variables
            string firstNumber = null;
            string secondNumber1 = null;
            string secondnumber2 = null;
           var diceList = dice.ToList();
            //take apart the input 
            foreach (char a in diceList)
            {
                if (a == 'd')
                {
                    break;
                }
                else {firstNumber = firstNumber + a;}
            }
            for (int i = diceList.Count-1; i > 0; i-- )
            {//break apart at the D to separate the numbers
                if (diceList[i] == 'd')
                {
                    break;
                }
                else { secondNumber1 = secondNumber1 + diceList[i]; }
            }
            for (int i = secondNumber1.Length-1; i >= 0; i--)
            {
                secondnumber2 = secondnumber2 + secondNumber1[i];
            }//confirm their numbers just to clarify
            Console.WriteLine("first number = " + firstNumber + "second number is = " + secondnumber2);
            Console.ReadKey();
            int timesRolled = int.Parse(firstNumber);
            int numSides = int.Parse(secondnumber2);
            //make em ints
            //make a random number in specified size in specified number of rolls
            for (int i = 0; i < timesRolled; i++)
            {
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(1, numSides);
                int rollCount = i + 1;
              //display info
                Console.WriteLine("Roll " + rollCount + " = " + randomNumber);
                Console.ReadKey();
            }
            


        }
       
    }
}
