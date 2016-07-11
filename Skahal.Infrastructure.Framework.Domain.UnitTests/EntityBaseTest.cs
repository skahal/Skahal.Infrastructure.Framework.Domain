using NUnit.Framework;
using System;
namespace Skahal.Infrastructure.Framework.Domain.UnitTests
{
    [TestFixture]
    public class EntityBaseTest
    {
        [Test()]
        public void EqualsOperator_NullEqualsNull_True()
        {
            EntityBase one = null;

            Assert.IsTrue(one == null);
        }

        [Test()]
        public void Equals_DiffKeys_False()
        {
            var target1 = new EntityUserStub("1");
            var target2 = new EntityUserStub("2");

            Assert.IsFalse(target1 == target2);
        }
    }
}

