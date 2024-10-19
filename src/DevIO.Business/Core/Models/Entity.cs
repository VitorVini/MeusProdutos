using System;

namespace DevIO.Business.Core.Models
{
    internal abstract class Entity
    {

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
