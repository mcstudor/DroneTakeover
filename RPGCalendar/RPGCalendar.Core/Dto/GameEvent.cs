﻿namespace RPGCalendar.Core.Dto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class GameEventInput
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public DateTime? StartTime { get; set; }
        [Required]
        public DateTime? EndTime { get; set; }
        public bool Surprise { get; set; } = false;
    }

    public class GameEvent : GameEventInput
    {
        public int Id { get; set; }
    }

}
