using System.Collections;
using MySqlConnector;
using PcVerwaltung.Model;
using PcVerwaltung.Helper;
using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Repositories;

public abstract class BaseRepository
{
    private readonly string _connectionString;
    public BaseRepository()
    {
        _connectionString = ConnectionHelper.ConnString(EConnection.ProductManagerDb.ToString());
    }
    protected MySqlConnection GetConnection()
    {
        return new MySqlConnection(_connectionString);
    }
}
