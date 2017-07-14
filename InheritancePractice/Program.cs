using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Boat firstBoat = new Boat(2, 500, "red", 70d, .78d);
            ////firstBoat.Move();
            ////firstBoat.Move();
            ////Console.WriteLine("Boat distance traveled {0} :", firstBoat.GetDistanceTraveled());

            //Automobile firstAuto = new Automobile(4, 20, 4, 5, 500, "red", 260d);
            //firstAuto.Move();
            //firstAuto.Color = "silver";
            //Console.WriteLine("Automobile {0} :", firstAuto.GetDistanceTraveled());

            //Airplane firstAircraft = new Airplane(2, 1000, "red", 600d);
            //firstAircraft.Move();
            //firstAircraft.Move();
            //Console.WriteLine("Airplane: {0} ", firstAircraft.GetDistanceTraveled());



            //int[] inputArray = new int[] { 3, 6, -2, -5, 7, 3 };

            //Console.WriteLine(adjacentElementsProduct(inputArray));
            //int[] statues = new int[] { 6, 2, 3, 8 };
            //Console.WriteLine(makeArrayConsecutive2(statues));

            int num1 = 0;
            int num2 = 10;

            sequenceNumbers(num1, num2);
             
        }



        public static int[] sequenceNumbers(int startingNumber, int endingNumber)
        {
            int arraySize = ((endingNumber+1) - startingNumber);
            Console.WriteLine(arraySize);
            int[] tempArray = new int[arraySize];
            int num = startingNumber;
            int i = 0;
         
            
                for ( i = 0; i < tempArray.Length; i++)
                {
                if (startingNumber == 0 && i < 1)
                {
                    tempArray[i] = 0;
                    
                    Console.Write(tempArray[i]);

                    i++;
                }
                else
                {
                    tempArray[i] = startingNumber;
                    i++;
                }
                num = num + 1;
                tempArray[i] = num;
                
                Console.Write(tempArray[i]);
                }

            
            return tempArray;
        }









        public static int makeArrayConsecutive2(int[] statues)
        {
            int ctr = 0;
            Array.Sort(statues);
            Console.WriteLine(statues[0]);

            for (int i = 0; i < statues.Length - 1; i++)
                {
                Console.WriteLine(statues[i]);
                Console.WriteLine(statues[i+1]);
                if (statues[i] != statues[i+1] - 1)
                    {
                        ctr = ctr + ((statues[i+1] - statues[i])-1);
                        
                    Console.WriteLine(ctr);

                }
            }
                return ctr;
            }

        public static int adjacentElementsProduct(int[] inputArray)
        {

            int max = 0;
            int num1;
            int num2;
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write("outer loop {0} ", inputArray[i]);
                for (int j = 0; j < inputArray.Length; j++)
                {
                    Console.Write("inner loop {0} ", inputArray[j]);
                    int temp = inputArray[i] * inputArray[j];

                    if (temp > max)
                    {
                        max = temp;

                        Console.Write("Max {0} ", max);

                        num1 = inputArray[1];
                        num2 = inputArray[j];
                    }
                }
            }
            return max;
        }
        

        }
    }
            
    

