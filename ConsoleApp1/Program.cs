using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct LinhKien
        {
            public string MSLK;
            public string Ten;
            public string LoaiLK;
            public decimal GiaNhap;
            public int TonKho;

            public LinhKien(string mslk, string ten, string loailk, decimal gianhap, int tk)
            {
                MSLK = mslk;
                Ten = ten;
                LoaiLK = loailk;
                GiaNhap = gianhap;
                TonKho = tk;
            }
            public void HienThi()
            {
                Console.WriteLine($"{MSLK,-15} | {Ten,-50} | {LoaiLK,-28} | {(GiaNhap.ToString("N0").Replace(',', '.')),20} đ | {TonKho,13}");
            }
        }
        // STRUCT KHỞI TẠO SORTEDLIST LƯU CÁC LOẠI LINH KIỆN 
        public struct DanhSach
        {
            public SortedList<string, LinhKien> list;
            public void Initiallize()
            {
                list = new SortedList<string, LinhKien>();

                //1.Linh kien thu dong 
                list.Add("LK01", new LinhKien { MSLK = "LK01", Ten = "Dien tro               (Resistor)", LoaiLK = "Linh kien thu dong", GiaNhap = 500, TonKho = 150 });
                list.Add("LK02", new LinhKien { MSLK = "LK02", Ten = "tu dien                (Capacitor)", LoaiLK = "Linh kien thu dong", GiaNhap = 1200, TonKho = 80 });
                list.Add("LK03", new LinhKien { MSLK = "LK03", Ten = "Cuon cam               (Inductor)", LoaiLK = "Linh kien thu dong", GiaNhap = 2500, TonKho = 45 });
                list.Add("LK04", new LinhKien { MSLK = "LK04", Ten = "Bien tro               (Potentiometer)", LoaiLK = "Linh kien thu dong", GiaNhap = 3000, TonKho = 60 });
                list.Add("LK05", new LinhKien { MSLK = "LK05", Ten = "Varistor", LoaiLK = "Linh kien thu dong", GiaNhap = 2800, TonKho = 35 });
                list.Add("LK06", new LinhKien { MSLK = "LK06", Ten = "Thermistor", LoaiLK = "Linh kien thu dong", GiaNhap = 1500, TonKho = 55 });
                list.Add("LK07", new LinhKien { MSLK = "LK07", Ten = "Cau chi                (Fuse)", LoaiLK = "Linh kien thu dong", GiaNhap = 800, TonKho = 120 });
                list.Add("LK08", new LinhKien { MSLK = "LK08", Ten = "Transformer            (Bien ap)", LoaiLK = "Linh kien thu dong", GiaNhap = 25000, TonKho = 25 });

                //2.Linh kien Ban Dan 
                list.Add("LK09", new LinhKien { MSLK = "LK09", Ten = "Diode                  (D)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 300, TonKho = 200 });
                list.Add("LK10", new LinhKien { MSLK = "LK10", Ten = "Transistor             (Q)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 800, TonKho = 100 });
                list.Add("LK11", new LinhKien { MSLK = "LK11", Ten = "Thyristor              (SCR)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 4500, TonKho = 30 });
                list.Add("LK12", new LinhKien { MSLK = "LK12", Ten = "Triac", LoaiLK = "Linh kien Ban Dan", GiaNhap = 6500, TonKho = 40 });
                list.Add("LK13", new LinhKien { MSLK = "LK13", Ten = "Diac", LoaiLK = "Linh kien Ban Dan", GiaNhap = 5800, TonKho = 45 });
                list.Add("LK14", new LinhKien { MSLK = "LK14", Ten = "LED                    (Light Emitting Diode)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 250, TonKho = 280 });
                list.Add("LK15", new LinhKien { MSLK = "LK15", Ten = "Photodiode", LoaiLK = "Linh kien Ban Dan", GiaNhap = 4200, TonKho = 35 });
                list.Add("LK16", new LinhKien { MSLK = "LK16", Ten = "Zener Diode", LoaiLK = "Linh kien Ban Dan", GiaNhap = 600, TonKho = 90 });

                //3.Vi mach Tich hop
                list.Add("LK17", new LinhKien { MSLK = "LK17", Ten = "IC Op-amp              (LM741, LM358)", LoaiLK = "Vi mach Tich hop", GiaNhap = 3200, TonKho = 42 });
                list.Add("LK18", new LinhKien { MSLK = "LK18", Ten = "IC Timer 555", LoaiLK = "Vi mach Tich hop", GiaNhap = 2000, TonKho = 75 });
                list.Add("LK19", new LinhKien { MSLK = "LK19", Ten = "IC Nguon               (LM7805, LM317)", LoaiLK = "Vi mach Tich hop", GiaNhap = 4000, TonKho = 35 });
                list.Add("LK20", new LinhKien { MSLK = "LK20", Ten = "IC Logic               (AND, OR, NOT gates)", LoaiLK = "Vi mach Tich hop", GiaNhap = 1800, TonKho = 65 });
                list.Add("LK21", new LinhKien { MSLK = "LK21", Ten = "Vi dieu khien          (Arduino, PIC, 8051)", LoaiLK = "Vi mach Tich hop", GiaNhap = 45000, TonKho = 20 });
                list.Add("LK22", new LinhKien { MSLK = "LK22", Ten = "IC Khuech dai am thanh (LM386, TDA2030)", LoaiLK = "Vi mach Tich hop", GiaNhap = 5500, TonKho = 25 });
                list.Add("LK23", new LinhKien { MSLK = "LK23", Ten = "IC Shift Register      (74HC595)", LoaiLK = "Vi mach Tich hop", GiaNhap = 6000, TonKho = 30 });

                //4.Linh kien Ket noi & Co khi
                list.Add("Lk24", new LinhKien { MSLK = "LK24", Ten = "Jack cam               (Audio jack, DC jack)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 2500, TonKho = 65 });
                list.Add("LK25", new LinhKien { MSLK = "LK25", Ten = "Cong tac               (Switch)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 1500, TonKho = 85 });
                list.Add("Lk26", new LinhKien { MSLK = "LK26", Ten = "Nut nhan               (Push button)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 800, TonKho = 150 });
                list.Add("Lk27", new LinhKien { MSLK = "LK27", Ten = "Den bao                (Indicator light)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 1200, TonKho = 95 });
                list.Add("Lk28", new LinhKien { MSLK = "LK28", Ten = "Coi bao                (Buzzer)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 3800, TonKho = 40 });
                list.Add("Lk29", new LinhKien { MSLK = "LK29", Ten = "Ro-le                  (Relay)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 8000, TonKho = 30 });
                list.Add("Lk30", new LinhKien { MSLK = "LK30", Ten = "Dong co                (Motor DC, Servo, Stepper)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 28000, TonKho = 18 });

                //5.Cam bien
                list.Add("LK31", new LinhKien { MSLK = "LK31", Ten = "Cam bien nhiet do      (LM35, DHT11)", LoaiLK = "Cam bien", GiaNhap = 35000, TonKho = 15 });
                list.Add("LK32", new LinhKien { MSLK = "LK32", Ten = "Cam bien anh sang      (LDR, Phototransistor)", LoaiLK = "Cam bien", GiaNhap = 2000, TonKho = 70 });
                list.Add("LK33", new LinhKien { MSLK = "LK33", Ten = "Cam bien chuyen dong   (PIR)", LoaiLK = "Cam bien", GiaNhap = 25000, TonKho = 18 });
                list.Add("LK34", new LinhKien { MSLK = "LK34", Ten = "Cam bien sieu am       (HC-SR04)", LoaiLK = "Cam bien", GiaNhap = 18000, TonKho = 22 });
                list.Add("LK35", new LinhKien { MSLK = "LK35", Ten = "Cam bien do am", LoaiLK = "Cam bien", GiaNhap = 15000, TonKho = 28 });
                list.Add("LK36", new LinhKien { MSLK = "LK36", Ten = "Cam bien gia toc       (MPU6050)", LoaiLK = "Cam bien", GiaNhap = 45000, TonKho = 12 });

                //6.Hien thi
                list.Add("LK37", new LinhKien { MSLK = "LK37", Ten = "LCD 16x2", LoaiLK = "Hien thi", GiaNhap = 32000, TonKho = 20 });
                list.Add("LK38", new LinhKien { MSLK = "LK38", Ten = "LED 7 doan", LoaiLK = "Hien thi", GiaNhap = 4500, TonKho = 35 });
                list.Add("LK39", new LinhKien { MSLK = "LK39", Ten = "Man hinh OLED", LoaiLK = "Hien thi", GiaNhap = 55000, TonKho = 15 });
                list.Add("LK40", new LinhKien { MSLK = "LK40", Ten = "Matrix LED", LoaiLK = "Hien thi", GiaNhap = 12000, TonKho = 25 });

                //7.Dao dong & Thach anh
                list.Add("LK41", new LinhKien { MSLK = "LK41", Ten = "Thach anh              (Crystal)", LoaiLK = "Dao dong & Thach anh", GiaNhap = 3000, TonKho = 60 });
                list.Add("LK42", new LinhKien { MSLK = "LK42", Ten = "IC Tao dao dong", LoaiLK = "Dao dong & Thach anh", GiaNhap = 4500, TonKho = 40 });

                //8.Mach in & Phu kien
                list.Add("LK43", new LinhKien { MSLK = "LK43", Ten = "Board mach             (PCB)", LoaiLK = "Mach in & Phu kien", GiaNhap = 8000, TonKho = 50 });
                list.Add("LK44", new LinhKien { MSLK = "LK44", Ten = "Day cap ket noi", LoaiLK = "Mach in & Phu kien", GiaNhap = 1500, TonKho = 120 });
                list.Add("LK45", new LinhKien { MSLK = "LK45", Ten = "De IC                  (IC Socket)", LoaiLK = "Mach in & Phu kien", GiaNhap = 800, TonKho = 100 });
                list.Add("LK46", new LinhKien { MSLK = "LK46", Ten = "Heat sink", LoaiLK = "Mach in & Phu kien", GiaNhap = 2000, TonKho = 75 });
            }
            public void XuatDS()
            {
                Console.WriteLine("MA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
                Console.WriteLine("============================================================================================================================================");
                foreach (var a in list)
                {
                    a.Value.HienThi();
                }
            }
            //Hàm về Menu
            public void VeMenu()
            {
                Console.WriteLine("\nNhan Enter de quay ve Menu...");
                Console.ReadKey();
                Console.Clear();
            }

            //Hàm lấy danh sách 
            public List<LinhKien> LayDanhSach()
            {
                return new List<LinhKien>(list.Values);
            }
        }
        // THÊM LINH KIỆN 
        public struct THEM
        {
            public void Them(ref DanhSach ds)
            {
                Console.Clear();
                LinhKien lk = new LinhKien();
                Console.WriteLine("\n=== THÊM LINH KIỆN MỚI ===");

                while (true)
                {
                    Console.Write("\nNhập mã linh kiện: ");
                    lk.MSLK = Console.ReadLine().Trim();
                    if (string.IsNullOrWhiteSpace(lk.MSLK))
                    {
                        Console.WriteLine("\nMa linh kien khong duoc de trong! Nhap lai: ");
                        continue;
                    }
                    if (ds.list.ContainsKey(lk.MSLK))
                    {
                        Console.WriteLine("\nMa linh kien da ton tai! Nhap lai: ");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write("Nhap ten linh kien: ");
                    lk.Ten = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(lk.Ten))
                    {
                        Console.WriteLine("\nTen linh kien khong duoc bo trong! Nhap lai: ");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write("Nhap loai linh kien: ");
                    lk.LoaiLK = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(lk.LoaiLK))
                    {
                        Console.WriteLine("\nLoai linh kien khong duoc bo trong! Nhap lai: ");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write("Nhap gia nhap: ");
                    if (decimal.TryParse(Console.ReadLine(), out lk.GiaNhap) && lk.GiaNhap >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nGia nhap khong hop le! Nhap lai: ");
                    }
                }

                while (true)
                {
                    Console.Write("Nhap luong ton kho: ");
                    if (int.TryParse(Console.ReadLine(), out lk.TonKho) && lk.TonKho >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nLuong ton kho khong hop le! Nhap lai: ");
                    }
                }

                ds.list.Add(lk.MSLK, lk);
                Console.WriteLine("\nThem linh kien thanh cong!");
            }
        }

        // SỬA
        public struct SUA
        {
            public void CapNhatTen(ref DanhSach ds, string ma)
            {
                Console.Clear();
                if (ds.list.ContainsKey(ma))
                {
                    LinhKien lk = ds.list[ma];
                    Console.Write($"\nNhap ten moi cho ma {lk.MSLK}: ");

                    string tenMoi;
                    while (true)
                    {
                        tenMoi = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(tenMoi))
                        {
                            Console.Write("\nKhong duoc bo trong! Nhap lai: ");
                            continue;
                        }
                        break;
                    }

                    lk.Ten = tenMoi;
                    ds.list[ma] = lk;
                    Console.WriteLine("\nCap nhat thanh cong!");
                }
                else
                {
                    Console.WriteLine("\nKhong tim thay linh kien!");
                }
            }

            public void CapNhatLoai(ref DanhSach ds, string ma)
            {
                if (ds.list.ContainsKey(ma))
                {
                    LinhKien lk = ds.list[ma];
                    Console.Write($"\nNhap loai linh kien moi cho ma {lk.MSLK}: ");

                    string loaiMoi;
                    while (true)
                    {
                        loaiMoi = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(loaiMoi))
                        {
                            Console.Write("\nKhong duoc bo trong! Nhap lai: ");
                            continue;
                        }
                        break;
                    }

                    lk.LoaiLK = loaiMoi;
                    ds.list[ma] = lk;
                    Console.WriteLine("\nCap nhat thanh cong!");
                }
                else
                {
                    Console.WriteLine("\nKhong tim thay linh kien!");
                }
            }

            public void CapNhatGiaNhap(ref DanhSach ds, string ma)
            {
                if (ds.list.ContainsKey(ma))
                {
                    LinhKien lk = ds.list[ma];
                    Console.Write($"\nNhap gia nhap moi cho ma {lk.MSLK}: ");

                    decimal giaMoi;
                    while (true)
                    {
                        string input = Console.ReadLine().Replace(',', '.');
                        if (decimal.TryParse(input, out giaMoi) && giaMoi >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("\nGia nhap khong hop le! Nhap lai: ");
                        }
                    }

                    lk.GiaNhap = giaMoi;
                    ds.list[ma] = lk;
                    Console.WriteLine("\nCap nhat thanh cong!");
                }
                else
                {
                    Console.WriteLine("\nKhong tim thay linh kien!");
                }
            }

            public void CapNhatTonKho(ref DanhSach ds, string ma)
            {
                if (ds.list.ContainsKey(ma))
                {
                    LinhKien lk = ds.list[ma];
                    Console.Write($"\nNhap so ton kho moi cho ma {lk.MSLK}: ");

                    int tonKhoMoi;
                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out tonKhoMoi) && tonKhoMoi >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("\nSo ton kho khong hop le! Nhap lai: ");
                        }
                    }

                    lk.TonKho = tonKhoMoi;
                    ds.list[ma] = lk;
                    Console.WriteLine("\nCap nhat thanh cong!");
                }
                else
                {
                    Console.WriteLine("\nKhong tim thay linh kien!");
                }
            }

            public void Sua(ref DanhSach ds)
            {
                Console.WriteLine("\n=== SỬA LINH KIỆN ===");

                // Nhập mã linh kiện trước
                Console.Write("Nhap ma linh kien muon sua: ");
                string ma = Console.ReadLine();

                if (!ds.list.ContainsKey(ma))
                {
                    Console.WriteLine("\nKhong tim thay linh kien!");
                    return;
                }

                // Hiển thị thông tin linh kiện hiện tại
                Console.WriteLine("\nThong tin linh kien hien tai:");
                ds.list[ma].HienThi();

                // Hiển thị menu sửa
                bool tiepTuc = true;
                while (tiepTuc)
                {
                    Console.WriteLine("\n=== MENU CAP NHAT LINH KIEN ===");
                    Console.WriteLine("1. Cap nhat ten");
                    Console.WriteLine("2. Cap nhat loai");
                    Console.WriteLine("3. Cap nhat gia nhap");
                    Console.WriteLine("4. Cap nhat ton kho");
                    Console.WriteLine("5. Quay ve menu chinh");
                    Console.Write("Chon cach cap nhat (1-5): ");
                    string chon = Console.ReadLine();

                    switch (chon)
                    {
                        case "1":
                            CapNhatTen(ref ds, ma);
                            break;
                        case "2":
                            CapNhatLoai(ref ds, ma);
                            break;
                        case "3":
                            CapNhatGiaNhap(ref ds, ma);
                            break;
                        case "4":
                            CapNhatTonKho(ref ds, ma);
                            break;
                        case "5":
                            tiepTuc = false;
                            break;
                        default:
                            Console.WriteLine("\nLua chon khong hop le!");
                            break;
                    }
                    if (tiepTuc)
                    {
                        Console.WriteLine("\nNhan Enter de tiep tuc sua...");
                        Console.ReadLine();
                    }
                }
            }
        }

        // XÓA LINH KIỆN 
        public struct XOA
        {
            public void XoaLinhKien(ref DanhSach ds)
            {
                Console.Clear();
                Console.Write("Nhap ma linh kien muon xoa: ");
                string ma = Console.ReadLine();

                if (ds.list.Remove(ma))
                {
                    Console.WriteLine("\nDa xoa linh kien!");
                }
                else
                {
                    Console.WriteLine("Khong tim thay ma linh kien can xoa!");
                }
            }
        }
        static void Main(string[] args)
        {
            DanhSach a = new DanhSach();
            a.Initiallize();
            THEM b = new THEM();
            SUA d = new SUA();
            XOA f = new XOA();
            int use;
            do
            {
                Console.WriteLine("\n~~~ MENU QUAN LY LINH KIEN ĐIEN TU ~~~");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Bang tat ca linh kien co trong kho");
                Console.WriteLine("2. Them linh kien");
                Console.WriteLine("3. Tim kiem linh kien");
                Console.WriteLine("4. Cap nhat linh kien");
                Console.WriteLine("5. Sap xep linh kien");
                Console.WriteLine("6. Xoa linh kien");
                Console.WriteLine("7. Lap rap thiet bi");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");

                if (!int.TryParse(Console.ReadLine(), out use))
                {
                    use = -1;
                }

                Console.Clear();

                switch (use)
                {
                    case 1:
                        {
                            a.XuatDS();
                            a.VeMenu();
                            break;
                        }
                    case 2:
                        {
                            b.Them(ref a);
                            a.VeMenu();
                            break;
                        }
                    case 3:
                        {
                            //c.MenuTimKiem(ref a);
                            //a.VeMenu();
                            break;
                        }
                    case 4:
                        {
                            d.Sua(ref a);
                            a.VeMenu();
                            break;
                        }
                    case 5:
                        {
                            //e.SapXep(ref a);
                            //a.VeMenu();
                            break;
                        }
                    case 6:
                        {
                            f.XoaLinhKien(ref a);
                            a.VeMenu();
                            break;
                        }
                    case 7:
                        {
                            //g.SD(ref a);
                            //a.VeMenu();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Thoat...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lua chon khong hợp le!");
                            break;
                        }
                }
            } while (use != 0);
            Console.ReadLine();
        }
    }
}
