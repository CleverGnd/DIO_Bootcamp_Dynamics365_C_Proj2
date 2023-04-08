namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public int Id { get; set; }
        public string? TipoSuite { get; set; } 

        // construtores
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}