using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Domain.Interfaces
{
    public interface IBasketRepository
    {
        //Traz um item pelo Id dele
        Basket GetById(Guid Id);
        //Traz N itens de acordo com uma(s) condição(ões)
        IEnumerable<Basket> Search(Expression<Func<Basket, bool>> predicate);
        //Traz N itens de acordo com uma(s) condiçõa(ões) e o número da página e a quantidade de itens na página
        //PAGINAÇÃO
        IEnumerable<Basket> Search(Expression<Func<Basket, bool>> predicate,
            int pageNumber,
            int pageSize);
        //Adiciona um item
        Basket Add(Basket entity);
        //Altera um item
        Basket Update(Basket entity);
        //Remove um único item
        void Remove(Guid Id);
        //Remove os itens que condizem com a(s) minha(s) condição(ões)
        void Remove(Expression<Func<Basket, bool>> predicate);
    }
}
