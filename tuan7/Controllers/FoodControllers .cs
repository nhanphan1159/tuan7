using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tuan7.Models;

namespace tuan7.Controllers
{
    public class ValuesController1 : ApiController
    {
        [HttpGet]
        public List<Food> GetBookLists()
        {
            Model1 db = new Model1();
            return db.Foods.ToList();

        }
        [HttpGet]
        public Food GetBook(int id)
        {
            Model1 db = new Model1();
            return db.Foods.FirstOrDefault(x => x.id == id);
        }
        [HttpPost]
        public Food GetBook_test(int id)
        {
            Model1 db = new Model1();
            return db.Foods.FirstOrDefault(x => x.id == id);
        }
        [HttpPost]
        public bool InsertNewBook(string name, string type, int price)
        {
            try
            {
                Model1 db = new Model1();
                Food food= new Food();
                food.name = name;
                food .type = type;
                food.price = price;
                db.Foods.Add(food);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpPut]
        public bool UpdateBook(int id, string name, string type, int price)
        {
            try
            {
                Model1 db = new Model1();
                Food food= db.Foods.FirstOrDefault(x => x.id == id);
                if (food == null)
                    return false;
                food.name = name;
                food.type = type;
                food.price = price;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpDelete]
        public bool DeleteBook(int id)
        {
            Model1 db = new Model1();
            Food food = db.Foods.FirstOrDefault(x => x.id == id);
            if (food == null) return false;
            db.Foods.Remove(food);
            db.SaveChanges();
            return true;
        }


    }
}