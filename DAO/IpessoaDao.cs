using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DAO;
using WebApi.MODEL;

namespace WebApplication3.DAO
{
    interface IpessoaDao
    {
        public List<PessoaModel> Get();
        public PessoaModel Get(int id);
        public void Insert(PessoaModel pessoa);
        public void Update(PessoaModel pessoa);
        public void Delete(int id);


    }
}
