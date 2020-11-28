using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerRank : MonoBehaviour
{
    private void Start()
    {

        string[] testLines = new string[12]
        {
            "hacker",
            "rank",
            "jkotzxzxrxtzytlruwrxytyzsuzytwyzxuzytryzuzysxvsmupouysywywqlhg",
            "eklrywzvpxtvoptlrskmskszvwzsuzxrtvyzwruqvyxusqwupnurqmtltnltsmuyxqoksyurpwqpv",
            "efhpuvqvnuwpvwysvnunostvpqvxtxsvqwqvsxtxvqpvtsonunvsywvpwunvqvupxzy",
            "otytmpszumnryqvxpvnvxyvpvprumnvsqwqwtsqyqksqvnuqpxszwzsxsx",
            "bhmptlqswsvoqsvzyzwoqtvowpyqxpwurpxutswtrpwzvrpkswzuo",
            "rvovprxzvwrxpwpzsltzutxztrxqxt",
            "ceiosyrtztvnqsuozrxvtqywqwyrxtnjh",
            "djnsyzxszryqworuxpqvqwquvotzsqvoupwvztzupowtqnvpxqyrwutzuys",
            "kovzuywsuvwxuxtwzryzuxyvouvyskoqtwryszxqqxzsyrwtqoksyvuovyxuzyrzwtxuxwvuswuqvryu",
            "ptvzstvotxqyvzrwyqryzrpkswzryupwutmigc",
        };

        HackerRank_30DaysOfCode_Day6_LetsReview(12, testLines);

    }



    private void HackerRank_30DaysOfCode_Day2_Operators(double meal_cost, int tip_percent, int tax_percent)
    {
        // complete
        // get meal cost rounded

        double tip = meal_cost * tip_percent / 100;
        Debug.Log(tip);
        double tax = meal_cost * tax_percent / 100;
        Debug.Log(tax);
        double totalCost = meal_cost + tip + tax;
        Debug.Log(totalCost);
        totalCost = Math.Round(totalCost);
        Debug.Log(totalCost);

    }

    private void HackerRank_30DaysOfCode_Day3_ConditionalStatements(int number)
    {
        // complete
        // Find odd and even numbers
        // use conditions to label even numbers
        int[] even = new int[] { 0, 2, 4, 6, 8 };
        int[] odd = new int[] { 1, 3, 5, 7, 9 };

        foreach (int e in even)
        {
            if (number == 0)
            {
                Debug.Log($"{0} == Not Weird");
                return;
            }
            if (number.ToString().EndsWith(e.ToString()))
            {
                if (number >= 2 && number <= 5 || number > 20)
                {
                    //  Console.WriteLine("Not Weird");
                    Debug.Log($"{number} >=2 <=5 > 20 == Not Weird");
                    return;
                }
                if (number >= 6 && number <= 20)
                {
                    //  Console.WriteLine("Wierd");
                    Debug.Log($"{number} >=6 <=20 == Wierd");
                    return;
                }
            }
        }
        foreach (int o in odd)
        {


            if (number.ToString().EndsWith(o.ToString()))
            {
                // Console.WriteLine("Wierd");
                Debug.Log($"{o} == Wierd");
                return;
            }
        }
        Debug.Log("Fininshed method");
    }

    #region HackerRank_30DaysOfCode_Day4_Class Vs. Instance


    /// <summary>
    /// HackerRank_30DaysOfCode_Day4_Class Vs. Instance
    /// </summary>
    public class Person
    {
        private int age;

        private Person(int initialAge)
        {
            if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0..");
            }
        }
        private void yearPasses()
        {
            age++;
        }
        private void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young..");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager..");
            }
            else
            {
                Console.WriteLine("You are old..");
            }
        }
    }


    #endregion


    public void HackerRank_30DaysOfCode_Day6_LetsReview(int howMany, string[] inputLines)
    {
        int[] even = new int[] { 0, 2, 4, 6, 8 };
        int[] odd = new int[] { 1, 3, 5, 7, 9 };

        // int index = Convert.ToInt32(Console.ReadLine());
         int index = howMany;
        List<string> lines = new List<string>();
        for (int i = 0; i < index; i++)
        {
           // lines.Add(Console.ReadLine());
             lines.Add(inputLines[i]);
        }
         Debug.Log(lines.Count);
        string evenText = "";
        string oddText = "";
        foreach (string line in lines)
        {
            for (int i = 0; i < line.Length; i++)
            {
                foreach (int e in even)
                {
                    if (i.ToString().EndsWith(e.ToString()))
                    {
                         evenText += line[i];
                       // Console.Write(line[i]);
                    }
                }

                foreach (int o in odd)
                {
                    if (i.ToString().EndsWith(o.ToString()))
                    {
                         oddText += line[i];
                       // Console.Write(line[i]);
                    }
                }
            }
           // Console.WriteLine();
            Debug.Log($"{evenText} {oddText}");
             evenText = "";
              oddText = "";
        }
    }


}
