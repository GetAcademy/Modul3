using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool SortedBool()
            {
                string[] Arguments = args;
                if(Arguments.Length > 0 && SortTools.IsSorted(Arguments))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine("is this array Sorted?");
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.WriteLine();
            Console.WriteLine(SortedBool());
        }

    }
    public static class SortTools
    {
        public static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSorted(string[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1].CompareTo(arr[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSortedDescending(int[] arr)
        {
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSortedDescending(string[] arr)
        {
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i].CompareTo(arr[i + 1]) < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
