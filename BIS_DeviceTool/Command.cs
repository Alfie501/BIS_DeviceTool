using CviVisaDriver;
using System;
using System.Collections.Generic;

namespace BIS_DeviceTool
{
    [Serializable]
   public class Area
    {
        private bool m_Active;
        private string m_Name;
        private List<Model> m_Models;
        private string m_CommandID;

        public Area() { }
        public Area(string m_Name, string m_CommandID)
        {
            this.Name = m_Name;
            this.CommandID = m_CommandID;
            this.Models = new List<Model>();
            this.Active = true;            
        }

        public string Name { get => m_Name; set => m_Name = value; }
        public bool Active { get => m_Active; set => m_Active = value; }
        public string CommandID { get => m_CommandID; set => m_CommandID = value; }
        public List<Model> Models { get => m_Models; set => m_Models = value; }        
    }

    [Serializable]
    public class Model
    {
        private bool m_Active;
        private string m_Name;
        private string m_IP;        
        
        public Model() { }
        public Model(string m_Name, string m_IP)
        {
            this.Name = m_Name;
            this.IP = m_IP;            
            this.Active = true;
        }

        public string Name { get => m_Name; set => m_Name = value; }
        public string IP { get => m_IP; set => m_IP = value; }
        public bool Active { get => m_Active; set => m_Active = value; }        
    }

    [Serializable]
    public class Command
    {
        private string m_ID;
        private string m_Name;
        private List<Commandline> m_OnCommands;
        private List<Commandline> m_OffCommands;

        public Command() { }
        public Command(string m_ID, string m_Name)
        {
            this.ID = m_ID;
            this.Name = m_Name;
            this.OnCommands = new List<Commandline>();
            this.OffCommands = new List<Commandline>();
        }

        public string ID { get => m_ID; set => m_ID = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public List<Commandline> OnCommands { get => m_OnCommands; set => m_OnCommands = value; }
        public List<Commandline> OffCommands { get => m_OffCommands; set => m_OffCommands = value; }
        //**********************************//
        private List<Command> m_Items;
        public List<Command> Items
        {
            get
            {
                if (m_Items == null)
                    m_Items = new List<Command>();
                return m_Items;
            }
            set => m_Items = value;
        }
        public Command Clone() => new Command()
        {
            OnCommands = OnCommands,
            OffCommands = OffCommands
        };
        //**********************************//

    }

    [Serializable]
    public class Commandline
    {
        private bool m_Active;
        private string m_line;

        public Commandline() { }
        public Commandline(bool m_Active, string m_line)
        {
            this.Active = m_Active;
            this.Line = m_line;
        }

        public bool Active { get => m_Active; set => m_Active = value; }
        public string Line { get => m_line; set => m_line = value; }
        
    }
}
