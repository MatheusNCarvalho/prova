using System.Collections.Generic;

namespace prova.exercicio_01
{
    public class Cliente
    {
        public Cliente(long id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public long Id { get; private set; }
        public string Nome { get; private set; }
        public IList<Contato> Contatos { get; set; } = new List<Contato>();

        public void AddContato(Contato contato)
        {
            Contatos.Add(contato);
        }
    }
}