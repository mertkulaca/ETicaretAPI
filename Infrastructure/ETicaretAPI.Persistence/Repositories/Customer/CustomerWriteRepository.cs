﻿using ETicaretAPI.Application.Respositories.CustomerRepositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(Context context) : base(context)
        {
        }
    }
}
