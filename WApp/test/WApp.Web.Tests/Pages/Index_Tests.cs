using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace WApp.Pages;

public class Index_Tests : WAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
