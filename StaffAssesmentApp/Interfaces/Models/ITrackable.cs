﻿namespace StaffAssessmentApp.Interfaces.Models
{
    public interface ITrackable {
        //public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        //public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
