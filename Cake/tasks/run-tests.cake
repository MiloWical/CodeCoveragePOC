#addin "nuget:?package=Cake.Coverlet&version=2.3.4"

Task("Run Tests")
  .Does(() => 
{
  DotNetCoreBuild("../Pkg.Test/Pkg.Test.csproj");

  var testSettings = new DotNetCoreTestSettings{
    // NoBuild = true,
    // ArgumentCustomization = args=>args.Append(@"--collect:""XPlat Code Coverage""")
  };

  var coverletSettings = new CoverletSettings {
        CollectCoverage = true,
        CoverletOutputFormat = CoverletOutputFormat.cobertura,
        CoverletOutputDirectory = Directory(@".\coverage-results\"),
        CoverletOutputName = $"results-{DateTime.UtcNow:dd-MM-yyyy-HH-mm-ss-FFF}"
    };

  DotNetCoreTest("../Pkg.Test/Pkg.Test.csproj", testSettings, coverletSettings);
});