using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryRepository:GenericRepository<Category>
    {
        DataContext db = new DataContext();
        public List<Product> CategoryDetails(int id)
        {
            return db.Products.Where(x=>x.CategoryId==id).ToList();
        }
    }
}
