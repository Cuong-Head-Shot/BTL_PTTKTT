using System;
using System.Text;
class Program
{
    static void Main()
    {
     
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int key = 7; 
        Console.OutputEncoding = Encoding.UTF8;

        bool found = BinarySearch(arr, key);
        if (found)
        {
            Console.WriteLine($"Phần tử {key} đã được tìm thấy trong mảng.");
        }
        else
        {
            Console.WriteLine($"Phần tử {key} không có trong mảng.");
            
        }
        Console.ReadLine();
    }

    static bool BinarySearch(int[] arr, int key)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

         
            if (arr[mid] == key)
            {
                return true;
            }
            else if (arr[mid] < key)
            {
                left = mid + 1; 
            }
            else
            {
                right = mid - 1; 
            }
        }

        return false; 
        
}
