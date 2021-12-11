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

        public ActionResult Available()
        {
            RoomService roomService = new RoomService();
            IEnumerable<Roominfo> roominfo = roomService.Roominfo.Where(b => b.BookingID == 0).ToList();
            return View(roominfo);
        }

        public ActionResult Booked()
        {
            RoomService roomService = new RoomService();
            IEnumerable<Roominfo> roominfo = roomService.Roominfo.Where(b => b.BookingID == 1).ToList();
            return View(roominfo);
        }


        public ActionResult CustomerList()
        {
            RoomService roomService = new RoomService();
            IEnumerable<Customerinfo> customerinfo = roomService.customerinfo.ToList();
            return View(customerinfo);
        }
        
    }
}
