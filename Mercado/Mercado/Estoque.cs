namespace Mercado
{
    internal class Estoque
    {
        private string _nome;
        private double _valor;
        private int _quantidade;

        public Estoque(string nome, double valor, int quantidade)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = quantidade;
        }

        // public string Nome;
        // public double Valor;
        // public int Quantidade;

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public double GetValor()
        {
            return _valor;
        }

        public void SetValor(double valor)
        {
            _valor = valor;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }


        public double ValorTotal()
        {
            return _valor * _quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + " " + _valor + " " + _quantidade + " " + ValorTotal();
        }
    }
}
