using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtualStore.Application.Interfaces;
using VirtualStore.Application.ViewModel;

namespace VirtualStore.API.Controllers
{
    [ApiController]
    [Route("api/v1/product")]
    public class ProdutoController : Controller
    {
        private readonly IProductAppService _productAppService;

        public ProdutoController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        //2Traz todos osprodutos cadastrados no sistema
        public ActionResult Get()
        {
            var result = _productAppService.Search(p => true);
            return Ok(result);
        }

        [HttpGet("{id}")]
        //Traz um produto de acordo com o seu ID
        public ActionResult<ProductViewModel> Get(Guid id)
        {
            var result = _productAppService.GetById(id);
            return result;
        }

        [HttpPost]
        //Insere um produto no banco de dados
        public ActionResult Post([FromBody] ProductViewModel model)
        {
            var result = _productAppService.Add(model);
            return Ok(result);
        }

        [HttpPut]
        //Altera um produto no banco de dados
        public ActionResult Put([FromBody] ProductViewModel model)
        {
            var result = _productAppService.Update(model);
            return Ok(result);
        }

        [HttpDelete]
        //Deleta um produto do banco
        public ActionResult Delete(Guid id)
        {
            _productAppService.Remove(id);
            return Ok();
        }

    }
}

