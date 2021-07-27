using System;
using System.Collections.Generic;
using System.Text;

namespace tmsang.domain
{
    public interface IAuth
    {
        string GenerateToken(string userId, string role);
        bool ValidateCurrentToken(string token);
        string GetClaim(string token, string claimType);
        HashSalt EncryptPassword(string password);
        bool VerifyPassword(string enteredPassword, byte[] salt, string storedPassword);

    }

    public class HashSalt
    {
        public string Hash { get; set; }
        public byte[] Salt { get; set; }
    }
}
