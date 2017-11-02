using System;
using System.Collections.Generic;
using System.Text;

using RangHo.XDLang.Model;

namespace RangHo.XDLang.Model.Element
{
    internal class LoopElement : Element
    {
        public override string Content { get => "Xdxd...xdxD"; }

        public ObjectContainer DataStructure { get; private set; }

        public Element[] Children { get; private set; }

        public LoopElement(Element[] children, ObjectContainer container)
        {
            this.Children = children;
            this.DataStructure = container;
        }

        public override void Execute(ref int value, ref Stack<int> param)
        {
            
        }
    }
}
