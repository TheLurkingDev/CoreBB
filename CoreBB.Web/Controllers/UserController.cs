using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBB.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBB.Web.Controllers
{
    public class UserController : Controller
    {
        private CoreBBContext _dbContext;

        public UserController(CoreBBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}