namespace Calculadora;

public class Calculator
{
public static double Fuerza(double num1, double num2) 
{ 
    double F;
    F= num1*num2;
    return F; 
} 
public static double Trabajo(double num1, double num2) 
{ 
    double t;
    t= num1*num2;
    return t; 
} 
public static double Energy_Cine(double num1, double num2) 
{ 
    double Ec;
    Ec= 0.5*num1*Math.Pow(num2,2);
    return Ec; 
} 

}



//F = m * a
//W = F * d.
//E = 0.5 * m * v^2