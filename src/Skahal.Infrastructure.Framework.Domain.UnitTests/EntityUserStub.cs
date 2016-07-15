using System;
namespace Skahal.Infrastructure.Framework.Domain.UnitTests
{
    public class EntityUserStub : EntityBase, IAggregateRoot
    {
        public string Name
        {
            get;
            set;
        }

        public EntityUserStub(object key) : base(key)
        {
        }

        public EntityUserStub()
        {
        }
    }
}