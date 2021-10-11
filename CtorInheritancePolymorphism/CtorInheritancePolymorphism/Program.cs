using System;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //string[] arr = {"salam", "p320", "qrupu" };

            //Console.WriteLine(CustomJoin(arr,','));

            #endregion

            #region Task 2

            //int[] arr = { 3, 5, 1, 2, 9 };
            //CustomSort(arr);

            //foreach (var item in arr)
            //{
            //    Console.Write(item+ " ");
            //}

            #endregion

            #region Constructor

            //Student s1 = new Student
            //{
            //    Name = "Parviz",
            //    Surname = "Asadli",
            //    Age = 20
            //};
            //Console.WriteLine(s1.GetFullName());

            //var s2 = new Student("Orkhan", "Elyasov", 18);
            //Console.WriteLine(s2.GetFullName());

            //var s3 = new Student("Aziz", "Shirinov");
            //Console.WriteLine(s3.GetFullName());

            //var s4 = new Student();

            //Car class-i yazmaq, field-leri Marka, Model, Price olsun.
            //3 constructor olsun: 1) Markani daxil etmeyi mecbur etsin.
            //2) Marka ve modeli daxil etmeyi mecbur etsin.
            //3) Marka, model ve price daxil etmeyi mecbur etsin.
            //Her constructor ozunen evvelki constructoru chagirsin.
            //Elave olaraq bir method olsunki return olaraq Car-in Marka,
            //Model ve Price-ini bir string-de qaytarsin.
            //Ve Car class-indan 3 dene obyekt yaradin
            //(marka, model, price oz isteyinize uygun olsun) ve
            //yaratdiginiz obyektde Marka,Model ve Price-i qaytaran methodu chagirib
            //Console-da gosterin.

            #endregion

            #region Inheritance

            //Student s1 = new Student("Emil", "Kerimov", 25, "P320");
            //Console.WriteLine(s1.GetFullName());

            Teacher t1 = new Teacher("Orkhan", "Abdullayev", 25, 1000000);
            //Console.WriteLine(t1.GetFullName());

            Developer d1 = new Developer("Kamran", "Jabiyev", 32, "Full Stack");
            //Console.WriteLine(d1.GetFullName());

            //Developer[] developers = { d1 };
            //foreach (var item in developers)
            //{
            //    Console.WriteLine(item.GetFullName());
            //}

            //Teacher[] teachers = { t1 };
            //foreach (var item in teachers)
            //{
            //    Console.WriteLine(item.GetFullName());
            //}

            Person[] persons = { t1, d1 };
            foreach (var item in persons)
            {
                Console.WriteLine(item.GetFullName());
            }

            #endregion
        }

        #region Task 1

        static string CustomJoin(String[] arr,char seperator)
        {
            StringBuilder result = new StringBuilder();

            //foreach (var item in arr)
            //{
            //    result.Append($"{item}{seperator}");
            //}

            //return result.ToString().TrimEnd(seperator);
            
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(arr[i]);

                if (i < arr.Length - 1)
                {
                    result.Append(seperator);
                }
            }

            return result.ToString();
        }

        #endregion

        #region Task 2

        static void CustomSort(int[] arr)
        {
            //3,5,1,2,9
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        #endregion
    }
}
