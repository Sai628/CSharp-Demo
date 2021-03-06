using System;

namespace CSharpLearning
{
    public class TestArray
    {
        public static void DoTest()
        {
            int[] n = new int[10];
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}]={1}", i, j);
            }
            // Element[0]=100
            // Element[1]=101
            // Element[2]=102
            // Element[3]=103
            // Element[4]=104
            // Element[5]=105
            // Element[6]=106
            // Element[7]=107
            // Element[8]=108
            // Element[9]=109
            
            
            int[,] array = new int[5, 2]{{0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}};
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("array[{0}, {1}]={2}", i, j, array[i, j]);
                }
            }
            // array[0, 0]=0
            // array[0, 1]=0
            // array[1, 0]=1
            // array[1, 1]=2
            // array[2, 0]=2
            // array[2, 1]=4
            // array[3, 0]=3
            // array[3, 1]=6
            // array[4, 0]=4
            // array[4, 1]=8
            
            
            int[][] array2 = new int[][] {new int[]{0, 0}, new int[]{1, 2, 3}, new int[]{2, 3}, new int[]{3, 4}, new int[]{4, 8}};
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("array[{0}][{1}]={2}", i, j, array2[i][j]);
                }
            }
            // array[0][0]=0
            // array[0][1]=0
            // array[1][0]=1
            // array[1][1]=2
            // array[2][0]=2
            // array[2][1]=3
            // array[3][0]=3
            // array[3][1]=4
            // array[4][0]=4
            // array[4][1]=8
            
            
            int[] balance = new int[]{1000, 2, 3, 17, 50};
            Console.WriteLine("平均值是:{0}", TestArray.GetAverage(balance));  // 平均值是:214
            
            int sum = TestArray.AddElements(1, 3, 5, 7, 9);
            int[] array3 = new int[]{11, 9, 7, 5, 3, 1};
            int sum3 = TestArray.AddElements(array3);
            
            Console.WriteLine("总和是:{0}", sum);  // 总和是:25
            Console.WriteLine("总和是:{0}", sum3);  // 总和是:36
            
            int[] list = new int[]{34, 72, 13, 44, 25, 30, 10};
            int[] temp = list;
            
            Console.WriteLine("原始数组:");
            foreach (int i in list)
            {
                Console.Write(i + " ");  // 34 72 13 44 25 30 10 
            }
            Console.WriteLine();
            
            Array.Reverse(temp);
            Console.WriteLine("逆转数组:");
            foreach (int i in temp)
            {
                Console.Write(i + " ");  // 10 30 25 44 13 72 34 
            }
            Console.WriteLine();
            
            Array.Sort(list);
            Console.WriteLine("排序数组:");
            foreach (int i in list)
            {
                Console.Write(i + " ");  // 10 13 25 30 34 44 72 
            }
            Console.WriteLine();
        }
        
        
        public static double GetAverage(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            
            return sum / array.Length;
        }


        public static int AddElements(params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            
            return sum;
        }
    }
}