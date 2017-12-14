using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    [Table("MissionQuestion")]
    public class MissionQuestion
    {
        [Key]
        public int missionQuestionID { get; set; }
        
        public int? missionID { get; set; }

        //[DisplayName("Mission Name")]    
        //public String missionName { get; set; }

        public int? userID { get; set; }

        [DisplayName("Questions")]
        public String question { get; set; }

        [DisplayName("Most Recent Answer")]
        public String answer { get; set; }

    }
}