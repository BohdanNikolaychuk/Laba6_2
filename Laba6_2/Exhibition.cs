using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_2
{
    abstract class Exhibition
    {
        public string name { get; set; }
        public string secondname { get; set; }
        public abstract void A(List<Day> list);
        public abstract void C(List<Day> list);
    }
}
