﻿namespace Library.Firebase.Repository.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public string? Key { get; set; }
    }
}
