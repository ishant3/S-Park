using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using S_Park_PGDatabase_Connection.Data.Entities;
using S_Park_PGDatabase_Connection.Data.Models;

namespace S_Park_PGDatabase_Connection
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public IEnumerable<Parking_Garage> GetStatus()
        {
            List<Parking_Garage> statusList = new List<Parking_Garage>();
            EntitiesContext ec = new EntitiesContext();            

            statusList = (from cust in ec.GetStatus
                            orderby cust.Id
                            select cust).Take(5).ToList();

            return statusList;

        }
    }
}
