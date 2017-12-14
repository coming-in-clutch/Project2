using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project2.Models;
using System.Data.Entity;

namespace Project2.DAL
{
    public class MissionProjectContext : DbContext
    {

        public MissionProjectContext() : base("MissionProjectContext")
        {

        }

        //public DbSet<MissionProjectContext> MissionProjectContexts { get; set; }

        public DbSet<Missions> Mission { get; set; }

        public DbSet<MissionQuestions> MissionQuestion { get; set; }

        public DbSet<Users> Users { get; set; }


    }
}