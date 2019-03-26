using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace Monolithic.Adapter.Utilities
{
    public class CSVDeserializer
    {

        public IEnumerable<T> Decerialize<T> ( string CSV) where T : class
        {
            TextReader TextReader = new StringReader(CSV);
            var csv = new CsvReader(TextReader);
            csv.Configuration.HeaderValidated = null;
            csv.Configuration.MissingFieldFound = null;
            var records = csv.GetRecords<T>();
            return records;
        }
    }
}
