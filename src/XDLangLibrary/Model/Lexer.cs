using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RangHo.XDLang.Model
{
    internal class Lexer
    {
        public StreamReader InputReader { get; private set; }

        public Lexer(Stream input)
        {
            this.InputReader = new StreamReader(input);
        }

        private bool IsValid(char target) => "XxDd".IndexOf(target) != -1;
    }
}
