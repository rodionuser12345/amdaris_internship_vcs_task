// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using System;

namespace basic {

    class VCSApp {

        public static void Main(string[] args) {
            Console.WriteLine(Area(2));
            Console.WriteLine(Area(3.02));
            Console.WriteLine(Area(2.2, 3.3));
            Console.WriteLine("Add something for feature 4");

        }

        public static string Area(int value1) {
            return String.Format("Area of Square is {0}", value1 * value1);
        }

        public static string Area(double value1) {
            return String.Format("Area of Circle is {0}", 3.14 * Math.Pow(value1, 2));
        }

        public static string Area(double value1, double value2) {
            return String.Format("Area of Rectangle is {0}", value1 * value2);
        }
    }

}
