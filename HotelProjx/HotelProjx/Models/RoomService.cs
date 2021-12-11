using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelProjx.Models
{
    public class RoomService : DbContext
    {
        public DbSet<Roominfo> Roominfo { get; set; }
        public DbSet<Customerinfo> customerinfo { get; set; }
    }
}