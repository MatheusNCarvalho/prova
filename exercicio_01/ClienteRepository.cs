using System.Collections.Generic;
using System.Linq;
using prova.exercicio_01;

namespace prova
{
    public class ClienteRepository : IClienteRepository
    {
        public Contato BuscarContatoPorClienteIdETelefoneETipoRelacionamento(long clienteId, string telefone, TipoRelacionamento tipoRelacionamento)
        {
            var clientes = new List<Cliente>() {
               new Cliente(id:10, nome: "Matheus Neves"){
                   Contatos = new List<Contato>() {
                       new Contato(clienteId:10,codigo: 12, nome: "Matheus Neves", telefone: "992350157", tipoRelacionamento: TipoRelacionamento.Amigo)
                   }
               }
           };

            var result = clientes.Select(x => x.Contatos.FirstOrDefault(contato => contato.ClienteId == clienteId 
                             && contato.Telefone == telefone
                             && contato.TipoRelacionamento == tipoRelacionamento))
            .FirstOrDefault();

            return result;
        }

        public IList<Cliente> Get()
        {
            var clientes = new List<Cliente>() {
               new Cliente(id:10, nome: "Matheus Neves"){
                   Contatos = new List<Contato>() {
                       new Contato(clienteId:10,codigo: 12, nome: "Matheus Neves", telefone: "992350157", tipoRelacionamento: TipoRelacionamento.Amigo)
                   }
               }
           };


            return clientes.OrderBy(x =>
            {
                x.Contatos = x.Contatos.OrderBy(x => x.Telefone).ToList();
                return x.Nome;
            }).ToList();
        }
    }
}