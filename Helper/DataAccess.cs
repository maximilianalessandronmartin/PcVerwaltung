using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySqlConnector;
using PcVerwaltung.Model;
using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Helper;

public class DataAccess
{
    
    public void CreateUser(User user)
    {
        using (MySqlConnection connection =
               new MySqlConnection(ConnectionHelper.ConnString(EConnection.ProductManagerDb.ToString())))
        {
            connection.Open();
            
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText =
                "insert into users (firstname, lastname, username, userpw, mail, lastlogin) values (@firstname, @lastname, @username, @userpw, @mail, @lastlogin)";
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = user.FirstName;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = user.LastName;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.UserName;
            command.Parameters.Add("@userpw", MySqlDbType.VarChar).Value =  user.Password;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = user.Mail;
            command.Parameters.Add("@lastlogin", MySqlDbType.DateTime).Value = user.LastLogin;
            command.ExecuteNonQuery();
        }
    }

    public List<User> GetUsers()
    {
        var users = new List<User>();

        using (MySqlConnection connection =
               new MySqlConnection(ConnectionHelper.ConnString(EConnection.ProductManagerDb.ToString())))
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from users";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var userid = reader.GetInt32(0);
                var firstname = reader.GetString(1);
                var lastname = reader.GetString(2);
                var username = reader.GetString(3);
                var password = reader.GetString(4);
                var mail = reader.GetString(5);
                var lastLogin = reader.GetDateTime(6);
                var user = new User(userid, firstname, lastname, username, password, mail, lastLogin);
                users.Add(user);
            }
        }

        return users;
    }
}