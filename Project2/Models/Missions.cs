using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        [DisplayName("Mission ID")]
        public int missionID { get; set; }

        [DisplayName("Mission Name")]
        public String missionName { get; set; }

        [DisplayName("Mission President")]
        public String missionPresident { get; set; }

        [DisplayName("Mission Address")]
        public String missionAddress { get; set; }

        [DisplayName("Mission language")]
        public String language { get; set; }

        [DisplayName("Mission climate")]
        public String climate { get; set; }

        [DisplayName("Mission dominant religion")]
        public String dominantReligion { get; set; }
        [DisplayName("Mission flag")]
        public String flag { get; set; }
    }
}