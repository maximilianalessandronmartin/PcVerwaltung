using System;

namespace PcVerwaltung.Model;

public class User
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _userName;
    private string _password;
    private string _mail;
    private DateTime _lastLogin;
    
    public User(int id, string firstName, string lastName, string userName, string password, string mail,
        DateTime lastLogin)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _userName = userName;
        _password = password;
        _mail = mail;
        _lastLogin = lastLogin;
        
    }

    public User(string firstName, string lastName, string userName, string password, string mail, DateTime lastLogin)
    {
        _firstName = firstName;
        _lastName = lastName;
        _userName = userName;
        _password = Helper.ConnectionHelper.GetSHA384(userName, password);
        _mail = mail;
        _lastLogin = lastLogin;
        
    }


    public int Id
    {
        get { return _id; }

        set { _id = value; }
    }



    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }

    }

    public string Password
    {
        get => _password;
        set => _password = value;
    }



    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Mail
    {
        get { return _mail; }
        set { _mail = value; }
    }

    public DateTime LastLogin
    {
        get => _lastLogin;
        set => _lastLogin = value;
    }
    

}