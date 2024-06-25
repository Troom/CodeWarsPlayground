using System.Net;
using System.Text.RegularExpressions;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    public static class IP_Validation
    {
        public static bool IsValidIp(string ipAddres) => new Regex(@"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)\.?\b){4}$").IsMatch(ipAddres) ? true : false;

        public static bool IsValidIpManualWithLinq(string ipAddress)
        {
            var octets = ipAddress.Split(".");

            if (octets.Count() != 4) return false;

            foreach (var octet in octets)
            {
                if (!int.TryParse(octet, out int numericOctet))
                    return false;

                if (numericOctet < 0 || numericOctet > 255)
                    return false;

                if (!numericOctet.ToString().Equals(octet))
                    return false;
            }
            return true;
        }

        public static bool is_valid_IPManual(string ipAddress)
        {
            var octets = ipAddress.Split('.');
            if (octets.Length != 4) 
                return false;

            foreach (var octet in octets)
            {
                int result;
                if (IsValidOctet(octet) && int.TryParse(octet, out result))
                {
                    if (result < 0 || result > 255)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }

        public static bool IsValidOctet(string octet)
        {
            if (octet.Length > 1 && octet.StartsWith("0"))
            {
                return false;
            }

            if (octet.Contains(" "))
            {
                return false;
            }

            if (octet.Contains("-"))
            {
                return false;
            }

            return true;
        }
    
    public static bool is_valid_IP_ByNET(string IpAddress)
        {
            return IPAddress.TryParse(IpAddress, out var parsedIp)
              && IpAddress.Split('.').Length == 4;
        }

    }
}
