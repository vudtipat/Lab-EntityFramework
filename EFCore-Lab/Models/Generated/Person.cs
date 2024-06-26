﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCore_Lab.Models;

public partial class Person
{
    [Key]
    public int? PersonId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
}
