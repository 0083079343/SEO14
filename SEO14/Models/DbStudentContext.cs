using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.Entity;

namespace SEO14.Models
{
    public class DbStudentContext:DbContext
    {
        public DbSet<Student>Students { get; set; }
    }
}