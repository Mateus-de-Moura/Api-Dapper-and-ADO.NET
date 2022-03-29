using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DAO;
using WebApi.MODEL;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        private readonly Pessoa _pessoaModel;
        public Controller()
        {
            _pessoaModel = new Pessoa();
        }

        [HttpGet]
        public IEnumerable<PessoaModel> Get()
        {
            return _pessoaModel.GetPessoas();
        }
        [HttpGet("{Id}")]
        public IEnumerable<PessoaModel> Get(int Id)
        {
            return _pessoaModel.GetPessoaId(Id);
        }
        [HttpPost]
        public void Post(PessoaModel pessoa)
        {
            _pessoaModel.InserPessoa(pessoa);

        }
        [HttpPut]
        public void Put(PessoaModel pessoa)
        {
            _pessoaModel.UpdatePessoa(pessoa);
        }
        [HttpDelete]
        public void Delete(int ID) 
        {
            _pessoaModel.DeletarPessoa(ID);
        }
    }
}
