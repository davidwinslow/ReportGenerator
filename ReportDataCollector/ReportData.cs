using System.Collections.Generic;
using Remotion.Collections;

namespace ReportDataCollector
{
    public class monkey
    {
        public string Name { get; set; }
    }

    public class ReportData
    {
        public Client Client { get; set; }
        public Background Background { get; set; }
        public Occupation Occupation { get; set; }
       
        public ReportData(Client client, Background background, Occupation occupation)
        {
            Client = client;
            Background = background;
            Occupation = occupation;
        }
    }
}