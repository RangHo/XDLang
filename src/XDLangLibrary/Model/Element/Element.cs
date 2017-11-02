using System;
using System.Collections.Generic;
using System.Text;

namespace RangHo.XDLang.Model.Element
{
    internal abstract class Element
    {
        public abstract string Content { get; }

        public abstract void Execute(ref int value, ref Stack<int> param);

        public static bool IsValidSequence(string target) => "XDXD".Equals(target.ToUpper());

        public static int Integerify(string source)
        {
            if (IsValidSequence(source))
            {
                string binaryString = source.Replace('X', '1')
                                            .Replace('D', '1')
                                            .Replace('x', '0')
                                            .Replace('d', '0');
                return int.Parse(binaryString);
            }

            return default(int);
        }
    }
}
