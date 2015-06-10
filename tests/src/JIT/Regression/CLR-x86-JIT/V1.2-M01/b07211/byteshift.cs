// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;
namespace Test
{
    public class ShiftTest
    {
        public byte data = 0xF0;
    }

    public class Test
    {
        public static int Main()
        {
            Console.WriteLine("Both results should be 15");
            // This works
            byte dataByte = 0xF0;
            dataByte >>= 4; // becomes 0x0F
            Console.WriteLine(dataByte);

            // This gives wrong result
            ShiftTest shiftTest = new ShiftTest();
            shiftTest.data >>= 4; // becomes 0xFF
            Console.WriteLine(shiftTest.data);

            if (shiftTest.data != 0xF)
                return 1;
            else
                return 100;
        }
    }

}


