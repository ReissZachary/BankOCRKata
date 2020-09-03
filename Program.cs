using System;
using System.Collections.Generic;
using System.Linq;


namespace BankOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"    _  _     _  _     _  _
  | _| _||_||_ |_   | _| _|
  ||_  _|  | _||_|  ||_  _|
                           ";             

            string[] lines = ReadInFile();
            foreach(var line in lines) {
              Console.WriteLine(buildAccountNumber(ParseAccountNumber(line)));
            }
            //ParseAccountNumber(input);
            
        }

        private static char[][] ParseAccountNumber(string input){

            
            var newString = input.Split("\n")
            .ToList();
            
            char[] lineOne = newString[0].ToCharArray();         
            char[] lineTwo = newString[1].ToCharArray();         
            char[] lineThree = newString[2].ToCharArray();

            char[][] lines = new char [3][]
            {
                lineOne,
                lineTwo,
                lineThree
            };

            char[][] acctNumberArray = new char [9][];

            char[] firstNumber = new char[12];
            char[] secondNumber = new char[12];
            char[] thirdNumber = new char[12];
            char[] fourthNumber = new char[12];
            char[] fifthNumber = new char[12];
            char[] sixthNumber = new char[12];
            char[] seventhNumber = new char[12];
            char[] eighthNumber = new char[12];
            char[] ninthNumber = new char[12];

            int k = 0;
            for (int i = 0; i < 3; i++) {                
                for(int j = 0; j < 3; j++) {
                        firstNumber[k] = lines[i][j];
                        secondNumber[k] = lines[i][3 + j];
                        thirdNumber[k] = lines[i][6 + j];
                        fourthNumber[k] = lines[i][9 + j];
                        fifthNumber[k] = lines[i][12 + j];
                        sixthNumber[k] = lines[i][15 + j];
                        seventhNumber[k] = lines[i][18 + j];
                        eighthNumber[k] = lines[i][21 + j];

                        //ninthNumber[k] = lines[i][24 + j];
                        k++;
                }
            }

            acctNumberArray[0] = firstNumber;
            acctNumberArray[1] = secondNumber;
            acctNumberArray[2] = thirdNumber;
            acctNumberArray[3] = fourthNumber;
            acctNumberArray[4] = fifthNumber;
            acctNumberArray[5] = sixthNumber;
            acctNumberArray[6] = seventhNumber;
            acctNumberArray[7] = eighthNumber;
            acctNumberArray[8] = ninthNumber;


            // string test = new string(firstNumber);
            // string trim = String.Concat(test.Where(c => !Char.IsWhiteSpace(c)));  

            // for(int i = 0; i < trim.Length; i++){
            //     Console.Write(trim[i]);
            // }
            // for(int i = 0; i < Constants.ONE.Length; i++){
            //     Console.Write(Constants.ONE[i]);
            // }
            // Console.WriteLine(firstNumber[5].CompareTo(Constants.ONE[5]));
            // Console.WriteLine(test.ToString().Replace(" ", "0"));
            // Console.WriteLine(Constants.ONE.Replace(" ", "0"));
            // Console.WriteLine(test.CompareTo(Constants.));
            return acctNumberArray;
        }

        public static string buildAccountNumber(char[][] acctNumArray){
            string acctNum = "";
            foreach(var number in acctNumArray){                
                string numberString = new string(number);
                if(numberString.CompareTo(Constants.ZERO) == 0){
                    acctNum.Concat("0");
                }
                else if(numberString.CompareTo(Constants.ONE) == 0){
                    acctNum.Concat("1");
                }
                else if(numberString.CompareTo(Constants.TWO) == 0){
                    acctNum.Concat("2");
                }
                else if(numberString.CompareTo(Constants.THREE) == 0){
                    acctNum.Concat("3");
                }
                else if(numberString.CompareTo(Constants.FOUR) == 0){
                    acctNum.Concat("4");
                }
                else if(numberString.CompareTo(Constants.FIVE) == 0){
                    acctNum.Concat("5");
                }
                else if(numberString.CompareTo(Constants.SIX) == 0){
                    acctNum.Concat("6");
                }
                else if(numberString.CompareTo(Constants.SEVEN) == 0){
                    acctNum.Concat("7");
                }
                else if(numberString.CompareTo(Constants.EIGHT) == 0){
                    acctNum.Concat("8");
                }
                else if(numberString.CompareTo(Constants.NINE) == 0){
                    acctNum.Concat("9");
                }                            
            }
            return acctNum;
        }

        public static string[] ReadInFile() {
            
            string[] lines = System.IO.File.ReadAllLines(@"BankOrcStory1_SampleInput.txt");
            List<string> returnLineArray = new List<string>();
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
            Console.WriteLine(returnLineArray);
            
            for(int i = 0; i < lines.Length; i+=4) {
                if(i+4 <= lines.Length){
                    List<string> newLinesArray = new List<string>();
                    newLinesArray.Add((lines[i] + lines[i+1] + lines[i+2] +lines[i+3]));
                    returnLineArray.Concat(newLinesArray.ToArray());
                    Console.WriteLine($"{i}: {returnLineArray.ToString()}");
                }
                else
                {
                    Console.WriteLine("You have entered the twilight zone");
                    break;
                }
                
            } 
            return returnLineArray.ToArray();
        }
    }
}

