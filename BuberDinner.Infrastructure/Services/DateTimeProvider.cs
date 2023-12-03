﻿using BuberDinner.Application.Commom.Interfaces.Services;

namespace BuberDinner.Infrastructure.Services;
public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
