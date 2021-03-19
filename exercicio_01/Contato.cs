using prova.exercicio_01;

namespace prova
{
    public class Contato
    {
        public Contato(long clienteId, long codigo, string nome, string telefone, TipoRelacionamento tipoRelacionamento)
        {
            ClienteId = clienteId;
            Codigo = codigo;
            Nome = nome;
            Telefone = telefone;
            TipoRelacionamento = tipoRelacionamento;
        }

        public long ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }
        public long Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public TipoRelacionamento TipoRelacionamento { get; private set; }
        
    }
}