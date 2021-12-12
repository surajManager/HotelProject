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

        public ActionResult Single()
        {
            RoomService roomService = new RoomService();
            IEnumerable<Roominfo> roominfo = roomService.Roominfo.Where(b => b.BookingID == 0 && b.RoomType=="Single").ToList();
            return View(roominfo);
        }
        public ActionResult Double()
        {
            RoomService roomService = new RoomService();
            IEnumerable<Roominfo> roominfo = roomService.Roominfo.Where(b => b.BookingID == 0 && b.RoomType == "Double").ToList();
            return View(roominfo);
        }
        public ActionResult Delux()
        {
            RoomService roomService = new RoomService();
            IEnumerable<Roominfo> roominfo = roomService.Roominfo.Where(b => b.BookingID == 0 && b.RoomType == "Delux").ToList();
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


        [HttpGet]
         public ActionResult Create_Customer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create_Customer(Customerinfo customerinfo)
        {
            RoomService roomService = new RoomService();

            TryUpdateModel(customerinfo);
            if (ModelState.IsValid)
            {
                roomService.customerinfo.Add(customerinfo);
                roomService.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Create_Booking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create_Booking(Bookinginfo bookinginfo, Customerinfo customerinfo)
        {
            RoomService roomService = new RoomService();

            TryUpdateModel(bookinginfo);
            if (ModelState.IsValid)
            {
                roomService.Bookinginfos.Add(bookinginfo);
                roomService.SaveChanges();
               
                return RedirectToAction("Index");
            }
            ViewBag.Cust_ID = new SelectList(roomService.customerinfo, "CustID", "CustID", bookinginfo.Cust_ID);
            return View();
        }

    }
}
