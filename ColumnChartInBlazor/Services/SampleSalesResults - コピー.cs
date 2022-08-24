namespace ColumnChartInBlazor.Services
{
    public class SampleSalesResults
    {
        public static List<SalesResult> Create()
        {
            List<SalesResult> _results = new()
            {
                new() { Name = "茂木", Result = 87.4 },
                new() { Name = "滝沢", Result = 31.8 },
                new() { Name = "東海林", Result = 67.3 },
                new() { Name = "丸山", Result = 65.4 },
                new() { Name = "長谷川", Result = 83.5 },
                new() { Name = "松山", Result = 154.8 },
                new() { Name = "沢村", Result = 105.6 },
                new() { Name = "神保", Result = 67.7 },
                new() { Name = "木田", Result = 57.9 },
                new() { Name = "勝田", Result = 85 }
            };
            return _results;
        }
    }

    public class SalesResult
    {
        public double Result { get; set; }
        public string? Name { get; set; }
    }
}
