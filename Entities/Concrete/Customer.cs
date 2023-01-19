﻿using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [NotMapped]
    public class Customer : User, IEntity
    {
        //public int UserId { get; set; } //primary key foreign key
        public string CompanyName { get; set; }
    }
}
