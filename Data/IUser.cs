using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleSecureWeb.Models;

namespace _72220556sampleWebApp.Data
{
    public interface IUser
    {
        User Registration(User user);
        User Login(User user);
    }
}