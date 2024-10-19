﻿using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public int Standard { get; set; }
}
