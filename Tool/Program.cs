using System.CommandLine;
using ArveSv.HelperTools;

var rootCommand = new RootCommand("Various utilities");

var pgUrlCommand = new Command("pgurl", "Translates a postgres url to a .NET postgres connection string");

var urlArgument = new Argument<string>(
    name: "url",
    description: "The url to be parsed. Empty or -- means reading from stdin",
    getDefaultValue: () => "--"
);

pgUrlCommand.Add(urlArgument);

pgUrlCommand.SetHandler((string urlArgumentValue) =>
{
    var connectionString = FlyIoUtilities.ConvertPostgresUrlToConnectionString(urlArgumentValue);
    Console.WriteLine(connectionString);
}, urlArgument);

rootCommand.AddCommand(pgUrlCommand);

rootCommand.Invoke(args);
