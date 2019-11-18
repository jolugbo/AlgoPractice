using System;
using System.Text;
using System.Linq;
namespace AlgoTut
{
    class StringClass
    {
        public void StringMethod()
        {
            string Message = "Hello, World";
            for (int i = 0; i < Message.Length; i++)
            {
                if (i > 6 && i <12)
                {
                    Console.Write(Message[i]);
                }
            }
            Console.WriteLine();
            Message = "now has new message : 123";
            string num = Message.Substring(Message.IndexOf(":") + 2);
            int.TryParse(num,out var a);
            Console.WriteLine(a);

            ReadOnlySpan<char> mspSpan = Message;
            ReadOnlySpan<char> numSpan = mspSpan.Slice(mspSpan.IndexOf(":")+2);
            int.TryParse(numSpan,out var b);
            Console.WriteLine(b);

            string x = "new string";
            string y = "new string";
            Console.WriteLine(object.ReferenceEquals(x,y));

            //Memory<char> mem = MemoryMarshal.AsMemory(x.AsMemory());
            //mem.Span[5] = 'Z';
            var sBuilder = new StringBuilder();
            foreach (int i in Enumerable.Range(1,10))
            {
                sBuilder.Append(i.ToString());
            }
            Console.WriteLine(sBuilder);
        }
    }
}