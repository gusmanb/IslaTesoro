using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SCREncoder
{
    class Program
    {
        const string template = @"
Dim {0}({1}) as uByte => {{ _
    {2} _
}}";
        static void Main(string[] args)
        {
            if (args == null || args.Length != 3)
            {
                Console.WriteLine("SCREEN$ file compressor by El Dr. Gusman.");
                Console.WriteLine("Usage: <Input file> <Output file> <Array name>");
                return;
            }

            string inFile = args[0];
            string outFile = args[1];
            string arrName = args[2];

            if (!File.Exists(inFile))
            {
                Console.WriteLine("Input file not found. Execute the program without arguments if you need help.");
                return;
            }

            if (File.Exists(outFile))
            {
                Console.WriteLine("Output file already exists. Execute the program without arguments if you need help.");
                return;
            }

            byte[] inData = File.ReadAllBytes(inFile);

            List<byte> outBuffer = new List<byte>();

            for (int buc = 0; buc < inData.Length; buc++)
            {
                byte current = inData[buc];

                if (buc + 1 < inData.Length)
                {
                    byte next = inData[buc + 1];

                    if (next == current)
                    {
                        int runLen = 0;
                        int pos = buc + 2;

                        while (pos < inData.Length && next == current && runLen < 255)
                        {
                            next = inData[pos];
                            runLen++;
                            pos++;
                        }

                        outBuffer.Add(current);
                        outBuffer.Add(current);

                        if (next == current)
                        {
                            buc = pos - 1;
                            outBuffer.Add((byte)runLen);
                        }
                        else
                        {
                            buc = pos - 2;
                            outBuffer.Add((byte)(runLen - 1));
                        }

                    }
                    else
                        outBuffer.Add(current);
                }
                else
                    outBuffer.Add(current);
            }

            StringBuilder sb = new StringBuilder(outBuffer.Count * 3);

            bool lastNew = false;

            for (int buc = 0; buc < outBuffer.Count; buc++)
            {
                sb.Append(outBuffer[buc].ToString().PadLeft(3, ' ') + ", ");

                if ((buc + 1) % 8 == 0)
                {
                    sb.Append("_\n    ");
                    lastNew = true;
                }
                else
                    lastNew = false;
            }

            if(lastNew)
                sb.Remove(sb.Length - 8, 8);
            else
                sb.Remove(sb.Length - 2, 2);

            File.WriteAllText(outFile, string.Format(template, arrName, outBuffer.Count - 1, sb));

            Console.WriteLine("Screen compressed");
        }
    }
}

