using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeus.Models;
using Zeus.Persistence;
using Zeus.Resources;

namespace Zeus.Controllers
{
    public class MakesController : Controller
    {
        private readonly ZeusDbContext context;
        private readonly IMapper mapper;
        public MakesController(ZeusDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            // map domain classes to api resources before returning
            var makes = await context.Makes.Include(x => x.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
