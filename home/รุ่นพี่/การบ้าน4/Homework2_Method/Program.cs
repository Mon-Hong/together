using System;

namespace Homework2_Method
{
    class Program
    {
        static string halfDNASequence ;
        static void Main(string[] args)
        {
            char synthetic, next;

            do
            {

                Console.Write("Input half of the DNA chain : ");
                halfDNASequence = Console.ReadLine();

                IsValidSequence(halfDNASequence);

                if (IsValidSequence(halfDNASequence) == true)
                {
                    Console.WriteLine("Current half DNA sequence :  {0}", halfDNASequence);
                    do
                    {
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        synthetic = char.Parse(Console.ReadLine());

                        if (synthetic != 'Y' && synthetic != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                        }

                    } while (synthetic != 'Y' && synthetic != 'N');

                    if (synthetic == 'Y')
                    {
                        ReplicateSeqeunce(halfDNASequence);

                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(halfDNASequence));
                    }
                }


                if (IsValidSequence(halfDNASequence) == false)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }


                do
                {
                    Console.Write("Do you want to process another sequence ? (Y / N) : ");
                    next = char.Parse(Console.ReadLine());

                    if (next != 'Y' && next != 'N')
                    {
                        Console.WriteLine("Please input Y or N.");
                    }

                } while (next != 'Y' && next != 'N');

            } while (next == 'Y');

        }




        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;

        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }



    }
}
