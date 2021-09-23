using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Value_Types
{
    public enum PastryType 
    {
        Cake = 0,
        Danish,
        Croissant,
        Donut,
        Scone,
        Backlava,
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ImitAndDeclareVariables()
        {
            //Declaring a variable
            int numOne;
            numOne = 1;
            //Declaring and Initializing a Variable
            int numTwo = 2;
            //Variables
            //named location in computer memory AKA RAM
        }
        [TestMethod]
        public void ValueTypeVariables()
        {
            //Whole Numbers
            byte byteExample = 255;
            sbyte sbytExample = -128;
            short shortEample = 32267;
            Int16 anotherShortExample = 32000;
            int inMin = -2147483648;
            int intMax = 2147483647;
            Int32 anotheIntExample = 123456;
            long longMax = 9223372030854775807;
            Int64 longMin = -9223372030854775807;



            //Decimals
            double doubleExample = 1.23456789;
            float floatExample = 1.23456789f;
            decimal decimalEample = 1.23456789m;

            Console.WriteLine(doubleExample);

            //Character
            char charExample = 'a';
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n';


            //Bool
            bool isHungry = true;
            bool isTired = false;


            //Enum
            PastryType myPastry = PastryType.Backlava;

            //Structs
            DateTime today = DateTime.Now;
            Console.WriteLine(today);


           






        }
    }
}
