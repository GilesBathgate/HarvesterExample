using System;
using WixSharp;

// DON'T FORGET to update NuGet package "WixSharp".
// NuGet console: Update-Package WixSharp
// NuGet Manager UI: updates tab

namespace WixSharpSetup
{
    class Program
    {
        static void Main()
        {
            var project = new ManagedProject("MyProduct",
                             new Dir(@"%ProgramFiles%\My Company\My Product",
                                 new File("Program.cs")));

            project.GUID = new Guid("6fe30b47-2577-43ad-9095-1861ba25889b");

            //custom set of standard UI dialogs
            project.ManagedUI = new ManagedUI();

            project.ManagedUI = ManagedUI.Default;

            project.OutDir = @"..\";

            var ahHa = @"..\ExampleConsoleApp\bin\Debug"; // I had forgotten that currently this directory
            //has to be hard coded but actually it could be inferred by parsing the .csproj

            var harvester = new Harvester(project, ahHa, "INSTALLDIR");
            harvester.AddProject(new ProjectReference(@"..\ExampleConsoleApp\ExampleConsoleApp.csproj"));

            project.BuildMsi();
        }

    }
}