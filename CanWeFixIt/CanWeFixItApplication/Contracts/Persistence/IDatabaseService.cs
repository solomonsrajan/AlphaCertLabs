using CanWeFixItDomain;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CanWeFixItApplication.Contracts
{
    public interface IDatabaseService
    {
        void SetupDatabase();
        SqliteConnection GetConnection();
    }
}
