using System;

namespace Lab4
{
    public class Tasks
    {
        public static string[] Items =
        {
            "Добввить элемент с заданным номером",
            "Удалить элемент с заданным номером",
            "Перестановка чётных элементов в начало, нечётных - в конец",
            "Поиск элемента равного среднему арифметическому элементов массива",
            "Сортировка простым включением",
            "Бинарный поиск"
        };

        // Удаление элемента
        public static int[] First(int[] array, int indexOfElementToDelete)
        {

            if (indexOfElementToDelete >= array.Length || indexOfElementToDelete < 0 || array.Length <= 0)
                return array;

            int[] temp = new int[array.Length - 1];

            for (int j = 0, i = 0; j < temp.Length; j++, i++)
            {
                if (i == indexOfElementToDelete)
                    i++;

                temp[j] = array[i];
            }

            return temp;
        }

        //Вставка элемента
        public static int[] Second(int[] array, int indexOfElementToInsert, int element)
        {

            int[] temp = new int[array.Length + 1];

            if (indexOfElementToInsert >= temp.Length || indexOfElementToInsert < 0 || array.Length <= 0)
                return array;

            for (int j = 0, i = 0;; j++, i++)
            {
                if (j == indexOfElementToInsert)
                {
                    temp[j++] = element;
                }

                if (j >= temp.Length)
                    break;

                temp[j] = array[i];
            }

            return temp;
        }

        //Перестановка чётных в начало, нечётных в конец
        public static int[] Third(int[] myArray)
        {
            int[] odd = new int[0];
            int[] even = new int[0];
            int[] array = new int[myArray.Length];

            for (int i = 0; i < array.Length; i++)
                array[i] = myArray[i];

            for (int i = 0, k = 0, j = 0; i < array.Length; i++)
                if (array[i]%2 == 0)
                {
                    int[] temp = new int[even.Length + 1];
                    for (int p = 0; p < even.Length; p++)
                        temp[p] = even[p];
                    even = temp;
                    even[k++] = array[i];
                }
                else
                {
                    int[] temp = new int[odd.Length + 1];
                    for (int p = 0; p < odd.Length; p++)
                        temp[p] = odd[p];
                    odd = temp;
                    odd[j++] = array[i];
                }

            for (int i = 0; i < even.Length; i++)
                array[i] = even[i];
            for (int i = 0; i < odd.Length; i++)
                array[even.Length + i] = odd[i];

            return array;
        }

        //Поиск среднего арифметического
        public static bool Fourth(int[] array, out double average, out int averageIndex)
        {

            average = 0;

            foreach (int x in array)
                average += x;
            average /= array.Length;

            for (int i = 0; i < array.Length; i++)
                if (Math.Abs(average - array[i]) <= .0)
                {
                    averageIndex = i;
                    return true;
                }

            averageIndex = 0;
            return false;
        }

        //Сортировка простым включением
        public static int[] Fifth(int[] myArray)
        {
            int[] array = new int[myArray.Length];
            for (int i = 0; i < array.Length; i++)
                array[i] = myArray[i];

            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j;
                for (j = i - 1; j >= 0 && array[j] > temp; j--)
                    array[j + 1] = array[j];
                array[j + 1] = temp;
            }

            return array;
        }

        public static bool BinarySearch(int[] array, int element, out int checks, out int index)
        {
            checks = 0;
            index = 0;
            if (array.Length <= 0)
                return false;

            int left = 0, right = array.Length - 1;
            do
            {
                checks++;
                index = (left + right)/2;

                if (array[index] < element)
                    left = index + 1;
                else right = index;
            } while (left != right);

            index = left;
            return array[left] == element;
        }
    }
}