using WApp.Samples;
using Xunit;

namespace WApp.EntityFrameworkCore.Applications;

[Collection(WAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<WAppEntityFrameworkCoreTestModule>
{

}
