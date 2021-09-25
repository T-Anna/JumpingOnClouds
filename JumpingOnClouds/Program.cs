using System;
using System.Collections.Generic;

namespace JumpingOnClouds
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example input: { 0, 0, 1, 0, 0, 0, 0 }");
            Console.WriteLine("Minimum number of jumps to win: "+JumpingOnClouds(new List<int> { 0, 0, 1, 0, 0, 0, 0 }));
        }

        public static int JumpingOnClouds(List<int> clouds)
        {
            int currentPosition = 0;
            int numberOfJumps = 0;

            while (currentPosition < clouds.Count-1)
            {
                if (IsLongJumpPossible(currentPosition, clouds)) 
                {
                    currentPosition += 2;
                }
                else
                {
                    currentPosition += 1;
                }
                numberOfJumps++;
            }
            return numberOfJumps;
        }

        private static bool IsLongJumpPossible(int currentPosition, List<int> clouds)
        {
            if (currentPosition + 2 >= clouds.Count)   
            {                                          
                return false; 
            }
            return IsCumulus(clouds[currentPosition + 2]);       
        }

        private static bool IsCumulus(int cloud)
        {
            return cloud == 0;
        }
    }
}
