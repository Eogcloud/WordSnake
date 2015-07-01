using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSnake
{
    class WordSnake
    {
        private int cursorIndex;
        private String[] words;
        private Boolean vPrint;

        public WordSnake(String[] input)
        {
            this.words = input;
            this.printSnake();
            vPrint = false;
            cursorIndex = 0;
        }

        private void PrintHorizontal(String input)
        {
            Console.CursorLeft = cursorIndex;
            Console.Write(input);
            cursorIndex = Console.CursorLeft;
            if (cursorIndex != 0) { cursorIndex--; }
            Console.Write("\n");
        }

        private void PrintVertical(String input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.CursorLeft = cursorIndex;
                Console.Write(input.ElementAt(i));
                cursorIndex = Console.CursorLeft;
                if (!(input.Length - i == 1))
                {
                    cursorIndex--;
                    Console.Write("\n");
                } 
            }
        }

        private void printSnake()
        {
            for(int i=0; i<words.Length; i++)
            { 
                if (vPrint)
                {
                    PrintVertical(words[i].Substring(1, words[i].Length -1 ));
                }
                else
                {
                   if(i==0)
                   {
                    PrintHorizontal(words[i]);
                   }
                   else
                   {
                        PrintHorizontal(words[i].Substring(1,words[i].Length -1 ));
                   }
                }
                vPrint = !vPrint;
            }
        }
    }
}
