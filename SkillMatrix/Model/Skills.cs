﻿using System.ComponentModel.DataAnnotations;

namespace SkillMatrix.Model
{
    public class Skills
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int EmpId { get; set; }
        public int TeamId { get; set; }
        public bool IsApproved { get; set; }





    }
}
