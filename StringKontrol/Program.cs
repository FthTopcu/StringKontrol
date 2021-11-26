using System;
using System.Collections.Generic;

namespace StringKontrol
{
    class Program
    {
        static void Main(string[] args)
        {

            string INPUT = ("nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon" +
                " tsilanruoj (and) laicos .tsivitca ((A) reenoip(of) laicremmoc noitcif(and)" +
                " naciremA ,senizagam(he) saw eno(of) (the)tsrif (American) srohtua(to) emoceb(an)" +
                " lanoitanretni ytirbelec (and) nrae a egral enutrof (from)).gnitirw ");
            //string INPUT = ("nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon" +
            //    " tsilanruoj (and) laicos .tsivitca (A) reenoip(of) laicremmoc noitcif(and)" +
            //    " naciremA ,senizagam(he) saw eno(of) (the)tsrif (American) srohtua(to) emoceb(an)" +
            //    " lanoitanretni ytirbelec (and) nrae a egral enutrof (from).gnitirw ");
            Console.WriteLine(INPUT);

            
            INPUT = INPUT.Replace("((", "( (");
            INPUT = INPUT.Replace("))", ") )");
            //INPUT = INPUT.Replace("(", " (");
            //INPUT = INPUT.Replace(")", " )");
            string[] kelimeler = INPUT.Split(" ");
            string tempString = "";
            string kelime = "";
            string correct_answer = "";
            Console.WriteLine(INPUT);
            Console.WriteLine();
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if ((kelimeler[i].Contains('(') && kelimeler[i].Contains(')')))
                {
                    kelimeler[i] = kelimeler[i].Replace("(", " (");
                    kelimeler[i] = kelimeler[i].Replace(")", ") ");
                }
            }
            for (int i = 0; i < kelimeler.Length; i++)
            {
                tempString = tempString + " " + kelimeler[i];
            }
            Array.Clear(kelimeler,0,kelimeler.Length);
            kelimeler = tempString.Split(" ");
            for (int i = 0; i < kelimeler.Length; i++)
            {
              
                if ((kelimeler[i].Contains('(') && kelimeler[i].Contains(')')) && kelimeler[i].Length > 1 )
                {
                    kelime = kelimeler[i];
                    //kelime = kelimeler[i].Replace("(", " ");
                    //kelime = kelime.Replace(")", " ");
                    correct_answer = correct_answer + " " + kelime;
                    //kelimeler[i] = kelimeler[i].Remove(kelimeler[i].Length);
                }
                else
                {
                    string tempWord = "";
                    for (int k = kelimeler[i].Length - 1; k >= 0; k--)
                    {
                        tempWord += (kelimeler[i])[k];
                    }
                    correct_answer = string.Join(" ",correct_answer,tempWord);
                   
                }
                
            }
            Array.Clear(kelimeler, 0, kelimeler.Length);
            kelimeler = correct_answer.Split(" ");
            correct_answer = "";
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if(kelimeler[i].Contains("(")&& kelimeler[i].Contains(")"))
                {
                    kelimeler[i]=kelimeler[i].Replace("(", "").Replace(")", "");
                    
                }
                correct_answer = string.Join(" ", correct_answer, kelimeler[i]);
            }
            foreach (var item in kelimeler)
            {
                if (!item.Contains(' '))
                { Console.Write(item + " "); }
            }

           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine(correct_answer);
            // CORRECT_ANSWER = "John Griffith London was an American novelist,
            // journalist, and social activist. (A pioneer of commercial fiction and
            // American magazines, he was one of the first American authors to become an
            // international celebrity and earn a large fortune from writing.)"
            Console.ReadLine();
        }
    }
}
//ülakat Sorusu 1
//----------------

//'''
//You have a text that some of the words in reverse order.
//The text also contains some words in the correct order,
//and they are wrapped in parenthesis.
//Write a function fixes all of the words and,
//remove the parenthesis that is used for marking the correct words.

//Your function should return the same text defined in the constant 
//CORRECT_ANSWER
//'''


//INPUT = ("nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon
//         , tsilanruoj (and) laicos .tsivitca ((A) reenoip(of) laicremmoc
//         noitcif(and) naciremA ,senizagam(he) saw eno(of) (the)tsrif
//      (American) srohtua(to) emoceb(an) lanoitanretni ytirbelec
//    (and) nrae a egral enutrof (from)).gnitirw ")

//CORRECT_ANSWER = "John Griffith London was an American novelist, journalist, and social activist. (A pioneer of commercial fiction and American magazines, he was one of the first American authors to become an international celebrity and earn a large fortune from writing.)"

//Mülakat Sorusu 2
//----------------

//'''
//Problem:
//t and z are strings consist of lowercase English letters.

//Find all substrings for t, and return the maximum value of [len(substring) x [how many times the substring occurs in z] ]

//Example:
//t = acldm1labcdhsnd
//z = shabcdacasklksjabcdfueuabcdfhsndsabcdmdabcdfa

//Solution:
//abcd is a substring of t, and it occurs 5 times in Z, len(abcd) x 5 = 20 is the solution

//'''
