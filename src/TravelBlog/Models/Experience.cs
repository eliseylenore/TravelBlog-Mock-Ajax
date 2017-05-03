﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public List<PersonExperience> PeopleExperiences { get; set; }

        public Experience(string title, string description, int locationId, int id = 0)
        {
            Title = title;
            Description = description;
            LocationId = locationId;
            ExperienceId = id;
        }
        public Experience() { }
    }
}
