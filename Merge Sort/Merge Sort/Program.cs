using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Mảng trước khi sắp xếp:");
        PrintArray(array);

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("Mảng sau khi sắp xếp:");
        PrintArray(array);
    }

    // Hàm sắp xếp mảng bằng thuật toán Merge Sort
    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Chia mảng thành hai nửa
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            // Hợp nhất hai nửa đã sắp xếp
            Merge(array, left, mid, right);
        }
    }

    // Hàm hợp nhất hai nửa của mảng đã sắp xếp
    static void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Tạo các mảng tạm
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Sao chép dữ liệu vào các mảng tạm
        Array.Copy(array, left, L, 0, n1);
        Array.Copy(array, mid + 1, R, 0, n2);

        // Hợp nhất các mảng tạm vào mảng chính
        int i = 0, j = 0;
        int k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                array[k] = L[i];
                i++;
            }
            else
            {
                array[k] = R[j];
                j++;
            }
            k++;
        }

        // Sao chép phần còn lại của mảng L nếu có
        while (i < n1)
        {
            array[k] = L[i];
            i++;
            k++;
        }

        // Sao chép phần còn lại của mảng R nếu có
        while (j < n2)
        {
            array[k] = R[j];
            j++;
            k++;
        }
    }

    // Hàm in mảng ra màn hình
    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
