using System;
using System.Collections.Generic;
using prova.exercicio_01;

namespace prova
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _contatoRepository;

        public ClienteService()
        {
            _contatoRepository = new ClienteRepository();
        }

        public IList<Cliente> Get()
        {
            return null;
        }

        public void AddContato(ContatoModel model)
        {
            var existeContatoDuplicado = _contatoRepository
            .BuscarContatoPorClienteIdETelefoneETipoRelacionamento(clienteId: model.ClienteId,
                                                                    telefone: model.Telefone,
                                                                    tipoRelacionamento: model.TipoRelacionamento);

            if (existeContatoDuplicado != null)
            {
                throw new Exception("Telefone e Tipo relacionamento, informado já está em uso");
            }
        }
    }
}