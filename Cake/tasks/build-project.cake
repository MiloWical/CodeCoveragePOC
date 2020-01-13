Task("Build Project")
  .Does(() => 
{
  DotNetCoreBuild("../Pkg/Pkg.csproj");
});