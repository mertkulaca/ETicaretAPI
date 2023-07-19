﻿using ETicaretAPI.Application.Respositories.ProductRepositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product> , IProductWriteRepository
    {
        public ProductWriteRepository(Context context) : base(context)
        {
        }
    }
}
