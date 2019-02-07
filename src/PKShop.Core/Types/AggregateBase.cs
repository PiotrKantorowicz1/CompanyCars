﻿using System;

namespace PKShop.Core.Types
{
    public abstract class AggregateBase : IAggregate
    {
        public Guid Id { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected void SetUpdatedDate()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}