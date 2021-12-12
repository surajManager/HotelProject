using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelProjx.Models
{

        [Table("tbl_Customer")]
        public class Customerinfo
        {
            [Key]
            public int CustID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Emailaddress { get; set; }
            public int Phone { get; set; }
            public int CCNum { get; set; }
            public int BookID { get; set; }
        }
    
}