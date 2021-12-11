using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelProjx.Models
{
     [Table("tbl_Roominfo")]
    public class Roominfo
    {
        [Key]   
        public string RoomNumber { get; set; }
        public string RoomType  { get; set; }
        public string BookingStatus { get; set; }
        public int BookingID { get; set; }    
        public int Price { get; set; } 
        }

    
   
     }