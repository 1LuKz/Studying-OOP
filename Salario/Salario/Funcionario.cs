namespace Salario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() 
        { 
            return SalarioBruto - Imposto;
        }

        public void Aumento(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        public override string ToString() 
        {
            return Nome + " " + SalarioLiquido();
        }
    }
}
