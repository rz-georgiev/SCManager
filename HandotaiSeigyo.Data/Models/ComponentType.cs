﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace HandotaiSeigyo.Data.Models
{
    public class ComponentType : BaseEntity
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public IEnumerable<ComponentTypeDetail> Details { get; set; }

    }
}