using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Aperture_Lab.Models
{
    public class Participant
    {
        public string Name { set; get; }
        public int ID { get; set; }
        public int Age { get; set; }
        public Manager Manager { get; set; }
    }

    public class Manager
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Participant> Subbordinates { get; set; }
    }

    public class LabDBContext:DbContext
    {
        public LabDBContext()
        {
            
        }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}