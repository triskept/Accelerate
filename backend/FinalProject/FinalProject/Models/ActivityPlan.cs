﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ActivityPlan
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AgeRange { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int Score { get; set; }
        public int SkillsId { get; set; }
        public virtual Skills Skills { get; set; }

        public ActivityPlan( int id, string title, string ageRange, string description, int score, int duration, int skillsId)
        {
            Id = id;
            Title = title;
            AgeRange = ageRange;
            Description = description;
            Score = score;
            Duration = duration;
            SkillsId = skillsId;
        }
        public ActivityPlan()
        {
        }
    }
}
