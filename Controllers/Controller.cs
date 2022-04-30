using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DAO;
using WebApi.MODEL;
using WebApplication3.DAO;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        // private readonly Pessoa _pessoaModel;
        
        private readonly IpessoaDao _pessoaModelDapper;

        public Controller()
        {
            _pessoaModelDapper = new Pessoa();
        }

        [HttpGet]
        public IEnumerable<PessoaModel> Get()
        {
            return _pessoaModelDapper.Get();
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var usuario = _pessoaModelDapper.Get(Id);
          
            return Ok(usuario);
        }
        [HttpPost]
        public IActionResult Post([FromBody]PessoaModel pessoa)
        {
            _pessoaModelDapper.Insert(pessoa);
            return Ok(pessoa);
        }
        [HttpPut]
        public IActionResult Put([FromBody]PessoaModel pessoa)
        {
            _pessoaModelDapper.Update(pessoa);
            return Ok(pessoa);
        }
        [HttpDelete]
        public void Delete(int ID) 
        {
            _pessoaModelDapper.Delete(ID);
        }
    }
}
