using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VerketteteListe1
{
    public class VerketteteListe<T>
    {
        private int anzElement = 0;
        public int AnzElemente
        {
            get
            {
                return anzElement;
            }
        }

        private ListElement<T> erstesElement;
        private ListElement<T> letztesElement;

        public VerketteteListe()
        {
        }

        public VerketteteListe(T first)
        {
            erstesElement = new ListElement<T>(first);
        }

        public void Add(T wert)
        {
            letztesElement = new ListElement<T>(wert);
            anzElement++;

        }

        public T GetElementData(int index)
        {
            if (index == 0)
            {
                return erstesElement.Data;
            }
            else if (index > 0 && index < anzElement - 1)
            {
                return letztesElement.Data;
            }
            else
            {
                throw new Exception($"Ungültiger Index: {index}");
            }
        }

    }
}
