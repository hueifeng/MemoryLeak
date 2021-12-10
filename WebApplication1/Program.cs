using ConsoleApp3;
using Magicodes.ExporterAndImporter.Core;
using Magicodes.ExporterAndImporter.Excel;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/excel", async content =>
{
    IExporter exporter = new ExcelExporter();
    string path = Path.Combine(Directory.GetCurrentDirectory(), "test.xlsx");
    List<TestDto> list = new();

    for (int i = 0; i < 400; i++)
    {
        list.Add(new TestDto { ImageUrl = "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fup.enterdesk.com%2Fedpic_source%2F53%2F0a%2Fda%2F530adad966630fce548cd408237ff200.jpg&refer=http%3A%2F%2Fup.enterdesk.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=jpeg?sec=1641193100&t=417a589da8c9ba3103ed74c33fbd6c70" });
    }
    Stopwatch stopwatch = Stopwatch.StartNew();
    await exporter.Export(path, list);
    stopwatch.Stop();
    await content.Response.WriteAsync(stopwatch.Elapsed.TotalSeconds.ToString());
});
app.Run();
