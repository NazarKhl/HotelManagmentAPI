using HotelManagmentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagmentAPI.Context
{
        public class CRUDContext : DbContext { 
        public  CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
            {

            }
            public DbSet<People> People { get; set; }    
    }
        
    }
