﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;


namespace EmergyService.DataObjects
{
    public class Signal : EntityData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ServiceOwn Own { get; set; }
    }
}