using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastDataEntryGrid
{
    public class ViewDataContainer
    {
        public List<GridDetailItem> Items { get; set; } 
        public List<MyLookupCode> Codes { get; set;}

        public ViewDataContainer()
        {
            Codes = new List<MyLookupCode>();
            Codes.Add(new MyLookupCode(){Code = 1, Value = "First lookup value"});
            Codes.Add(new MyLookupCode(){Code = 2, Value = "Second lookup value"});
            Codes.Add(new MyLookupCode(){Code = 3, Value = "Third lookup value"});
            Codes.Add(new MyLookupCode(){Code = 4, Value = "Fourth lookup value" });

            Items = new List<GridDetailItem>();
            Items.Add(new GridDetailItem(){Name = "First Item",CreateDate = DateTime.Now, Quantity = 1, LookupCode = Codes.First(x => x.Code == 1)} );
            Items.Add(new GridDetailItem(){Name = "Second Item",CreateDate = DateTime.Now, Quantity = 2, LookupCode = Codes.First(x => x.Code == 2)} );
            Items.Add(new GridDetailItem(){Name = "Third Item",CreateDate = DateTime.Now, Quantity = 3, LookupCode = Codes.First(x => x.Code == 3)} );
            Items.Add(new GridDetailItem(){Name = "Fourth Item",CreateDate = DateTime.Now, Quantity = 4, LookupCode = Codes.First(x => x.Code == 4)} );
            Items.Add(new GridDetailItem(){Name = "Fifth Item",CreateDate = DateTime.Now, Quantity = 5, LookupCode = Codes.First(x => x.Code == 1)} );
            Items.Add(new GridDetailItem(){Name = "Sixth Item",CreateDate = DateTime.Now, Quantity = 6, LookupCode = Codes.First(x => x.Code == 2)} );
            Items.Add(new GridDetailItem(){Name = "Seventh Item",CreateDate = DateTime.Now, Quantity = 7, LookupCode = Codes.First(x => x.Code == 3)} );
            Items.Add(new GridDetailItem(){Name = "Eighth Item",CreateDate = DateTime.Now, Quantity = 8, LookupCode = Codes.First(x => x.Code == 4)} );
        }
    }
}
