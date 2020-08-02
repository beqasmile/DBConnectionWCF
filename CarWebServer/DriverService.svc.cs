using CarCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarWebServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DriverService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DriverService.svc or DriverService.svc.cs at the Solution Explorer and start debugging.
    public class DriverService : IDriverServerLogic
    {
        public void DeleteDriver(Driver driver)
        {
            DriversDal driverDAL = new DriversDal();
            driverDAL.DeleteDriver(driver);
        }


        public void DoWork()
        {
        }

       
        public List<Driver> SelectDrivers()
        {
            DriversDal driverDAL = new DriversDal();
            return driverDAL.SelectDrivers();
        }

        public void UpdateDriver(Driver driver)
        {
            if (ValidateDriver(driver))
            {
                DriversDal driverDAL = new DriversDal();
                // check if the car exists
                if (driverDAL.CheckDriverExists(driver))
                {
                    driverDAL.UpdateDriver(driver);
                }
                else
                {
                    driverDAL.InsertDriver(driver);
                }
            }
        }

        public bool ValidateDriver(Driver driver)
        {
            return true;
        }
    }
}
