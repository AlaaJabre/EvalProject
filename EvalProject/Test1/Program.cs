using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var example1 = new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            Console.WriteLine(p.Challenge(example1));
            var example2 = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };
            Console.WriteLine(p.Challenge(example2));

            ////To be honest while I am aware of what O(n) and O(n^2) are, I never studied this big o notation stuff 
            //// but I will give it a try
            //// Since I have 4 normal loops and one nested it should be O(n^2+4n)
            ////Not good I know, but this is what I was able to come up with in the past 30 minutes ¯\_(ツ)_/¯
            ////I wrote a simpler version using linq, I was not sure if linq is permissible but here it is anyway             
            Console.WriteLine(p.ChallengeLinq(1, 2, 1, 5, 5, 3, 3, 3, 4));
            Console.WriteLine(p.ChallengeLinq(1, 6, 1, 2, 6, 1, 6, 6));
        }

        public int Challenge(int[] input)
        {
            // calculating each array item frequency
            int[] frequencies = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int count = 0;
                for (int ii = 0; ii < input.Length; ii++)
                {
                    if (input[i] == input[ii])
                        count++;
                }
                frequencies[i] = count;
            }

            int max = 0;
            for (int i = 0; i < frequencies.Length; i++)
            {
                if (frequencies[i] > max)
                    max = frequencies[i];
            }

            // Filtering the array
            int arraySize = 0;
            for (int i = 0; i < frequencies.Length; i++)
            {
                if (frequencies[i] >= max - 1)
                    arraySize++;
            }

            int[] newArray = new int[arraySize];

            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (frequencies[i] >= max - 1)
                {
                    newArray[j] = input[i];
                    j++;
                }
            }

            //calculating sum of biggest neighbors
            int sum = 0;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                if (newArray[i] + newArray[i + 1] > sum)
                    sum = newArray[i] + newArray[i + 1];
            }

            return sum;
        }

        public int ChallengeLinq(params int[] input)
        {
            var frequencies = input.GroupBy(c => c).Select(c => new { Value = c.Key, Frequency = c.Count() }).ToList();
            var max = frequencies.Max(c => c.Frequency);
            frequencies.RemoveAll(c => c.Frequency < max - 1);

            int[] newArray = new int[frequencies.Sum(c => c.Frequency)];
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (frequencies.Exists(c => c.Value == input[i]))
                {
                    newArray[counter] = input[i];
                    counter++;
                }
            }

            int sum = 0;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                if (newArray[i] + newArray[i + 1] > sum)
                    sum = newArray[i] + newArray[i + 1];
            }

            return sum;
        }
    }
}
