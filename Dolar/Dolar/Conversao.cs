namespace Dolar
{
    class Conversao
    {
        public static double Iof = 6;
        public static double Conversor(double cotacao, double quantidade) 
        {
            double total = cotacao * quantidade;
            return total + total * Iof / 100;
        }
    }
}
