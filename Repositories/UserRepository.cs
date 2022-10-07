using System;
using System.Collections.Generic;
using System.Net;
using MySqlConnector;
using PcVerwaltung.Exceptions;
using PcVerwaltung.Helper;
using PcVerwaltung.Model;
using PcVerwaltung.Model.Enums;

namespace PcVerwaltung.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
   
        public void Add(User user)
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

        public bool AuthenticateUser(NetworkCredential credential)
        {
            try
            {
                bool validUser;
                using var connection = GetConnection();
                using var command = new MySqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from users where username=@username and userpw=@password";
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = credential.UserName;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = ConnectionHelper.GetSHA384(credential.UserName, credential.Password);
                validUser = command.ExecuteScalar() == null ? false : true;
                return validUser;

            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new UserNotFoundException("User could not be found");
            }

            
        }

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetByAll()
        {
            throw new NotImplementedException();
        }
        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
        public User GetByUsername(string stringUserName)
        {
            User user = null!;
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from users where username=@username";
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = stringUserName;
                
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
                    user = new User(userid, firstname, lastname, username, password, mail, lastLogin);
                    
                }
            }

            return user;
        }
        
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }