namespace Modul5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole(5);
            //ShowArray(array, true);
            
            SortArray(in array, out int[] sorteddesc, out int[] sortedasc);

            Console.WriteLine("sorteddesc");
            for (int s = 0; s < sorteddesc.Length; s++)
            {
                Console.WriteLine(sorteddesc[s]);
            }

            Console.WriteLine("sortedasc");
            for (int n = 0; n < sortedasc.Length; n++)
            {
                Console.WriteLine(sortedasc[n]);
            }
            Console.WriteLine();


            //string name = "max";
            //Console.WriteLine(name);
            //ChargeName(out name);
            //Console.WriteLine(name);

            //var arr = new int[] { 1, 2, 3 };
            //BigDataOperation(arr);

            //Console.WriteLine(arr[0]);

        }

        static void ChargeName(out string name)
        {
            Console.WriteLine("Введите новое имя");
            name = Console.ReadLine();
            Console.WriteLine(name);
        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }

        static int[] GetArrayFromConsole(int num)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            int[] array1 = new int[array.Length];
            Array.Copy(array, 0, array1, 0, array.Length);
            sorteddesc = SortArrayDesc(array1);
            int[] array2 = new int[array.Length];
            Array.Copy(array, 0, array2, 0, array.Length);
            sortedasc = SortArrayAsc(array2);
        }

        static int[] SortArrayDesc (int[] arr)
        {
            for (int n = 0; n < arr.Length; n++)
            {
                for (int k = n+1; k < arr.Length; k++)
                {
                    if (arr[n] < arr[k])
                    {
                        int x = arr[k];
                        arr[k] = arr[n];
                        arr[n] = x;
                    }
                }
            }
            return arr;
        }

        static int[] SortArrayAsc(int[] arr1)
        {
            for (int n = 0; n < arr1.Length; n++)
            {
                for (int k = n+1; k < arr1.Length; k++)
                {
                    if (arr1[n] > arr1[k])
                    {
                        int x = arr1[k];
                        arr1[k] = arr1[n];
                        arr1[n] = x;
                    }
                }
            }
            return arr1;
        }

        static void ShowArray(int[] array, bool sort = false)
        {

            if (sort == true)
            {
                for (int n = 0; n < array.Length; n++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[n] > array[k])
                        {
                            int x = array[k];
                            array[k] = array[n];
                            array[n] = x;
                        }
                    }
                }
            }
            for (int s = 0; s < array.Length; s++)
            {
                Console.WriteLine(array[s]);
            }
        }
    }
}