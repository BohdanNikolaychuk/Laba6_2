using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_2
{
    class Day : Exhibition,Sum
    {
        public string day { get; set; }
        public int nubmers { get; set; }
        public string comment { get; set; }


       public override void A(List<Day> list)
        {
            list.Sort(delegate (Day t1, Day t2)   // sort
            {
                return t2.nubmers.CompareTo(t1.nubmers);

            });

            foreach (Day el in list)
            {
                Console.WriteLine("День з найбiльшою кiлькiстю вiдвiдувачiв=" + el.day + "\n" + "__________________________________________________________");
                break;
            }

            list.Sort(delegate (Day t1, Day t2)   // sort
            {
                return t1.comment.CompareTo(t2.comment);

            });

            foreach (Day el in list)
            {
                Console.WriteLine("день з найбiльшою кiлькістю слiв у коментарi=" + el.day + "\n" + "__________________________________________________________");
                break;
            }

        }

        public override void C(List<Day> list)
        {
            int sum = 0;
            foreach (Day item in list)
            {
                sum += item.nubmers;

            }
            Console.WriteLine("Сумарна кiлькiсть вiдвiдувачiв = " + sum);
        }
    }
}
