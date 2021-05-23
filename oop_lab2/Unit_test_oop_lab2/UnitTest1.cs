using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Unit.Test.Builder.Pattern
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Add_ingredient()
        {
            string expected = "Ice cream ingredients: foot, cloud\n";
            var result = new IceCream();
            result.Add("foot");
            result.Add("cloud");
            Assert.AreEqual(expected, result.ListIngredients());
        }

        [Test]
        public void Test_ChocoTartarosBuilder_BuildCup()
        {
            string expected = "Ice cream ingredients: bubble waffle\n";
            var result = new ChocoTartarosBuilder();
            result.BuildCup();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_ChocoTartarosBuilder_BuildFlavor()
        {
            string expected = "Ice cream ingredients: dark chocolate ball\n";
            var result = new ChocoTartarosBuilder();
            result.BuildFlavor();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_ChocoTartarosBuilder_BuildTopping()
        {
            string expected = "Ice cream ingredients: chocolate chip\n";
            var result = new ChocoTartarosBuilder();
            result.BuildTopping();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_VanillaNirvanaBuilder_BuildCup()
        {
            string expected = "Ice cream ingredients: waffle cone\n";
            var result = new VanillaNirvanaBuilder();
            result.BuildCup();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_VanillaNirvanaBuilder_BuildFlavor()
        {
            string expected = "Ice cream ingredients: sweet vanilla ball\n";
            var result = new VanillaNirvanaBuilder();
            result.BuildFlavor();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_VanillaNirvanaBuilder_BuildTopping()
        {
            string expected = "Ice cream ingredients: flaked coconut\n";
            var result = new VanillaNirvanaBuilder();
            result.BuildTopping();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_Director_ChocoTartaros_BuildSimpleIceCream()
        {
            var director = new Director();
            var result = new ChocoTartarosBuilder();
            director.Builder = result;
            string expected = "Ice cream ingredients: bubble waffle, dark chocolate ball\n";
            director.BuildSimpleIceCream();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_Director_ChocoTartaros_BuildFullFeaturedIceCream()
        {
            var director = new Director();
            var result = new ChocoTartarosBuilder();
            director.Builder = result;
            string expected = "Ice cream ingredients: bubble waffle, dark chocolate ball, chocolate chip\n";
            director.BuildFullFeaturedIceCream();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_Director_VanillaNirvana_BuildSimpleIceCream()
        {
            var director = new Director();
            var result = new VanillaNirvanaBuilder();
            director.Builder = result;
            string expected = "Ice cream ingredients: waffle cone, sweet vanilla ball\n";
            director.BuildSimpleIceCream();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }

        [Test]
        public void Test_Director_VanillaNirvana_BuildFullFeaturedIceCream()
        {
            var director = new Director();
            var result = new VanillaNirvanaBuilder();
            director.Builder = result;
            string expected = "Ice cream ingredients: waffle cone, sweet vanilla ball, flaked coconut\n";
            director.BuildFullFeaturedIceCream();
            Assert.AreEqual(expected, result.GetProduct().ListIngredients());
        }
    }
}