using System;
using System.Collections;
using System.Collections.Generic;

namespace oop_lesson5_eightball
{
    public class Program
    {
        static void Main(string[] args)
        {
                Random random = new Random();
                int randomNumber = random.Next(1, 21);
                Console.WriteLine(randomNumber);

                ArrayList myAnswers = new ArrayList();
                //positive answers
                myAnswers.Add("It's certain.");
                myAnswers.Add("It is decidedly so.");
                myAnswers.Add("Without a doubt.");
                myAnswers.Add("Yes definitely.");
                myAnswers.Add("You may rely on it.");
                myAnswers.Add("As I see it, yes.");
                myAnswers.Add("Most likely.");
                myAnswers.Add("Outlook good.");
                myAnswers.Add("Yes.");
                myAnswers.Add("Signs point to yes.");

                //Non - committal answers
                myAnswers.Add("Reply hazy, try again.");
                myAnswers.Add("Ask again later.");
                myAnswers.Add("Better not tell you now.");
                myAnswers.Add("Cannot predict now.");
                myAnswers.Add("Concentrate and ask again.");

                //Negative answers
                myAnswers.Add("Don't count on it.");
                myAnswers.Add("My reply is no.");
                myAnswers.Add("Outlook not so good.");
                myAnswers.Add("My sources say no.");
                myAnswers.Add("Very doubtful.");

                Console.WriteLine("********************************************");
                Console.WriteLine(myAnswers[randomNumber]);
                Console.WriteLine("********************************************");
            }
        }

    }

