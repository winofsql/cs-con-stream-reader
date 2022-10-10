using System;
using System.IO;
using System.Text;

namespace cs_con_stream_reader
{
  class Program
  {
    static void Main(string[] args)
    {
      Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

      string? text = "";
      using( var sr = new StreamReader( "utf8n.csv", new UTF8Encoding() ) )
      using( var sw1 = new StreamWriter( "sjis.csv", false, Encoding.GetEncoding("shift_jis") ) )
      using( var sw2 = new StreamWriter( "utf8_bom.csv", false, new UTF8Encoding(true) ) )
      using( var sw3 = new StreamWriter( "ujis.csv", false, Encoding.GetEncoding("euc-jp") ) )
      using( var sw4 = new StreamWriter( "unicode.csv", false, new UnicodeEncoding() ) )
      {
        while ((text = sr.ReadLine()) != null) {
          sw1.WriteLine( text );
          sw2.WriteLine( text );
          sw3.WriteLine( text );
          sw4.WriteLine( text );
        }
      }
    }
  }
}
