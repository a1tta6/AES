using System;
using System.Text;

namespace AES
{
    class Program
    {
        static void Print(byte[] byteStr)
        {
            for (int i = 0; i < byteStr.Length; i++)
            {
                Console.Write(byteStr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            byte[] messageByte = { 0x32, 0x43, 0xf6, 0xa8, 0x88, 0x5a, 0x30, 0x8d, 0x31, 0x31, 0x98, 0xa2, 0xe0, 0x37, 0x07, 0x34 };
            byte[] keyByte = { 0x2b, 0x7e, 0x15, 0x16, 0x28, 0xae, 0xd2, 0xa6, 0xab, 0xf7, 0x15, 0x88, 0x09, 0xcf, 0x4f, 0x3c };
            var chiperByte = AES.encrypt(messageByte, keyByte);
            var plainByte = AES.decrypt(chiperByte, keyByte);
            Print(messageByte);
            Print(plainByte);

        }
    }
}
