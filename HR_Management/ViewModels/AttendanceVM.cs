﻿using HR_Management.Models;
using System.Collections.Generic;

namespace HR_Management.ViewModels
{
    public class AttendanceVM
    {
        public List<EmployeeUser> Employees { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}