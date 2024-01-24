using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace GrpcClient
{
    public class User
    {
        public string? Phone { get; set; } = null;
        public string? Pass { get; set; } = null;

        public User() { }
        public User(string phone, string pass) {
            Phone = phone;
            Pass = pass;
        }

    }

    
}
