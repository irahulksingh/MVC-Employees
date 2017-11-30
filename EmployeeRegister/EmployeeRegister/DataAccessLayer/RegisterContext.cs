using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmployeeRegister.DataAccessLayer
{
    public class RegisterContext:DbContext
    {

        public RegisterContext() : base("EmployeeRegister")
        { }

        public DbSet<Models.Employee> Employee
        {
            get; set;
        }
    }
}