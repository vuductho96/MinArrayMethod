using System;
using System.Linq;// thu viện cho phep sử dụng có sẵn Min và Max

namespace ChuyenDoiNhietDo
{
    class Program

    {       
        public static void Main(String[] args)
        {
            Console.WriteLine("Moi nhap phan tu cua mang");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
           
            for (int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine("Nhap vao phan tu thu {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        
            int min = arr.Min();// giá trị tìm thấy  lưu  vào trong biến main
            Console.WriteLine("The smallest element in the array is: " + min);
        }


    }

       

    }
