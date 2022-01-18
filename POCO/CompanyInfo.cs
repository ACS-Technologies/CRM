using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class CompanyInfo
    {
        public int Id { get; set; }
        public int CompanyTaxNumber { get; set; }
        public int workshopId { get; set; }
        public string CompanySecondaryName { get; set; }
        public string CompanyPrimaryName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
        public string FooterLine1 { get; set; }
        public string FooterLine2 { get; set; }
        public Byte[] Img { get; set; }
        public List<CompanyBranch> ColCompanyBranches { get; set; }
        public string Host { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public bool Ssl { get; set; }
        public int CashDeportation { get; set; }
        public int CountryId { get; set; }
        public string ISOCode { get; set; }
        public string CountryCode { get; set; }
        public int DefaultForOnline { get; set; }
        public int CurrencyIDH { get; set; }

    }
}
