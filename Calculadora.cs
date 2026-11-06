
namespace ExerciciosPOO
{
    public class Calculadora
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double Somar()
        {
           return num1 + num2;
        }

        public double Subtrair()
        {
           return num1 - num2;
        }

        public double Multiplicar()
        {
           return num1 * num2;
        }

        public static double Dividir(double num1, double num2)
        {
            if(num2 == 0)
            {
                 Console.WriteLine("Erro: Não é possível dividir por zero.");
                 return double.NaN;
            }
            else
            {
                return num1 / num2;
            }
        }

    }
}