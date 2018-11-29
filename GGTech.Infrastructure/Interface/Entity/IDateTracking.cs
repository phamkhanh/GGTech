﻿using System;

namespace GGTech.Infrastructure.Interface.Entity
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}