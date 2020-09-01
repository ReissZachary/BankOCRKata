using System;
using System.Collections.Generic;
using System.Linq;

namespace BankOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for each 3x3 array take each cell(number)
            put in single array
            convert array into string
            compare string to static values
            concat value into parsed accout number
            */
            string input = @" _  _     _  _     _  _
                            | _| _||_||_ |_   | _| _|
                            ||_  _|  | _||_|  ||_  _|
                                                     ";

            // var newString = input.Split(Environment.NewLine);
            // var splitString = string.Join(",", newString);
            // Console.WriteLine(newString[0]);            
            Console.WriteLine(parseAcctNumber(input));
        }

        
        public static char[] parseAcctNumber(string input){
            //input is first line of character
            var source = input.ToCharArray();
            
            char[] firstNumber = new char[12];            

            char[] secondNumber = new char[12];

            char[] thirdNumber = new char[12];

            char[] fourthNumber = new char[12];

            char[] fifthNumber = new char[12];

            char[] sixthNumber = new char[12];

            char[] seventhNumber = new char[12];

            char[] eighthNumber = new char[12];

            char[] ninthNumber = new char[12];

            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 27; j+=3){

                    Array.Copy(source, 0, firstNumber, j, 3);
                    Array.Copy(source, 3, secondNumber, j, 3);
                    Array.Copy(source, 6, thirdNumber, j, 3);
                    Array.Copy(source, 9, fourthNumber, j, 3);
                    Array.Copy(source, 12, fifthNumber, j, 3);
                    Array.Copy(source, 15, sixthNumber, j, 3);
                    Array.Copy(source, 18, seventhNumber, j, 3);
                    Array.Copy(source, 21, eighthNumber, j, 3);
                    Array.Copy(source, 24, ninthNumber, j, 3);

                }  
                return firstNumber;             
            }
            return firstNumber;
        }
    }
}
