using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BeeUi
{
    public class FingerPrint
    {
        private static string fingerPrint = string.Empty;
        public static string Value()
        {
            if (string.IsNullOrEmpty(fingerPrint))
            {
                fingerPrint = GetHash("CPU >> " + cpuId()  +
           "\nVIDEO >> " + 
            videoId() 
                                     );
            }
            return fingerPrint;
        }
        private static string GetHash(string s)
        {
            MD5 sec = new MD5CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] bt = enc.GetBytes(s);
            return GetHexString(sec.ComputeHash(bt));
        }
        private static string GetHexString(byte[] bt)
        {
            string s = string.Empty;
            for (int i = 0; i < bt.Length; i++)
            {
                byte b = bt[i];
                int n, n1, n2;
                n = (int)b;
                n1 = n & 15;
                n2 = (n >> 4) & 15;
                if (n2 > 9)
                    s += ((char)(n2 - 10 + (int)'A')).ToString();
                else
                    s += n2.ToString();
                if (n1 > 9)
                    s += ((char)(n1 - 10 + (int)'A')).ToString();
                else
                    s += n1.ToString();
                if ((i + 1) != bt.Length && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }
        #region Original Device ID Getting Code
        //Return a hardware identifier
        private static string identifier
        (string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string result = "";
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                if (mo[wmiMustBeTrue].ToString() == "True")
                {
                    //Only get the first one
                    if (result == "")
                    {
                        try
                        {
                            result = mo[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            return result;
        }
        //Return a hardware identifier
        private static string identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
        private static string cpuId()
        {
            //Uses first CPU identifier available in order of preference
            //Don't get all identifiers, as it is very time consuming
            string retVal = "";// identifier("Win32_Processor", "UniqueId");
            if (retVal == "") //If no UniqueID, use ProcessorID
            {
                retVal = identifier("Win32_Processor", "ProcessorId");
                if (retVal == "") //If no ProcessorId, use Name
                {
                    retVal = identifier("Win32_Processor", "Name");
                    if (retVal == "") //If no Name, use Manufacturer
                    {
                        retVal = identifier("Win32_Processor", "Manufacturer");
                    }
                    //Add clock speed for extra security
                    retVal += identifier("Win32_Processor", "MaxClockSpeed");
                }
            }
            return retVal;
        }
        //BIOS Identifier
        private static string biosId()
        {
            return identifier("Win32_BIOS", "Manufacturer")
            + identifier("Win32_BIOS", "SMBIOSBIOSVersion")
            + identifier("Win32_BIOS", "IdentificationCode")
            + identifier("Win32_BIOS", "SerialNumber")
            + identifier("Win32_BIOS", "ReleaseDate")
            + identifier("Win32_BIOS", "Version");
        }
        //Main physical hard drive ID
        private static string diskId()
        {
            return identifier("Win32_DiskDrive", "Model")
            + identifier("Win32_DiskDrive", "Manufacturer")
            + identifier("Win32_DiskDrive", "Signature")
            + identifier("Win32_DiskDrive", "TotalHeads");
        }
        //Motherboard ID
        private static string baseId()
        {
            return identifier("Win32_BaseBoard", "Model")
            + identifier("Win32_BaseBoard", "Manufacturer")
            + identifier("Win32_BaseBoard", "Name")
            + identifier("Win32_BaseBoard", "SerialNumber");
        }
        //Primary video controller ID
        private static string videoId()
        {
            return identifier("Win32_VideoController", "DriverVersion")
            + identifier("Win32_VideoController", "Name");
        }
        //First enabled network card ID
        private static string macId()
        {
            return identifier("Win32_NetworkAdapterConfiguration",
                "MACAddress", "IPEnabled");
        }
        #endregion
    }
    class Decompile
    {
        public Decompile()
        {

        }
        public static String DecompileMac(String MacAddress)
        {

           
            String sSum = "";
            foreach (char c in MacAddress)
            {
                switch (c)
                {
                    case '0': sSum += "d51sdgxhs"; break;
                    case '1': sSum += "dfd$$^$"; break;
                    case '2': sSum += "SDfsdfs%"; break;
                    case '3': sSum += "sdsa$%$"; break;
                    case '4': sSum += "SDFSFdsfk&"; break;
                    case '5': sSum += "sDGDRYt56"; break;
                    case '6': sSum += "sDGDgf65*"; break;
                    case '7': sSum += "Hdryrdg^7876"; break;
                    case '8': sSum += "FDD46ds"; break;
                    case '9': sSum += "fdfgd4545%"; break;
                    case 'A': sSum += "mauiuhihi"; break;
                    case 'B': sSum += "fSDGFs453"; break;
                    case 'C': sSum += "$^$%fb"; break;
                    case 'D': sSum += "mauiuhihi1"; break;
                    case 'E': sSum += "%&%^*ddx"; break;
                    case 'F': sSum += "#%#$tdvd"; break;
                    case 'G': sSum += "sdfsf$^#$&"; break;
                    case 'H': sSum += "baocc"; break;
                    case 'I': sSum += "dxzv@$#$"; break;
                    case 'J': sSum += "dienbao"; break;
                    case 'K': sSum += "chibao"; break;
                    case 'L': sSum += "stuppid@"; break;
                    case 'M': sSum += "dgdsgdsgfW354"; break;
                    case 'N': sSum += "mauiuhihi2"; break;
                    case 'O': sSum += "1#@!dsgdgdrg"; break;
                    case 'P': sSum += "#$##%^fFFDg"; break;
                    case 'Q': sSum += "@DGFDSGS"; break;
                    case 'R': sSum += "sgfsagvsdgh"; break;
                    case 'S': sSum += "dge^%&$"; break;
                    case 'T': sSum += "Qdgdgre4$^^$"; break;
                    case 'U': sSum += "sdgsg$%$#"; break;
                    case 'V': sSum += "dsfsdfE$%$"; break;
                    case 'X': sSum += "sfsfs5gWRG"; break;
                    case 'Y': sSum += "yi4ytfhsd"; break;
                    case 'Z': sSum += "mauiuhihi3"; break;
                    case 'W': sSum += "dg1df5dgf"; break;
                    case '/': sSum += "~"; break;
                    case '-': sSum += "segsdgsdgsge"; break;
                    default:
                        sSum += "_";
                        break; 
                }
                sSum += "`";
            }
            return sSum;
        }
        public static String[] Compile(String DeCompile)
        {
            String[] sLine = DeCompile.Split('_');
            String[] output  = new String[4];
           
           
            int i = 0;
            foreach(String s in sLine)
            {

                String[] sChar = s.Split('`');
                String sSum = "";
                foreach (String s2 in sChar)
                {
                    
                        switch (s2)
                        {
                            case "d51sdgxhs" : sSum += '0'; break;
                            case "dfd$$^$": sSum += '1'; break;
                            case "SDfsdfs%" : sSum += '2'; break;
                            case "sdsa$%$" : sSum += '3'; break;
                            case "SDFSFdsfk&": sSum += '4'; break;
                            case "sDGDRYt56" : sSum += '5'; break;
                            case "sDGDgf65*": sSum += '6'; break;
                            case "Hdryrdg^7876" : sSum += '7'; break;
                            case "FDD46ds" : sSum += '8'; break;
                            case "fdfgd4545%" : sSum += '9'; break;
                            case "mauiuhihi" : sSum += 'A'; break;
                            case "fSDGFs453" : sSum += 'B'; break;
                            case "$^$%fb": sSum += 'C'; break;
                            case "mauiuhihi1": sSum += 'D'; break;
                            case "%&%^*ddx": sSum += 'E'; break;
                            case "#%#$tdvd": sSum += 'F'; break;
                            case "sdfsf$^#$&": sSum += 'G'; break;
                            case "baocc": sSum += 'H'; break;
                            case "dxzv@$#$": sSum += 'I'; break;
                            case "dienbao": sSum += 'J'; break;
                            case "chibao": sSum += 'K'; break;
                            case "stuppid@": sSum += 'L'; break;
                            case "dgdsgdsgfW354": sSum += 'M'; break;
                            case "mauiuhihi2": sSum += 'N'; break;
                            case "1#@!dsgdgdrg": sSum += 'O'; break;
                            case "#$##%^fFFDg": sSum += 'P'; break;
                            case "@DGFDSGS": sSum += 'Q'; break;
                            case "sgfsagvsdgh": sSum += 'R'; break;
                            case "dge^%&$": sSum += 'S'; break;
                            case "Qdgdgre4$^^$": sSum += 'T'; break;
                            case "sdgsg$%$#" : sSum += 'U'; break;
                            case "dsfsdfE$%$": sSum += 'V'; break;
                            case "sfsfs5gWRG": sSum += 'X'; break;
                            case "yi4ytfhsd": sSum += 'Y'; break;
                            case "mauiuhihi3": sSum += 'Z'; break;
                            case "dg1df5dgf": sSum += 'W'; break;
                            case "~": sSum += '/'; break;
                            case "segsdgsdgsge": sSum += '-'; break;

                        default:
                                sSum += "";
                                break;
                        }
                    
                   
                }
                output[i] = sSum;
                i++;
            }
            return output;
        }

        public static String GetMacAddress()
        {
            return FingerPrint.Value();
          
        }
    }
}
