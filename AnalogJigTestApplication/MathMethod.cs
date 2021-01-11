using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogJigTestApplication
{
    class MathMethod
    {
        public static int ROUND(double a)
        {
            int result;
            result = ((a < 0) ? (int)(a - 0.5) : (int)(a + 0.5));
            return result;
        }

        public static int POW(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int MIN(int[] data)
        {
            int min = data[0];
            for(int i = 0; i < data.Count(); i++)
            {
                if (min > data[i])
                {
                    min = data[i];
                }
            }

            return min;
        }

        public static int MAX(int[] data)
        {
            int max = data[0];
            for (int i = 0; i < data.Count(); i++)
            {
                if (max < data[i])
                {
                    max = data[i];
                }
            }

            return max;
        }

        public static double deg2rad(double a)
        {
            return a * (Math.PI / 180.0);
        }

        public static double HW_FORMAT(double data, char sign, int sizeOfInt, int sizeOfFraction)
        {
            double result;

            int temp = ROUND(data * (int)(Math.Pow(2, (double)sizeOfFraction)));

            int sOverFlowData = POW(2, sizeOfInt + sizeOfFraction - 1) - 1;
            int sUnderFlowData = -POW(2, sizeOfInt + sizeOfFraction - 1);
            int uOverFlowData = POW(2, sizeOfInt + sizeOfFraction) - 1;
            int uUnderFlowData = 0;

            if (sign == 's')
            {
                if (temp > sOverFlowData)
                {
                    Console.WriteLine("Data is Over Flow!!!");
                    result = sOverFlowData;
                }
                else if (temp < sUnderFlowData)
                {
                    Console.WriteLine("Data is Under Flow!!!");
                    result = sUnderFlowData;
                }
                else
                {
                    result = temp;
                }
            }
            else
            {
                if (temp > uOverFlowData)
                {
                    Console.WriteLine("Data is Over Flow!!!");
                    result = uOverFlowData;
                }
                else if (temp < uUnderFlowData)
                {
                    Console.WriteLine("Data is Under Flow!!!");
                    result = uUnderFlowData;
                }
                else
                {
                    result = temp;
                }
            }

            result = result / POW(2, sizeOfFraction);

            return result;
        }

        public static int RandomInt_16To10(Random random)
        {
            return random.Next(1, 65536);
        }


        public static double[] HW_FORMAT(double[] data, char sign, int sizeOfInt, int sizeOfFraction)
        {
            double[] result = new double[data.Count()];

            int sOverFlowData = POW(2, sizeOfInt + sizeOfFraction - 1) - 1;
            int sUnderFlowData = -POW(2, sizeOfInt + sizeOfFraction - 1);
            int uOverFlowData = POW(2, sizeOfInt + sizeOfFraction) - 1;
            int uUnderFlowData = 0;

            for (int i = 0; i < data.Count(); i++)
            {
                int temp = ROUND(data[i] * (int)(Math.Pow(2, (double)sizeOfFraction)));


                if (sign == 's')
                {
                    if (temp > sOverFlowData)
                    {
                        Console.WriteLine("Data is Over Flow!!!");
                        result[i] = sOverFlowData;
                    }
                    else if (temp < sUnderFlowData)
                    {
                        Console.WriteLine("Data is Under Flow!!!");
                        result[i] = sUnderFlowData;
                    }
                    else
                    {
                        result[i] = temp;
                    }
                }
                else
                {
                    if (temp > uOverFlowData)
                    {
                        Console.WriteLine("Data is Over Flow!!!");
                        result[i] = uOverFlowData;
                    }
                    else if (temp < uUnderFlowData)
                    {
                        Console.WriteLine("Data is Under Flow!!!");
                        result[i] = uUnderFlowData;
                    }
                    else
                    {
                        result[i] = temp;
                    }
                }
                result[i] = result[i] / POW(2, sizeOfFraction);
            }
            return result;
        }


        ////cordinates (xi) where i = 0,~,n
        ////input will be n by 3 metrix {{xi^2,xi,1} ...}, MakeSquareMetrix make n by 3 to 3 by 3 metrix
        //public double[,] MakeSquareMetrix(double[] input)
        //{
        //    //행렬 초기화
        //    double[,] result = new double[3, 3] { { 0, 0, 0 },{ 0, 0, 0 },{ 0, 0, 0 } };

        //    for (int i = 0; i < 8; i++)
        //    {
        //        result[0, 0] += Math.Pow(input[i], 4);
        //        result[0, 1] += Math.Pow(input[i], 3);
        //        result[0, 2] += Math.Pow(input[i], 2);
        //        result[1, 2] += input[i];
        //    }

        //    result[1, 0] = result[0, 1];
        //    result[1, 1] = result[0, 2];
        //    result[2, 0] = result[1, 1];
        //    result[2, 1] = result[1, 2];
        //    result[2, 2] = 8;

        //    return result;
        //}


        ////3 by 3 metrix inverse function
        //public double[,] InverseMetrix(double[,] input)
        //{
        //    if (input.GetLength(0) != input.GetLength(1))
        //    {
        //        return new double[,] { { 0 } };
        //    }
                
        //    double determinant = input[1, 1]*(input[2, 2]* input[3, 3] - input[2, 3]* input[3, 2]) - input[1, 2] * (input[2, 1]* input[3, 3]- input[2, 3]* input[3, 1])+ input[1, 3]*(input[2, 1]* input[3, 2]- input[2, 2]* input[3, 1]);

        //    double[,] result = { { input[2,2]* input[3, 3]- input[3, 2]* input[2, 3], -input[1, 2] * input[3, 3] + input[3, 2] * input[1, 3], input[1, 2] * input[2, 3] - input[2, 2] * input[1, 3] },
        //                         { -input[2,1]* input[3, 3]+ input[3, 1]* input[2, 3], input[1, 1] * input[3, 3] - input[3, 1] * input[1, 3], -input[1, 1] * input[2, 3] + input[2, 1] * input[1, 3] },
        //                         { input[2,1]* input[3, 2]- input[3, 1]* input[2, 2], -input[1, 1] * input[3, 2] + input[3, 1] * input[1, 2], input[1, 1] * input[2, 2] - input[2, 1] * input[1, 2] } };

        //    for(int i=0; i<3; i++)
        //    {
        //        for(int j = 0; j < 3; j++)
        //        {
        //            result[i, j] = result[i, j] / determinant;
        //        }
        //    }

        //    return result;
        //}
    }
}
