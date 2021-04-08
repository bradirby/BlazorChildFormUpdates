using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatePicker.Shared.SelectBoxDemos
{
    public class MyLookupClass
    {
        public string DisplayValue { get; set; }
        public string KeyValue { get; set; }
    }

    public class MyGenericLookupClass<T>
    {
        public string DisplayValue { get; set; }
        public T KeyValue { get; set; }
    }

}
