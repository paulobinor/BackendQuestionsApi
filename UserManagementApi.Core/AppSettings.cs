using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETM.Core.Helpers
{
    public class AppSettings
    {
        public string JobTicketReportDocPath { get; set; }
        public string LoadOutReportDocPath { get; set; }
        public string CredentialsPath { get; set; }

        public string selectDatabase { get; set; }
       
        public string LoanServiceUrl { get; set; }
    }
}
