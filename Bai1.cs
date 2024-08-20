using System;

class Bai1 {
    static void Main() {
        string[] SinhVien = {
            "Nguyen Van Nam",
            "Tran Van Binh",
            "Pham Quyet",
            "Bui Binh"
        };

        Console.WriteLine("Danh sach sinh vien ban dau: ");
        DanhSachSV(SinhVien);

        // Cach 1: Dung For
        SapXepSVF(SinhVien);
        Console.WriteLine("\nDanh sach sinh vien sau khi sap xep bang for:");
        DanhSachSV(SinhVien);

        // Cach 2: Dung System.Array   
        Array.Sort(SinhVien);
        Console.WriteLine("\nDanh sach sinh vien sau khi sap xep bang System.Array:");

        // Thay doi kich co mang; bo sung n +1;
        Array.Resize(ref SinhVien, SinhVien.Length + 1);
        SinhVien[SinhVien.Length - 1] = "Nguyen Hong Son";

        // Sap xep lai mang sau khi bo sung
        Array.Sort(SinhVien);
        Console.WriteLine("\nDanh sach sinh vien sau khi bo sung va sap xep lai: ");
        DanhSachSV(SinhVien);
    }

    static void DanhSachSV(string[] sinhVienArray) {
        for (int i = 0; i < sinhVienArray.Length; i++) {
            Console.WriteLine($"{i + 1} . {sinhVienArray[i]}");
        }
    }

    static void SapXepSVF(string[] sinhVienArray) {
        for (int i = 0; i  <sinhVienArray.Length - 1; i++) {
            for (int j = i + 1; j < sinhVienArray.Length; j++) {
                if (string.Compare(sinhVienArray[i], sinhVienArray[j]) > 0) {
                    string temp = sinhVienArray[i];
                    sinhVienArray[i] = sinhVienArray[j];
                    sinhVienArray[j] = temp;
                }
            }
        }
    }
}