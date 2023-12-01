using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Domain.Interfaces
{
    public interface IProductRepository
    {
        //Traz um item pelo Id dele
        Product GetById(Guid Id);
        //Traz N itens de acordo com uma(s) condição(ões)
        IEnumerable<Product> Search(Expression<Func<Product, bool>> predicate);
        //Traz N itens de acordo com uma(s) condiçõa(ões) e o número da página e a quantidade de itens na página
        //PAGINAÇÃO
        IEnumerable<Product> Search(Expression<Func<Product, bool>> predicate,
            int pageNumber,
            int pageSize);
        //Adiciona um item
        Product Add(Product entity);
        //Altera um item
        Product Update(Product entity);
        //Remove um único item
        void Remove(Guid Id);
        //Remove os itens que condizem com a(s) minha(s) condição(ões)
        void Remove(Expression<Func<Product, bool>> predicate);
    }
}
