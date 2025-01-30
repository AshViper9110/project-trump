using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_trump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumCount = 4;
            int outputNumCount = 0;
            int numCount = 0;
            bool isInput = false;
            bool isEnd = false;
            var inputNum = new int[inputNumCount];
            while (!isEnd)
            {
                outputNumCount = 0;
                numCount = 0;
                for (int i = 0; i < inputNumCount; i++)
                {
                    while (!isInput)
                    {
                        Console.WriteLine($"{i + 1}枚目の1～4の数字を入力してください");
                        isInput = int.TryParse(Console.ReadLine(), out inputNum[i]);
                        if (inputNum[i] < 1 || inputNum[i] > 4)
                        {
                            isInput = false;
                        }
                    }
                    isInput = false;
                }
                for (int i = 0; i < inputNumCount; i++)
                {
                    numCount = 0;
                    for (int k = 0; k < inputNumCount; k++)
                    {
                        if (inputNum[i] == inputNum[k])
                        {
                            numCount++;
                        }
                    }
                    if (outputNumCount < numCount)
                    {
                        outputNumCount = numCount;
                    }
                }

                switch (outputNumCount)
                {
                    case 1:
                        Console.WriteLine("ノーペア");
                        break;
                    case 2:
                        Console.WriteLine("ツーペア");
                        break;
                    case 3:
                        Console.WriteLine("スリーカード");
                        break;
                    case 4:
                        Console.WriteLine("フォーカード");
                        break;
                }
                Console.WriteLine("終了しますか？[y/n]");
                string end = Console.ReadLine();
                if (end == "Y" || end == "y")
                {
                    isEnd = true;
                }
                else
                {
                    isEnd = false;
                }
            }       
        }
    }
}
