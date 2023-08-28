using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HCP
{
    public class GdPictureLicenseManager
    {
        public GdPictureLicenseManager()
        {
            //SetDeveloperKey("211883860501001421116010749430779");
        }

        public string GetMacAddress()
        {
            var text = string.Empty;
            using (var managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                foreach (var managementObject in managementClass.GetInstances())
                {
                    if (managementObject["MacAddress"] == null)
                        continue;

                    if (managementObject["IpEnabled"] == null || !(bool)managementObject["IpEnabled"])
                        continue;

                    var text2 = managementObject["MacAddress"].ToString().Trim().ToUpper().Replace(":", "");
                    if (string.IsNullOrEmpty(text))
                        text = text2;
                    if (text.Replace("00", "").Length <= text2.Replace("00", "").Length)
                        text = text2;
                }
            }
            return text;
        }
        public RegistryKey GetRegistryKey()
        {
            var registryKey = Registry.CurrentUser.OpenSubKey("Software\\Orpalis\\GdPicture.NET14", true) ??
                              Registry.CurrentUser.OpenSubKey("Software\\Wow6432Node\\Orpalis\\GdPicture.NET14", true) ??
                              Registry.LocalMachine.OpenSubKey("Software\\Orpalis\\GdPicture.NET14", true) ??
                              Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Orpalis\\GdPicture.NET14", true);
            return registryKey;
        }
        public byte[] XorCrypt(string passPhrase, byte[] inputData)
        {
            var array = new byte[256];
            var swapIndex1 = 0;
            if (string.IsNullOrEmpty(passPhrase))
            {
                throw new ArgumentNullException(nameof(passPhrase));
            }
            if (passPhrase.Length > 256)
                passPhrase = passPhrase.Substring(0, 256);
            var passPhraseArray = Encoding.GetEncoding(1252).GetBytes(passPhrase);
            // Initialize array with values 0 to 255
            for (var i = 0; i <= 255; i++)
                array[i] = (byte)i;
            // Swap the values around based on the licensekey
            for (var i = 0; i <= 255; i++)
            {
                swapIndex1 = (swapIndex1 + array[i] + passPhraseArray[i % passPhrase.Length]) % 256;
                // Swap
                var b = array[i];
                array[i] = array[swapIndex1];
                array[swapIndex1] = b;
            }
            swapIndex1 = 0;
            var swapIndex2 = 0;
            var output = new byte[inputData.Length - 1 + 1];
            for (var i = 0; i <= inputData.Length - 1; i++)
            {
                swapIndex1 = (swapIndex1 + 1) % 256;
                swapIndex2 = (swapIndex2 + array[swapIndex1]) % 256;
                // Swap
                var b = array[swapIndex1];
                array[swapIndex1] = array[swapIndex2];
                array[swapIndex2] = b;
                output[i] = (byte)(inputData[i] ^ array[(array[swapIndex1] + array[swapIndex2]) % 256]);
            }
            return output;
        }

        public void SetDeveloperKey(string licenseKey)
        {
            var registryKey = GetRegistryKey();

            if (registryKey == null)
                registryKey = Registry.CurrentUser.CreateSubKey("Software\\Orpalis\\GdPicture.NET14", true);
            var computerSpecificKey = "GdPicture.NET14" + GetMacAddress();
            var base64 = XorCrypt(computerSpecificKey, Encoding.ASCII.GetBytes(licenseKey));
            registryKey.SetValue("CoreKey", Convert.ToBase64String(base64));
            registryKey.SetValue("Edition", "GdPicture.Net Document Imaging SDK Ultimate V14");
        }

        internal string GetKey()
        {
            return "211883860501001421116010749430779";
        }
    }
}
