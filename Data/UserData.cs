using System;
using _72220556sampleWebApp.data;
using SampleSecureWeb;
using SampleSecureWeb.Models;

namespace _72220556sampleWebApp.Data
{
    public class UserData : IUser
    {
        private readonly ApplicationDbContext _db;

        public UserData(ApplicationDbContext db)
        {
            _db = db;
        }

        public User Login(User user)
        {
            if (string.IsNullOrEmpty(user.Username))
            {
                throw new ArgumentException("Username is required.");
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                throw new ArgumentException("Password is required.");
            }

            try
            {
                var _user = _db.Users.FirstOrDefault(u => u.Username == user.Username);
                if (_user == null)
                {
                    throw new Exception("User not found");
                }
                if (!BCrypt.Net.BCrypt.Verify(user.Password, _user.Password))
                {
                    throw new Exception("Password is incorrect");
                }
                return _User;
            }
            catch (Exception ex);
            {
                throw new Exception($"An error occurred during login: {ex.Message}");
            }
        }

        public User Login(User user)
        {
            throw new NotImplementedException();
        }

        public User Registration(User user)
        {
            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                _db.Users.Add(user);
                _db.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred during registration: {ex.Message}");
            }
        }

        public User Registration(User user)
        {
            throw new NotImplementedException();
        }
    }
}
