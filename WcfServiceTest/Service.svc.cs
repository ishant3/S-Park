using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceTest.Data.Entities;
using WcfServiceTest.Data.Model;

namespace WcfServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService
    {      
        public IEnumerable<Parking_Space> GetStatus()
        {
            List<Parking_Space> statusList = new List<Parking_Space>();
            EntitiesContext ec = new EntitiesContext();

            statusList = ec.GetStatus.ToList();
            //statusList = (from cust in ec.GetStatus
            //              orderby cust.Id
            //              select cust).Take(5).ToList();

            return statusList;
        }
    }
}
