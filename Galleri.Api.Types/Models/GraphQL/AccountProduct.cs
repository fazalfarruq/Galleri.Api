using GraphQL.Types;

namespace Galleri.Api.Types.Models.GraphQL
{
    public class AccountProduct : ObjectGraphType<AccountProductModel>
    {
        public AccountProduct()
        {
            Field(p => p.ReportingYear);
            Field(p => p.ReportingMonth);
            Field(p => p.InstitutionNumber);
            Field(p => p.AccountType);
            Field(p => p.SubType);
            Field(p => p.CountOfAccounts);
            Field(p => p.TotalBalance);
            Field(p => p.AccountsOpenYTD);
            Field(p => p.AccountsClosedYTD);
        }
    }
}
