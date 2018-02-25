
    class Program
    {
        static void Main(string[] args)
        {
                using (var sw = new StreamWriter(@"Sample_CSV.csv"))
                {
                    var writer = new CsvWriter(sw);
                List<Model> records = new List<Model>
                    {
                        new Model{ Item1="1", Item2 ="2",Item3 ="3",Item4="4", Item5="5"},
                        new Model{ Item1="1", Item2 ="2",Item3 ="3",Item4="4", Item5="5"},
                        new Model{ Item1="1", Item2 ="2",Item3 ="3",Item4="4", Item5="5"},
                        new Model{ Item1="1", Item2 ="2",Item3 ="3",Item4="4", Item5="5"},
                    };
                    //CSVReader will now read the whole file into an enumerable
                    //IEnumerable records = reader.GetRecords<DataRecord>().ToList();

                    //Write the entire contents of the CSV file into another
                    writer.WriteRecords(records);

                    //Now we will write the data into the same output file but will do it 
                    //Using two methods.  The first is writing the entire record.  The second
                    //method writes individual fields.  Note you must call NextRecord method after 
                    //using Writefield to terminate the record.

                    //Note that WriteRecords will write a header record for you automatically.  If you 
                    //are not using the WriteRecords method and you want to a header, you must call the 
                    //Writeheader method like the following:
                    //
                    //writer.WriteHeader<DataRecord>();
                    //
                    //Do not use WriteHeader as WriteRecords will have done that already.

                    //foreach (DataRecord record in records)
                    //{
                    //    //Write entire current record
                    //    writer.WriteRecord(record);

                    //    //write record field by field
                    //    writer.WriteField(record.CommonName);
                    //    writer.WriteField(record.FormalName);
                    //    writer.WriteField(record.TelephoneCode);
                    //    writer.WriteField(record.CountryCode);
                    //    //ensure you write end of record when you are using WriteField method
                    //    writer.NextRecord();
                    //}
                }
            
        }
    }

    public class Model
    {
        public string Item1 { get; set; }

        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }

    }
