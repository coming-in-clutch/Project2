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

        public DbSet<Mission> Missions { get; set; }

        public DbSet<MissionQuestion> MissionQuestions { get; set; }

        public DbSet<User> Users { get; set; }


    }
}