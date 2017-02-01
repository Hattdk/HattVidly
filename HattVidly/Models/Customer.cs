﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HattVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required][StringLength(128)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public DateTime BirthDate { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}

