using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
    internal class Angle
    {
        int degrees;
        int minutes;
        int seconds;
        public bool isCorrect = true;

        public int Degree
        {
            get
            {
                return degrees;
            }
            set
            {
                degrees = value;
            }
        }
        public int Minute
        {
            get
            {
                return minutes;
            }
            set
            {
                Degree += value / 60;


                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    minutes = value % 60;
                }
            }
        }
        public int Second
        {
            get
            {
                return seconds;
            }
            set
            {
                Minute += value / 60;

                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    seconds = value % 60;
                }
            }
        }
        public Angle(int degrees, int minutes, int seconds)
        {
            this.Degree = degrees;
            this.Minute = minutes;
            this.Second = seconds;
        }
        public double ToRadians()
        {
            return degrees * Math.PI / 180 + minutes * Math.PI / (180 * 60) + seconds * Math.PI / (180 * 3600);
        }
    }
}