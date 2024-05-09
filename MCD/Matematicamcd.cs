using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD
{
    public class MatematicasMCD
    {
        public static void Main(string[] args)
        {
            // Aquí puedes llamar a tus métodos o hacer otras operaciones si lo deseas
            int resultado = MCDcuatroNumeros(10, 15, 20, 25);
            Console.WriteLine("El resultado es: " + resultado);
        }

        public static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int MCDcuatroNumeros(int a, int b, int c, int d)
        {
            int mcdAB = MCD(a, b);
            int mcdCD = MCD(c, d);
            return MCD(mcdAB, mcdCD);
        }
    }
}
