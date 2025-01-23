using ArveSv.HelperTools;

namespace ArveSv.HelperTools.Test;

public class TestFlyIoUtilities
{
    [Test]
    public async Task TestConvertPostgresUrlToConnectionString1()
    {
        var pgUrl = "postgres://user:password@localhost:5432/dbname";
        var connectionString = FlyIoUtilities.ConvertPostgresUrlToConnectionString(pgUrl);
        await Assert.That(connectionString).IsEqualTo("Host=localhost;Port=5432;Username=user;Password=password;Database=dbname;SSL Mode=Require");
    }

    [Test]
    public async Task TestConvertPostgresUrlToConnectionString2()
    {
        var pgUrl = "postgres://bruker:passord@dbserver:9876/databasenavn";
        var connectionString = FlyIoUtilities.ConvertPostgresUrlToConnectionString(pgUrl);
        await Assert.That(connectionString).IsEqualTo("Host=dbserver;Port=9876;Username=bruker;Password=passord;Database=databasenavn;SSL Mode=Require");
    }

}
