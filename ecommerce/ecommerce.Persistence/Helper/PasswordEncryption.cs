using System.Security.Cryptography;

namespace ecommerce.Persistence.Helper
{
    internal class PasswordEncryption
    {
        private readonly byte[] _salt = new byte[] { 0x26, 0x9c, 0x8f, 0xc3, 0x76, 0xcc, 0x02, 0x9f, 0x2e, 0xd5, 0x68, 0x2f, 0x14, 0xd9, 0x8a, 0x54 };
        private readonly int _iterations = 10000;
        private readonly int _hashByteSize = 32;

        public string Encrypt(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, _salt, _iterations))
            {
                byte[] hash = pbkdf2.GetBytes(_hashByteSize);

                byte[] saltAndHash = new byte[_salt.Length + hash.Length];
                Buffer.BlockCopy(_salt, 0, saltAndHash, 0, _salt.Length);
                Buffer.BlockCopy(hash, 0, saltAndHash, _salt.Length, hash.Length);

                return Convert.ToBase64String(saltAndHash);
            }
        }

        public bool Verify(string password, string hashedPassword)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            if (string.IsNullOrEmpty(hashedPassword))
            {
                throw new ArgumentNullException("hashedPassword");
            }

            byte[] saltAndHash = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[_salt.Length];
            byte[] hash = new byte[_hashByteSize];

            Buffer.BlockCopy(saltAndHash, 0, salt, 0, _salt.Length);
            Buffer.BlockCopy(saltAndHash, _salt.Length, hash, 0, _hashByteSize);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, _iterations))
            {
                byte[] hashToVerify = pbkdf2.GetBytes(_hashByteSize);

                if (SlowEquals(hash, hashToVerify))
                {
                    return true;
                }

                return false;
            }
        }

        private bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;

            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }
    }
}
