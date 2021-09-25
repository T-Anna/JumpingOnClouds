using System;
using System.Collections.Generic;

namespace JumpingOnClouds
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example input: { 0, 0, 1, 0, 0, 0, 0 }");
            Console.WriteLine("Minimum number of jumps to win: " + JumpingOnClouds(new List<int> { 0, 0, 1, 0, 0, 0, 0 }));
        }

        public static int JumpingOnClouds(List<int> clouds)
        {
            int currentPosition = 0;
            int numberOfJumps = 0;

            while (currentPosition < clouds.Count-1)
            {
                currentPosition = JumpToNextPosition(clouds, currentPosition);
                numberOfJumps++;
            }
            return numberOfJumps;
        }

        private static int JumpToNextPosition(List<int> clouds, int currentPosition)
        {
            if (IsLongJumpPossible(currentPosition, clouds))
            {
                currentPosition += 2;
            }
            else
            {
                currentPosition += 1;
            }

            return currentPosition;
        }

        private static bool IsLongJumpPossible(int currentPosition, List<int> clouds)
        {
            int nextPosition = currentPosition + 2;

            if (nextPosition >= clouds.Count)   
            {                                          
                return false; 
            }
            return IsCumulus(clouds[nextPosition]);       
        }

        private static bool IsCumulus(int cloud)
        {
            return cloud == 0;
        }
    }
}
