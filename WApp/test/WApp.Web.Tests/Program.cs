using Microsoft.AspNetCore.Builder;
using WApp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<WAppWebTestModule>();

public partial class Program
{
}
