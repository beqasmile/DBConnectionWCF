﻿using CarCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarUI
{
    /// <summary>
    /// CarDataST - singleton
    /// </summary>
    public class CarDataST
    {
        private static CarDataST _instance;

        private List<Car> _cars;
        private List<Driver> _drivers;

        private CarDataST ()
        {
            Cars = new List<Car>();
            
            //CarFactory carFactory;
            //carFactory = new CarFactory();
            CarDriverNamespace.CarDriverServiceClient carDriverServiceClient = new CarDriverNamespace.CarDriverServiceClient();

            _cars = carDriverServiceClient.SelectCars();
            DriverNamespace.DriverServerLogicClient driverServerLogicClient = new DriverNamespace.DriverServerLogicClient();
            _drivers = driverServerLogicClient.SelectDrivers();
        }

        public List<Car> Cars { get => _cars; set => _cars = value; }
        public List<Driver> Drivers { get => _drivers; set => _drivers = value; }

        public static CarDataST GetInstance()
        {
            if (_instance==null)
            {
                _instance = new CarDataST();
            }
            return _instance;
        }
    }
}
