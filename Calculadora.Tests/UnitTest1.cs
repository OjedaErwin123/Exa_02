using Calculadora;

namespace TestDemo.Tests; 
public class UnitTest1 { 
[Fact] 
public void Form_Fuerza() { 
//Arrange 
double num1 = 18;
double num2 = 0.5;
double total = 9; 

//Act 
var result = Calculator.Fuerza(num1, num2); 
//Assert 
Assert.Equal(total, result); 
} 
[Fact] 
public void Para_Tra() { 
//Arrange 
double num1 = 6;
double num2 = 6;
double expectedResult = 36; 
//Act 
var result = Calculator.Trabajo(num1, num2); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
[Fact] 
public void Para_EnC() { 
//Arrange 
double num1 = 5; 
double num2 = 2; 
double expectedResult = 10; 
//Act 
var result = Calculator.Energy_Cine(num1, num2); 
//Assert 
Assert.Equal(expectedResult, result); 
} 
}