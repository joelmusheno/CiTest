using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiDomain;
using NUnit.Framework;

namespace Ci.Test
{
    [TestFixture]
    public class CiTestInitial
    {
        [Test]
        public void ShouldInstanciate()
        {
            var dl = new DomainLogic();
            Assert.IsNotNull(dl);
        }

        [Test]
        public void ShouldBeTrue()
        {
            Assert.IsTrue(true);
        }
    }
}
