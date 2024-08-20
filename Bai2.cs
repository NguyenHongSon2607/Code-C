using System;

class Program
{
    static void Main()
    {
        string[][] products = new string[3][];

        products[0] = new string[] { "Tivi", "Tu lanh", "Tu dong", "Tu mat"}; // hàng gia dụng 
        products[1] = new string[] { "MSI", "Dell", "SamSung"}; // máy tính 
        products[2] = new string[] { "Iphone", "Samsung", "Oppo", "Xiaomi"}; // điện thoại

        // a. In thông tin của mảng 
        Console.WriteLine("Thong tin mang Jagged Array: ");
        for (int i = 0; i < products.Length; i++)
        {
            Console.Write($"Loai san pham {i + 1}: ");
            for (int j = 0; j < products[i].Length; j++)
            {
                Console.Write(products[i][j] + " ");
            }
            Console.WriteLine();
        }

        // b. Sắp xếp từng dòng của mảng
        for (int i = 0; i < products.Length; i++)
        {
            Array.Sort(products[i]);
        }

        Console.WriteLine("\n Mang Jagged sau khi sap xep: ");
        for (int i = 0; i < products.Length; i++)
        {
            Console.Write($"Loai san pham {i + 1}: ");
            for (int j = 0; j < products[i].Length; j++)
            {
                Console.Write(products[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Nhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}
