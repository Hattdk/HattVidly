﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HattVidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}