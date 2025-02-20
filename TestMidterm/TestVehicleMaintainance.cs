using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibrary1;
using static ClassLibrary1.VehicleMantainanceForm;
using System.Reflection;
using System.Management.Instrumentation;



namespace TestMidterm
{
    [TestFixture]
    public class TestVehicleMaintainance
    {
        //valid model
      
        [Test]
        public void CheckModel_Corolla_ValidNumberOfChar()
        {
            // Arrange
            int numberChar;
            Vehicle vehicle = new Vehicle("Corolla", 2025, 10000);

            string model = vehicle.Model;

            // Act
            numberChar = model.Length;


            // Assert
            Assert.That(numberChar, Is.LessThan(15));

        }
    }
}
