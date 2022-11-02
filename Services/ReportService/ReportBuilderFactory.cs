using DAL.Domain;
using DAL.Repository;
using DataAccess;

namespace Services.ReportService
{
    public class ReportBuilderFactory
    {
        public static IReportBuilder GetCsvReportBuilder()
        {
            var context = new ReScraperContext();

            return new CsvReportBuilder(new EFRepository<Agency>(context), new EFRepository<Locality>(context));
        }
    }
}
