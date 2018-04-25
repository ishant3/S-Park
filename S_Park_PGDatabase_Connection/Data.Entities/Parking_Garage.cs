using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace S_Park_PGDatabase_Connection.Data.Entities
{
    [DataContract]
    [Table("Parking_Space", Schema = "public")]
    public class Parking_Garage
    {

        [DataMember]
        [Column("Id")]
        [Key]
        [Required]
        public int Id { get; set; }


        [DataMember]
        [Column("Status")]        
        public bool Status { get; set; }
    }
}