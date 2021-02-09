using Projeto_SalesWebMVC.Data;
using Projeto_SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly Projeto_SalesWebMVCContext _context;

        public SellerService(Projeto_SalesWebMVCContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }


    }
}
