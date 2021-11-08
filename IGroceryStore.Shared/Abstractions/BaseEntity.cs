using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IGroceryStore.Shared.Abstractions
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [NotMapped]
        public List<BaseDomainEvent> Events { get; set; } = new();
    }
}