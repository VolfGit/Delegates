//Задание: Работа с делегатами в C#

//Создайте класс MathOperations, в котором определены
//методы для выполнения математических операций, таких как
//сложение, вычитание, умножение и деление.

//Определите делегаты для каждой из этих операций.
//Например, для сложения создайте делегат
//delegate int AdditionDelegate(int a, int b);.

//Создайте класс Calculator, который будет содержать методы для вызова
//каждой математической операции.
//Эти методы должны принимать делегаты в качестве параметров и вызывать их,
//передавая соответствующие аргументы.

//В методе Main программы создайте экземпляр класса
//MathOperations, экземпляр класса Calculator и выполните несколько
//математических операций, передавая соответствующие делегаты и выводя
//результаты на консоль.

//Это задание также позволит вам познакомиться с основами работы
//с делегатами в C#. Если у вас есть вопросы или нужна дополнительная помощь,
//не стесняйтесь спрашивать!


//Создайте класс MathOperations, в котором определены методы для выполнения 
//    математических операций: сложение, вычитание, умножение и деление.

//Определите делегат, который может принимать несколько методов с сигнатурой 
//int SomeOperation(int a, int b).

//Создайте в классе Calculator метод, который принимает делегат и два числа. 
//Этот метод должен последовательно вызывать методы, переданные в делегате,
//используя переданные числа в качестве аргументов.

//В методе Main программы создайте экземпляр класса MathOperations, 
//экземпляр класса Calculator и создайте делегат, добавив в него несколько 
//методов из MathOperations. Вызовите метод Calculator, передав этот делегат
//и два числа в качестве аргументов, и выведите результат на консоль.
public class Methoperations
{
    public int TestPlus(int x, int y)
    {
        Console.WriteLine("Plus");
        return x + y;
    }
    public int TestMinus(int x, int y)
    {
        Console.WriteLine("Minus");
        return x - y;
    }
    public int TestMultiply(int x, int y)
    {
        Console.WriteLine("Multiply");
        return x * y;
    }
    public int TestDivide(int x, int y)
    {
        Console.WriteLine("Divide");
        return x / y;
       
    }


}
public delegate int SomeOperation(int a,int b);
public delegate int AdditionDelegate(int a, int b);
public delegate int MinusDelegate(int a, int b);
public delegate int MultiplyDelegate(int a, int b);
public delegate int DivideDelegate(int a, int b);
public class Calculator
{
    public int TestPlus1(int x, int y, AdditionDelegate op)
    {
        return op.Invoke(x, y);
    }
    public int TestMinus(int x, int y, MinusDelegate op)
    {
        return op.Invoke(x, y);
    }
    public int TestMultiply(int x, int y, MultiplyDelegate op)
    {
        return op.Invoke(x, y);
    }
    public int TestDivide(int x, int y, DivideDelegate op)
    {
        return op.Invoke(x, y);
    }

    public int TestDivide1(int x, int y, SomeOperation op)
    {
        return op.Invoke(x, y);

    }
    
   
}
public class Program
{
    public static void Main(string[] args)
    {
        Methoperations methoperations = new Methoperations();
        //Console.WriteLine(methoperations.TestMultiply(5, 2));
        //Console.WriteLine(methoperations.TestMinus(5, 2));
        //Console.WriteLine(methoperations.TestDivide(5, 2));
        //Console.WriteLine(methoperations.TestPlus(5, 2));

        //Calculator calculator = new Calculator();
        //AdditionDelegate additionDelegate = new AdditionDelegate(methoperations.TestPlus);
        //Console.WriteLine(calculator.TestPlus1(5, 2, additionDelegate));
        //DivideDelegate divideDelegate = new DivideDelegate(methoperations.TestDivide);
        //Console.WriteLine(calculator.TestDivide(5, 2, divideDelegate));
        //MultiplyDelegate multiply = new MultiplyDelegate(methoperations.TestMultiply);
        //Console.WriteLine(calculator.TestMultiply(10, 3, multiply));
        //MinusDelegate minusdelegate = new MinusDelegate(methoperations.TestMinus);
        //Console.WriteLine(calculator.TestMinus(10, 2, minusdelegate));

        SomeOperation someOperation = new SomeOperation(methoperations.TestMultiply);
        someOperation += methoperations.TestMinus;
        Console.WriteLine(someOperation.Invoke(5,2));
        Console.WriteLine(someOperation(1, 2));
        someOperation(1,2);
        
        //

    }
}