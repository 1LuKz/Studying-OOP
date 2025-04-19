namespace Aluno
{
    internal class Trimestre
    {
        public string Nome;
        public int PrimeiraNota;
        public int SegundaNota;
        public int TerceiraNota;

        public int Resultado() 
        { 
            return PrimeiraNota + SegundaNota + TerceiraNota;
        }

        public override string ToString()
        {
            if (Resultado() >= 60) 
            {
                return "Aprovado";
            }
            else{ 
                return "Faltaram " + (60 - Resultado()) + " Pontos";
            } 
        }
    }
}
