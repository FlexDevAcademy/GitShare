using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitShare
{
    public class Phone
    {
        private string OwnerId { get; set; }
        public string OwnerSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneModel { get; set; }
        private string Tariff { get; set; }

        private string Network { get; set; }
    }
}
