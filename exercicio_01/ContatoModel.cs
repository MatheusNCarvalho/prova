using prova.exercicio_01;

namespace prova
{
    public class ContatoModel
    {
        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public TipoRelacionamento TipoRelacionamento { get; set; }
    }
}