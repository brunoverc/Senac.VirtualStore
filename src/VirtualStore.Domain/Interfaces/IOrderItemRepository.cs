using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Domain.Interfaces
{
    public interface IOrderItemRepository
    {
        //Traz um item pelo Id dele
        OrderItem GetById(Guid Id);
        //Traz N itens de acordo com uma(s) condição(ões)
        IEnumerable<OrderItem> Search(Expression<Func<OrderItem, bool>> predicate);
        //Traz N itens de acordo com uma(s) condiçõa(ões) e o número da página e a quantidade de itens na página
        //PAGINAÇÃO
        IEnumerable<OrderItem> Search(Expression<Func<OrderItem, bool>> predicate,
            int pageNumber,
            int pageSize);
        //Adiciona um item
        OrderItem Add(OrderItem entity);
        //Altera um item
        OrderItem Update(OrderItem entity);
        //Remove um único item
        void Remove(Guid Id);
        //Remove os itens que condizem com a(s) minha(s) condição(ões)
        void Remove(Expression<Func<OrderItem, bool>> predicate);
    }
}
