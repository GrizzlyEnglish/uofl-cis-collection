/// <summary>
/// 
/// Lab 6 - CIS 199-75
/// Id C1695
/// Due: March 12, 2017
/// Output 4 patterns based on instructions.
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Draw the four patterns
            DrawTriangle(true, true, "Pattern A");
            DrawTriangle(true, false, "Pattern B");
            DrawTriangle(false, false, "Pattern C");
            DrawTriangle(false, true, "Pattern D");
        }

        /// <summary>
        /// Draw a triangle in the console based on a few variables
        /// </summary>
        /// <param name="leftToRight">This defines the side of the straight edge</param>
        /// <param name="topToBottom">This defines if we increase or decrease the character</param>
        /// <param name="patternName">The name of this particular pattern</param>
        /// <param name="lineLength">The length of the lines characters</param>
        /// <param name="char1">Whatever character you want to show default: *</param>
        public static void DrawTriangle(bool leftToRight, bool topToBottom, string patternName, int lineLength = 10, char char1 = '*')
        {
            //Init stars, if we are going froom top to bottom use 1, if not use the length of the line
            //This is a ternaury experssion which is basically an inline if-else statement -> expression ? if true : if false
            int stars = topToBottom ? 1 : lineLength;

            //Write out the pattern name for the user
            Console.WriteLine(patternName);

            for (int i = 0; i < lineLength; i++)
            {
                //Create line, repeating the character based on the value we have
                string line = new string(char1, stars);
                
                //Write the line, if we are going right to left we need to pad the string with spaces
                Console.WriteLine(leftToRight ? line : line.PadLeft(lineLength, ' '));
                
                //Incriment stars, if we are going top to bottom we decrease if we are going bottom to top we increase
                stars += topToBottom ? 1 : -1;
            }
        }

    }
}
