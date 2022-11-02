using System.Text;

namespace Services.ReportService
{
    public interface IReportBuilder
    {
        StringBuilder BuildAgenciesCsvReport();

        StringBuilder BuildLocalitiesCsvReport();
    }
}
