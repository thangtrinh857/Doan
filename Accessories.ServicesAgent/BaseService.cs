using Accessories.Data.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.ServicesAgent
{
    public class BaseService
    {
        protected readonly IDbContextFactory<AccessoriesDbContext> _dbContextFactory;
        protected readonly IMapper _mapper;

        public BaseService(IDbContextFactory<AccessoriesDbContext> dbContextFactory, IMapper mapper)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
        }
    }
}
