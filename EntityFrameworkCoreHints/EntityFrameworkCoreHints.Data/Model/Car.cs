﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreHints.Data.Model
{
    public class Car : IEntity
    {
        public Guid Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
