using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_GU1_W04_B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int so;
            int[] mang;

            do
            {
                Console.Write("Nhap gia tri kich thuoc mang: ");
                so = Int32.Parse(Console.ReadLine());
                if (so > 10)
                {
                    Console.WriteLine("So khong duoc vuot qua 10");
                }
            }
            while (so > 10);

            mang = new int[so];
            int i = 0;
            while (i < mang.Length)
            {
                Console.Write("Nhap gia tri thu " + (i + 1) + " : ");
                mang[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            
            Console.WriteLine("Cac gia tri da nhap: ");
            for (int j = 0; j < mang.Length; j++)
            {
                Console.Write(mang[j] + "  ");
            }
            Console.WriteLine();


            int solonnhat = mang[0];
            int vitri = 1;
            for (int j = 0; j < mang.Length; j++)
            {
                if (mang[j] > solonnhat)
                {
                    solonnhat = mang[j];
                    vitri = j + 1;
                }

            }
            Console.WriteLine("Gia tri lon nhat trong danh sach mang la " + solonnhat + ", o vi tri thu " + vitri);

            Console.ReadKey();
        }
    }
}
