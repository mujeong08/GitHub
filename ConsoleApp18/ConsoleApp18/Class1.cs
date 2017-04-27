using System;
using System.IO;

namespace ConsoleApp18
{
    class Class1
    {
        static void main()
        {
            BinaryWriter dataout;
            BinaryReader datain;

            try
            {
                dataout = new BinaryWriter(new FileStream("testData",FileMode.Create));
            }
            catch(IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            try
            {
                datain = new BinaryReader(new FileStream("testData", FileMode.Create));
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
        }
    }
}