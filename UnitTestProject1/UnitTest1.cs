using MCD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_mcd_cuatro_numeros_basico()
        {
            Assert.AreEqual(5, MatematicasMCD.MCDcuatroNumeros(10, 15, 20, 25));
            Assert.AreEqual(10, MatematicasMCD.MCDcuatroNumeros(10, 20, 30, 40));
            Assert.AreEqual(5, MatematicasMCD.MCDcuatroNumeros(10, 15, 20, 25));
        }
        [TestMethod]
        public void Test_mcd_cuatro_numeros_negativos()
        {
            Assert.AreEqual(5, Math.Abs(MatematicasMCD.MCDcuatroNumeros(10, -15, -20, -25)));
            Assert.AreEqual(10, Math.Abs(MatematicasMCD.MCDcuatroNumeros(10, -20, -30, -40)));

        }
    }
}
