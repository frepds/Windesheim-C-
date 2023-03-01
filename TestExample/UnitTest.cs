using Data;

namespace TestExample;
using NUnit.Framework;

public class Tests
{
    //Assert.That(Calculator.Add(), Is.EqualTo());
    [Test] 
    public void AddingTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Calculator.Add(1,1), Is.EqualTo(2));
            Assert.That(Calculator.Add(2,2), Is.EqualTo(4)); 
            Assert.That(Calculator.Add(3,3), Is.EqualTo(6));
            Assert.That(Calculator.Add(4,4), Is.EqualTo(8));
            Assert.That(Calculator.Add(5,5), Is.EqualTo(10));
        });
    }
        
      [Test] 
      public void SubtractingTest()
      { 
          Assert.That(Calculator.Subtract(8,2), Is.EqualTo(6));
      }
      
      [Test] 
      public void Multiplication() 
      { 
          Assert.That(Calculator.Multiply(4,4), Is.EqualTo(16));
      }
      
      [Test] 
      public void DivisionTest() 
      { 
          Assert.That(Calculator.Division(20,4), Is.EqualTo(5));
      }
      
      [Test] 
      public void ModuloTest() 
      { 
          Assert.That(Calculator.Modulo(12,4), Is.EqualTo(0));
      }

      [Test]
      public void CelsiusTest()
      {
          Assert.That(Calculator.CelsiusToFahrenheit(0), Is.EqualTo(32));
      }

      [Test]
      public void FahrenheitTest()
      {
          Assert.That(Calculator.FahrenheitToCelsius(41), Is.EqualTo(5));
      }
        
      //Text class
      [Test] 
      public void NameTest() 
      { 
          Assert.That(Text.Name("Example"), Is.EqualTo("Hello Example"));
      }

      [Test]
      public void FullNameTest()
      {
          Assert.That(Text.FullName("FirstName", "LastName"), Is.EqualTo("Hello FirstName LastName"));
      }

}
