namespace filaFibonacci
{
    internal class Numero
    {
        int N;
        Numero? Proximo;

        public Numero(int n)
        {
            this.N = n;
            this.Proximo = null;
        }

        public void SetProximo(Numero num) 
        {
            this.Proximo = num; 
        }
        public Numero? GetProximo()
        { 
            return this.Proximo; 
        }
        public int GetN() 
        { 
            return this.N; 
        }
        public string PrintN() 
        { 
            return $"Numero: {this.N}";
        }
    }
}