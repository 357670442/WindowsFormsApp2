using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
namespace WindowsFormsApp2
{
    class PlcManager
    {
        private List<Plc> plclist=new List<Plc> { };
        public  void add(Plc plc)
        {
            plclist.Add(plc);
        }
        public void addRange(List<Plc> plcs)
        {
            plclist.AddRange(plcs);
        }
        public bool del(Plc plc)
        {
            return plclist.Remove(plc);
        }
        public void Delall()
        {
             plclist.Clear();
        }
       
        
    }
}
