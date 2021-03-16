using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerketteteListe1
{
    public class ListElement<T>
    {
        private T data;

        public T Data
        {
            get
            {
                return data;
            }
        }

        private ListElement<T> nextElement;

        public ListElement<T> NextElement
        {
            get
            {
                return nextElement;
            }
        }

        public ListElement(T newData)
        {
            data = newData;
        }

    }
}
