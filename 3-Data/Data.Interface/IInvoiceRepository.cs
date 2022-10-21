using SoupLocal._1_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoupLocal._3_Data.Data.Interface
{
    public interface IInvoiceRepository
    {
        public string CreateInvoice();
        public string CreateInvoiceCourseRelation();
        public string GetInvoice();
        public string GetDetailInvoice();
        public string GetMyClass();
        public string GetPrice();
        public string GetLastInvNum();
   /*     public Task<Invoice> UpdateInvoice(Invoice invoice);
        public Task<bool> DeleteInvoice(int id);*/
    }
}
