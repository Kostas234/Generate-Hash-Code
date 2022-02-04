using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components; 
using System.Security.Cryptography;
using Microsoft.AspNetCore.Components.Web;

namespace GenerateHashCode.Data
{ 
    public class GenerateHash:ComponentBase
    {
        [Parameter]
        public byte[] InputBytes { get; set; }

        [Parameter]
        public byte[] HashBytes { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public EventCallback OnSomething { get; set; }

        [CascadingParameter(Name = "LoggedInUser")]
        public string UserName { get; set; }

        [CascadingParameter(Name = "LoggedInEmail")]
        public string Email { get; set; }

        public string CreateMD5(string input)
        {
            using MD5 md5 = MD5.Create();
            InputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            HashBytes = md5.ComputeHash(InputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < HashBytes.Length; i++)
            {
                stringBuilder.Append(HashBytes[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public string CreateSHA256(string input)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public string CreateSHA384(string input)
        {
            using SHA384 sha384 = SHA384.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = sha384.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }
    }
}
