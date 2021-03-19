using System.Collections.Generic;
using prova.exercicio_01;

namespace prova
{
    public interface IClienteRepository
    {
        IList<Cliente> Get();
        Contato BuscarContatoPorClienteIdETelefoneETipoRelacionamento(long clienteId, string telefone, TipoRelacionamento tipoRelacionamento);
    }
}