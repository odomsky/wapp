using WApp.Samples;
using Xunit;

namespace WApp.EntityFrameworkCore.Domains;

[Collection(WAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<WAppEntityFrameworkCoreTestModule>
{

}
