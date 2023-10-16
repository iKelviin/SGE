namespace Entity
{
    public class ParametroSQLInfo
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Tamanho { get; set; }
        public int Precisao { get; set; }
        public int Escala { get; set; }
        public bool AceitaNulo { get; set; }
        public bool ParametroDeSaida { get; set; }
    }
}