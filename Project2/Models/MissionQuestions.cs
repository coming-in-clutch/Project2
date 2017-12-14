using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int missionQuestionID { get; set; }
        
        public int? missionID { get; set; }

        public int? userID { get; set; }
        public String question { get; set; }
        public String answer { get; set; }

    }
}