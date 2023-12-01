using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Domain.Interfaces
{
    public interface IPaymentMethodRepository
    {
        //Traz um item pelo Id dele
        PaymentMethod GetById(Guid Id);
        //Traz N itens de acordo com uma(s) condição(ões)
        IEnumerable<PaymentMethod> Search(Expression<Func<PaymentMethod, bool>> predicate);
        //Traz N itens de acordo com uma(s) condiçõa(ões) e o número da página e a quantidade de itens na página
        //PAGINAÇÃO
        IEnumerable<PaymentMethod> Search(Expression<Func<PaymentMethod, bool>> predicate,
            int pageNumber,
            int pageSize);
        //Adiciona um item
        PaymentMethod Add(PaymentMethod entity);
        //Altera um item
        PaymentMethod Update(PaymentMethod entity);
        //Remove um único item
        void Remove(Guid Id);
        //Remove os itens que condizem com a(s) minha(s) condição(ões)
        void Remove(Expression<Func<PaymentMethod, bool>> predicate);
    }
}
