using System;
using System.Security.Cryptography;
//Generic Method – Satu Parameter

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//        Halo.PrintHalo<int>(12345);

//     }
//     class Halo
//     {
//         ublic static void PrintHalo<T>(T InputanUser)
//         {
//             Console.WriteLine("Inputan Anda adalah: " + InputanUser);
//         }
//     }
// }



//Generic Method – Dua Parameter

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine(Halo.GabungkanDuaString<int, double>(123, 37.5));
//     }
// }
// class Halo
// {
//     public static void PrintHalo<T>(T InputanUser)
//     {
//         Console.WriteLine("Inputan Anda adalah: " + InputanUser);
//     }
//     public static string GabungkanDuaString<T, U>(T a, U b)
//     {
//         return a + " " + b;
//     }
// }

//Generic Class – Satu Parameter

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         ListData<int> ObjData1 = new ListData<int>(1);
//         Console.WriteLine(ObjData1.GetData());
//         ListData<double> ObjData2 = new ListData<double>(2.5);
//         Console.WriteLine(ObjData2.GetData());
//     }
// }
// class ListData<Generics>
// {
//     private Generics data;
//     public ListData(Generics InputData)
//     {
//         this.data = InputData;
//     }
//     public Generics GetData()
//     {
//         return data;
//     }
// }

//Generic Class –Dua Parameter

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         ListData<int, string> ObjData1 = new ListData<int, string>(1, "satu");
//         ObjData1.PrintData();
//     }
// }
// class ListData<Generics_1, Generics_2>
// {
//     private Generics_1 data1;
//     private Generics_2 data2;
//     public ListData(Generics_1 InputData1, Generics_2 InputData2)
//     {
//         data1 = InputData1;
//         data2 = InputData2;
//     }
//     public void PrintData()
//     {
//         Console.WriteLine("Data 1 adalah: " + data1 + " dan Data 2 adalah: " + data2);
//     }
// }


//Generic Class (List)

using System;
using System.Collections.Generic;
namespace ContohGeneric
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ListData<int> ObjData = new ListData<int>();
            ObjData.AddDataBaru(1);
            ObjData.AddDataBaru(2);
            ObjData.PrintSemua();
        }
    }
    class ListData<T>
    {
        private List<T> DataTersimpan;
        public ListData()
        {
            DataTersimpan = new List<T>();
        }
        public void AddDataBaru(T DataBaru)
        {
            DataTersimpan.Add(DataBaru);
        }
        public T GetDataPertama()
        {
            return DataTersimpan[0];
        }
        public void PrintData()
        {
            Console.WriteLine("Data tersimpan sebanyak: " +
            DataTersimpan.Count());
        }
        public void PrintSemua()
        {
            foreach (T SemuaData in DataTersimpan)
            {
                Console.WriteLine(SemuaData);
            }
        }
    }
}