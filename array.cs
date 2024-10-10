using System;
using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace inter
{
    public class Array
    {
        private int[] items;
        private int count = 0;
        public Array(int length)
        {
            items = new int[length];
        }
        public void insert(int i)
        {
            if (count == items.Length)
            {
                int[] newitem = new int[count * 2];
                for (int j = 0; j < items.Length; j++)
                {
                    newitem[j] = items[j];
                }
                items = newitem;
            }
            items[count] = i;
            count++;
        }
        public void revove(int index)
        {
            if (index >= count)
            {
                Console.WriteLine("index out of range");
            }
            else
            {
                for (int j = index; j < count - 1; j++)
                {
                    items[j] = items[j + 1];
                }
                count--;
            }
        }
        public int indexof(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (item == items[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public int large()
        {
            int largenum = items[0];
            for (int i = 1; i < count; i++)
            {
                if (items[i] > largenum)
                {
                    largenum = items[i];
                }
            }
            return largenum;
        }
        public void reverse()
        {
            int[] newitem = new int[items.Length * 2];
            int j = 0;
            for (int i = count - 1; i >= 0; i--)
            {
                newitem[j] = items[i];
                j++;
            }
            items = newitem;
        }
        public void insertat(int index, int item)
        {
            int[] newitem = new int[items.Length * 2];
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    newitem[j] = items[i];
                    j++;
                }
                else
                {
                    newitem[j] = item;
                    j++;
                    count++;
                    i--;
                    index = -1;
                }
            }
            items = newitem;
        }
        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Array array = new Array(length: 3);
            array.insert(0);
            array.insert(1);
            array.insert(2);
            array.insert(3);
            array.insert(4);
            array.insert(5);
            array.insert(6);
            array.insert(7);
            array.insert(8);
            array.insert(9);
            array.insert(10);
            array.insertat(4, 100);
            array.insertat(5, 200);
            array.print();
            Console.WriteLine("large num  " + array.large());

        }
    }
}