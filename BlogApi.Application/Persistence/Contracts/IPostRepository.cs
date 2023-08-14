﻿using BlogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Persistence.Contracts
{
    public interface IPostRepository : IGenericRepository<Post>
    {

    }
}
