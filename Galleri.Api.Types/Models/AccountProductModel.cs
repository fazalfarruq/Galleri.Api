using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Galleri.Api.Types.Models
{
    public class AccountProductModel
    {
        [JsonProperty("REPORTING_YEAR")]
        public int ReportingYear { get; set; }

        [JsonProperty("REPORTING_MONTH")]
        public int ReportingMonth { get; set; }

        [JsonProperty("INSTITUTION_NBR")]
        public string InstitutionNumber { get; set; }

        [JsonProperty("ACCOUNT_TYPE")]
        public string AccountType { get; set; }

        [JsonProperty("SUB_TYPE")]
        public string SubType { get; set; }

        [JsonProperty("CountOfAccounts")]
        public int CountOfAccounts { get; set; }

        [JsonProperty("TotalBalance")]
        public double TotalBalance { get; set; }

        [JsonProperty("AccountsOpenedYTD")]
        public int AccountsOpenYTD { get; set; }

        [JsonProperty("AccountsClosedYTD")]
        public int AccountsClosedYTD { get; set; }
    }
}
