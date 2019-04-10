using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeTest
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
         public void Checking_UseStock_Expected_Return9()
         {
                //Arrange
            Inventory inventory = new Inventory();
            Recipe recipe = new Recipe();
            Lemons lemons = new Lemons();
            Sugar sugar = new Sugar();
            Ice ice = new Ice();
            int expected = 12;
            lemons.ItemCount = 12;
            sugar.ItemCount = 12;
            ice.ItemCount = 12;
            recipe.lem = 3;
            recipe.sug = 3;
            recipe.ice = 3;
            int expectedLemonResult = lemons.ItemCount-recipe.lem;
            int expectedSugarResult = sugar.ItemCount-recipe.sug;
            int expectedIceResult = ice.ItemCount-recipe.ice;



            //Act
            inventory.UseStock();


            //Assert
            Assert.AreEqual(expected, lemons.ItemCount);
            
         }
    }
}
