using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceTest.Data.Entities
{
    [DataContract]
    [Table("Parking_Space", Schema = "public")]
    public class Parking_Space
    {
        [DataMember]
        [Column("Id")]
        [Key]
        public int Id { get; set; }


        [DataMember]
        [Column("Status")]
        public bool Status { get; set; }
    }
}