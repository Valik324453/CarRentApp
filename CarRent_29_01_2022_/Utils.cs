using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent_29_01_2022_
{
    public static class Utils
    {
        /*public static bool FormIsOpen(string name)
        {
            //check if window is already open
            var openForms = ApplicationException.OpenForms.Cast<Form>();
            var isOpen openForms.Any(x => x.Name == name);
            return isOpen;
        }*/

        public static bool FormIsOpen(string name)
        {
            //check if window is already open
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(x => x.Name == name);
            return isOpen;
        }
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
