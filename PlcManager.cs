using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
namespace WindowsFormsApp2
{
   public   class PlcManager
    {
        private List<Plc> plclist=new List<Plc> { };
        public List<Plc> List =>plclist;
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
            plc.Close();
            return plclist.Remove(plc);
        }
        public void Delall()
        {
             plclist.Clear();
        }
       
        
    }
    public class s7Plc : Plc
    {
        public string name { get; set; }
        public s7Plc(string name,CpuType cputype,string ip,Int16 rack,Int16 slot): base(cputype, ip, rack, slot)
        {
            this.name = name;   
        }
    }
}
