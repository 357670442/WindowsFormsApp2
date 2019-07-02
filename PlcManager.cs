using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace WindowsFormsApp2
{
    public class PlcManager
    {
        private List<s7Plc> plclist = new List<s7Plc> { };
        public List<s7Plc> List => plclist;
        public void add(s7Plc plc)
        {
            plclist.Add(plc);
        }
        public void addRange(List<s7Plc> plcs)
        {
            plclist.AddRange(plcs);
        }
        public bool del(s7Plc plc)
        {
            plc.Close();
            return plclist.Remove(plc);
        }
        public void Delall()
        {
            plclist.Clear();
        }
        public s7Plc FindPLCByName(string name)
        {
            foreach(var plc in plclist)
            {
                if (plc.name.Equals(name))
                    return plc;
            }
            return null;
        }


    }
    public class s7Plc : Plc
    {
        public string name { get; set; }
        public Timer CycleTimer { get; set; }
        public List<s7plcVarItem> varlist;
        public TreeNode Node { get; set; }
        public s7Plc(string name, CpuType cputype, string ip, Int16 rack, Int16 slot) : base(cputype, ip, rack, slot)
        {
            this.name = name;
            //初始化定时器
            CycleTimer = new System.Timers.Timer(5000);
            CycleTimer.Elapsed += new System.Timers.ElapsedEventHandler(cycleEvent);
            CycleTimer.AutoReset = true;
            CycleTimer.Enabled = false;
            //初始化变量列表
            varlist = new List<s7plcVarItem>();
            //初始化TreeNode
            Node = new TreeNode();
            Node.Name = this.name;
            Node.Text = this.name + ":"+this.IP;
            Node.Tag = this;
        }
        public void cycleEvent(object source,System.Timers.ElapsedEventArgs e)
        {
            //从PLC中读取实际值
            foreach(var i in this.varlist)
            {
                i.GetPLCValOneByOne(this);
                


            }
            
        }
        public s7plcVarItem FindvarItemByName(string Name)
        {
            foreach(var item in varlist)
            {
                if (item.name.Equals(Name))
                    return item;
            }
            return null;
        }
        public void Add(s7plcVarItem item)
        {
            varlist.Add(item);
            Node.Nodes.Add(item.Node);

        }
    }
    

    }



