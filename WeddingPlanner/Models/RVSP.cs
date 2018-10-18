using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class RSVP : BaseEntity
    {
        [Key]
        public int rsvpid { get; set; }
        
