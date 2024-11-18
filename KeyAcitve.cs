using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeUi
{
    [Serializable()]
    public  enum typeKey
    {
        Trial,
       
        Machine,
        Pro,Lock
    }
    public  class KeyAcitve
    {
        public  DateTime dateCreate;
        public  String Key = "", IDDev="";
        public  int DateKey = 30;
        public  int valueDateKey = 31;
        public typeKey typeKey=typeKey.Lock;
        public KeyAcitve()
        {

        }
        public KeyAcitve(String Key, String IDDev, DateTime dateCreate,  int DateKey, int valueDateKey, typeKey typeKey)
        {
            this.IDDev = IDDev;
            this.dateCreate = dateCreate;
            this.Key = Key;
            this.DateKey = DateKey;
            this.valueDateKey = valueDateKey;
            this.typeKey = typeKey;
        }
    }
}
