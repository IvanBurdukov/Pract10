using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract10
{
    class Angle
    {
        private int degrees;
        private int minutes;
        private int seconds;

        public int Degrees
        {
            get { return degrees; }
            set
            {
                if (value >= 0 && value < 360)
                {
                    degrees = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Градусы должны быть в диапазоне от 0 до 359.");
                }
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    minutes = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Минуты должны быть в диапазоне от 0 до 59.");
                }
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    seconds = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Секунды должны быть в диапазоне от 0 до 59.");
                }
            }
        }

        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public double ToRadians()
        {
            double totalDegrees = Degrees + (Minutes / 60.0) + (Seconds / 3600.0);
            return totalDegrees * (Math.PI / 180.0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Angle angle = new Angle(45, 30, 15);
                Console.WriteLine("Угол: {0}° {1}' {2}\"", angle.Degrees, angle.Minutes, angle.Seconds);
                Console.WriteLine("Угол в радианах: {0}", angle.ToRadians());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}