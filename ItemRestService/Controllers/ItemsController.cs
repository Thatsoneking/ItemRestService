﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private static readonly List<ItemLibrary.Model.Item> items = new List<ItemLibrary.Model.Item>()
         {
             new ItemLibrary.Model.Item(1,"Bread","Low",33),
             new ItemLibrary.Model.Item(2,"Bread","Middle",21),
             new ItemLibrary.Model.Item(3,"Beer","low",70.5),
             new ItemLibrary.Model.Item(4,"Soda","High",21.4),
             new ItemLibrary.Model.Item(5,"Milk","Low",55.8)
         };
        // GET: api/Items
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return items;
        }

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public Item Get(int id)
        {
            return items.Find(match:i=> i.Id == id);
        }

        // POST: api/Items
        [HttpPost]
        public void Post([FromBody] Item value)
        {
            items.Add(value);
        }

        // PUT: api/Items/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item value)
        {
            Item item = Get(id);
            if (item != null)
            {
                item.Id = value.Id;
                item.Name = value.Name;
                item.Quality = value.Quality;
                item.Quantity = value.Quantity;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Item item = Get(id);
            items.Remove(item);
        }

    }
}
