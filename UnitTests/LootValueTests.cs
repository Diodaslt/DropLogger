using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropLogger
{
    [TestClass]
    class LootValueTests
    {
        [TestMethod]
        void ShouldCalculateItemValue()
        {
            LootValue lootvalue = new LootValue(1, 5);
            LootValue lootvalue2 = new LootValue(2, 1.5m);
            Assert.AreEqual(5, lootvalue.totalValue);
            Assert.AreEqual(3, lootvalue2);
        }
    }
}
