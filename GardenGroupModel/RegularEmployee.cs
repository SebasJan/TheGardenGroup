﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string firstName, string lastName, string email, int phoneNumber, Location location) : base(firstName, lastName, email, phoneNumber, location)
        {
        }
    }
}
