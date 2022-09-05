using System;
using System.IO;
using System.Text;

namespace cs_con_stream_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\app\workspace\csv\社員マスタ.csv";

            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using( var sr = new StreamReader(filepath,Encoding.GetEncoding("shift_jis")) ) {

                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
