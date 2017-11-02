using System;
using System.Collections.Generic;
using System.Text;

namespace RangHo.XDLang.Model.Element
{
    internal class DivideElement : Element
    {
        public override string Content { get => "xDxD"; }

        public string Argument { get; private set; }

        public DivideElement(string arg)
        {
            this.Argument = arg;
        }

        public override void Execute(ref int value, ref Stack<int> param)
        {
            int operand = Element.Integerify(this.Argument);

            if (operand == 0)
                operand = param.Pop();

            value /= operand;
        }
    }
}
