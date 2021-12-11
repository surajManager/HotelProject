using HotelProjx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelProjx.Controllers
{
    public class RoomController : Controller
    {
    
        public ActionResult Index()
        {
            RoomService roomService = new RoomService();
            IEnumerable<Roominfo> roominfo = roomService.Roominfo.ToList();
            return View(roominfo);
        }

    }
}
