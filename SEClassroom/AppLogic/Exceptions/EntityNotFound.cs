using System;
using System.Collections.Generic;
using System.Text;

namespace SEClassroom.AppLogic.Exceptions
{
    public class EntityNotFound : Exception
    {
        public Guid EntityId { get; private set; }
        public EntityNotFound(Guid id) : base($"Entity with id {id} was not found")
        {
        }
    }
}
