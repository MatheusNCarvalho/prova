using System.Collections.Generic;
using prova.exercicio_01;

namespace prova
{
    public interface IClienteService {

       IList<Cliente> Get();
       void AddContato(ContatoModel contato);
    }
}