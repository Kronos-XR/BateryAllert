using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BateryAllert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString() + "%" , "Заряд батареи %");
            Console.ReadKey();

        }
    }
}
