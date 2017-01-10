using System;
using System.Windows.Forms;

namespace Lab4
{
    public class Stuff
    {
        public static int[] MainArray = new int[0];

        public static int ReadInteger(string input)
        {
            int n;
            try
            {
                n = int.Parse(input);
            }
            catch (FormatException)
            {
                return 0;
            }
            return n;
        }

        public static int[] GenerateIntArray(int arrayLength)
        {
            Random randGen = new Random();

            if (arrayLength <= 0)
                return null;

            int[] temp = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
                temp[i] = randGen.Next(-100, 100);

            return temp;
        }

        public static int[] StringToIntArray(string input)
        {

            //Удаление двойных пробелов
            input = input.Trim();
            while (input.Contains("  "))
                input = input.Remove(input.IndexOf("  "), 1);

            if (input == " " || input == string.Empty)
                return null;

            int n = 0;
            input += " ";
            int[] array = new int[n];

            //Запись элементов из сторки в массив

            while (input != string.Empty)
            {
                int temp;
                if (int.TryParse(input.Substring(0, input.IndexOf(" ")), out temp))
                {
                    int[] tempArray = new int[n + 1];
                    int j;
                    for (j = 0; j < n; j++)
                        tempArray[j] = array[j];
                    array = tempArray;
                    n++;
                    array[j] = temp;
                }
                input = input.Remove(0, input.IndexOf(" ") + 1);
            }
            return array;
        }

        public static string WriteArray(int[] array)
        {
            if (array == null)
                return string.Empty;
            string result = string.Empty;
            foreach (int x in array)
                result += " " + x;
            return result;
        }

        public static bool IsSorted(int[] array)
        {
            int[] temp = Tasks.Fifth(array);

            for (int i = 0; i < array.Length; i++)
                if (array[i] != temp[i])
                    return false;
            return true;
        }
    }
}