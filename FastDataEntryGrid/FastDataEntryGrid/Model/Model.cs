using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastDataEntryGrid
{
    public class GridDetailItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public MyLookupCode LookupCode { get; set; }
        public bool BooValue { get; set; }
    }

    public class GridDetailItemAdapter
    {
        public GridDetailItem Data { get; }

        public GridDetailItemAdapter(GridDetailItem data)
        {
            Data = data;
        }

        public bool BoolVal
        {
            get => Data.BooValue;
            set { Data.BooValue = value; }
        }

        public int Quantity
        {
            get => Data.Quantity;
            set { Data.Quantity = value; }
        }

        public DateTime CreateDate
        {
            get => Data.CreateDate;
            set { Data.CreateDate = value; }
        }

        public string LookupValue => Data.LookupCode.Value;
            
        public string Name
        {
            get => Data.Name;
            set { Data.Name = value; }
        }
    }

    public class MyLookupCode
    {
        public int Code { get; set; }
        public string Value { get; set; }
    }
}
