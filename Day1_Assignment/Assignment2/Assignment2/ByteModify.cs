//What will happen if this code executes?
//int max = 500;
//for (byte i = 0; i < max; i++)
//{
//    WriteLine(i);
//}
//What code could you add (don’t change any of the preceding code) to warn us about the
//problem?
//using System;
//namespace Assignment2
//{
//    public class ByteModify
//    {
//        public static void test()
//        {
//            int max = 500;
//            for (byte i = 0; i < max; i++)
//            {
//                WriteLine(i);
//            }
//        }
//}

//}
//Create a console application and enter the preceding code. Run the console application
//and view the output. What happens?
//ANSWER: Exception claiming WriteLine does not exist would come up.
//        Besides, byte's max is 255 and this code will never end.

//What code could you add (don’t change any of the preceding code) to warn us about the
//problem?
//ANSWER: Add 'Console.' before 'WriteLine', change 'byte' to int or else.


