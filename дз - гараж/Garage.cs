using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using дз___гараж;

namespace дз___гараж
{
    public class garage
    {
        public class Garage
        {
            public Garage()
            {
                list = new List<Auto>();
            }

            private List<Auto> list;
            public List<Auto> List { get { return list; } }
            public Auto this[int index]
            {
                get
                {
                    if (index < 0 || index >= list.Count)
                    {
                        return null;
                    }
                    else
                    {
                        return list[index];
                    }

                }
            }
            public void AddAuto(Auto mobile)
            {
                list.Add(mobile);
            }
            public void EraseAuto(int index)
            {
                list.RemoveAt(index-1);
            }
        }
    }
}