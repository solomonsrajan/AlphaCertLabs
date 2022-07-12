using System;
using System.Collections.Generic;
using System.Text;

namespace CanWeFixItPersistence.Common
{
    public static class Constants
    {
        public const string DatabaseConnectionString = "CanWeFixItConnectionString";
        public const string ValuationFieldName = "DataValueTotal";
    }


    public static class SqlStatement
    {
        #region Instrument
        public const string AllActiveInstrument = "SELECT id, sedol, name, active FROM INSTRUMENT WHERE ACTIVE = 1";
        public const string AllInstrument = "SELECT id, sedol, name, active FROM INSTRUMENT";
        #endregion

        #region MarketData
        public const string AllActiveMarketData = "SELECT m.id, m.sedol, m.datavalue, m.active FROM MARKETDATA m WHERE m.ACTIVE = 1";
        public const string MarketDataValueTotal = "SELECT Sum(m.DataValue) Total FROM MARKETDATA m WHERE m.ACTIVE = 1";
        #endregion
    }


}
