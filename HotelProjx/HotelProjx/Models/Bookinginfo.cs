using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelProjx.Models
{
    [Table("tbl_Booking")]
    public class Bookinginfo
    {
        [Key]
        public int BookID { get; set; }
        public int Cust_ID { get; set; }
        public string RoomNum { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public int BookDays { get; set; }
    }
    
}