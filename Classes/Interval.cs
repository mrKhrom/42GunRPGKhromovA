using System;

namespace Classes
{
    // Структура для хранения границ интервала чисел с плавающей точкой 
    // и получения случайного значения в этом интервале.
    public struct Interval
    {
        public int Min { get; }

        public int Max { get; }

        private static readonly Random rand = new Random();

        public Interval(int minValue, int maxValue)
        {
            bool invalid = false;

            if (minValue < 0)
            {
                Console.WriteLine("Некорректные входные данные: minValue < 0. minValue установлен в 0.");
                minValue = 0;
                invalid = true;
            }

            if (maxValue < 0)
            {
                Console.WriteLine("Некорректные входные данные: maxValue < 0. maxValue установлен в 0.");
                maxValue = 0;
                invalid = true;
            }

            if (minValue > maxValue)
            {
                Console.WriteLine("Некорректные входные данные: minValue > maxValue. Значения поменяны местами.");
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
                invalid = true;
            }

            if (minValue == maxValue)
            {
                Console.WriteLine("Некорректные входные данные: minValue == maxValue. maxValue увеличен на 10.");
                maxValue += 10;
                invalid = true;
            }

            Min = minValue;
            Max = maxValue;
        }

        public double Get => rand.NextDouble() * (Max - Min) + Min;
    }
}