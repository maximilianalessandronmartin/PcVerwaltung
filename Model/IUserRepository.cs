using System.Collections.Generic;
using System.Net;
using PcVerwaltung.Exceptions;
using PcVerwaltung.Model;

namespace PcVerwaltung.Model;

public interface IUserRepository
{
    bool AuthenticateUser(NetworkCredential credential);
    void Add(User user);
    void Edit(User user);
    void Remove(int id);
    User GetById(int id);
    User GetByUsername(string username);
    IEnumerable<User> GetByAll();
    //...
}