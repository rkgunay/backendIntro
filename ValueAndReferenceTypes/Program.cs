using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            Console.WriteLine(number1 +" " + number2);

            int[] numbers1 = new int[] { 10,20,30};
            int[] numbers2 = new int[] { 100,200,300};

            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); 

        }
    }
}


// ref keyword is used to use value type variables as a reference type variables. 
// if i use add(ref number1, number2), number2 is in function variable. doesn't have an effect
// outside of the function. But if i change number1 inside the function. It will change the value of 
// number1 variable outside the function. 

// and theres this fella called "out" Its like "ref" but in ref, you should declare a value to that 
// variable. But "out" doesn't have that problem because it's not a picky bastard like "ref". 

// there's this thing called default parameters. It's easy. Just adding a value to parameter while
// declearing a function. Like add(int a, int b =10) But you should give right to left. Otherwise
// IDE will be mad at us. It looks at first parameter and it thinks, so this parameter has a default
// value. It expects other parameters to be with default value. And if all parameters has no value then
// you cant give the first parameter a value. I explained very terrible. That's my power hiring people.
// know your stuff. 

// Overloading -- Very very easy. 
// Make dozens of functions with same name but different number of parameters. Program will understand
// which function you want to use, just by counting the numbers of parameters you entered. Easy peasy. 


// Params -- Very practical
// DO NOT MAKE dozens of functions with same name but different number of parameters. 
// It wouldn't be DRY. Instead, use params. I want to write this because I don't want to forget
// It must be last parameter because it contains unknow number of parameters. 

/* 
    static add(params int[] numbers) 
    {
        return numbers.sum();
    }
 

    This functions can take many parameters. 10, 100, 1... doesn't matter. Better then making 
    100 functions. 
 */