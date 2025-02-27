﻿using Npgsql;

namespace ArveSv.HelperTools;

public static class FlyIoUtilities
{
    public static string ConvertPostgresUrlToConnectionString(string pgUrl)
    {
        var uri = new Uri(pgUrl);
        var builder = new NpgsqlConnectionStringBuilder
        {
            Host = uri.Host,
            Port = uri.Port,
            Username = uri.UserInfo.Split(':')[0],
            Password = uri.UserInfo.Split(':')[1],
            Database = uri.LocalPath.TrimStart('/'),
        };

        if (uri.Query.IndexOf("sslmode=disable", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            builder.SslMode = SslMode.Disable;
        }

        return builder.ToString();
    }
}