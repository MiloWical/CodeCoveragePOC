#load "local:?path=tasks/build-project.cake"
#load "local:?path=tasks/run-tests.cake"

var target = Argument<string>("target", "Run POC");

Task("Run POC")
  .IsDependentOn("Build Project")
  .IsDependentOn("Run Tests");

RunTarget(target);