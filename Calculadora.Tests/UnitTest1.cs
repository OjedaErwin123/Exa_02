using Calculadora;

namespace TestDemo.Tests; 
public class UnitTest1 { 
[Fact] 
public void Form_Fuerza() { 
//Arrange 
var num1 = 6.0;
var num2 = 6.0;
var total = 25.0; 

//Act 
var result = Calculator.Fuerza(num1, num2); 
//Assert 
Assert.Equal(total, result); 
} 
[Fact] 
public void Para_Tra() { 
//Arrange 
var num1 = 6.0;
var num2 = 6.0;
var expectedResult = 25.0; 
//Act 
var result = Calculator.Trabajo(num1, num2); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void SquareOfNumberTest() { 
//Arrange 
var num1 = 5; 
var num2 = 5; 
var expectedResult = 25; 
//Act 
var result = Calculator.Energy_Cine(num1, num2); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
}