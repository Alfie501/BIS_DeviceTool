using MyXmlTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CviVisaDriver;
using System.Threading;

namespace BIS_DeviceTool
{
    public partial class Form1 : Form
    {
        bool isLoad = false;
        bool isAreaSetting = false;
        bool isDeviceChanging = false;
        bool isRoot = false;
        bool CmdNameHasChanged = false;
        const string AreaList_xml = @"..\AreaList.xml";
        const string CommandList_xml = @"..\CommandList.xml";

        List<Area> AreaList;
        List<Command> CommandList;
        Dictionary<string, CviVisaCtrl> _NIDriver;

        Area Current_Area;
        Model Current_Model;
        Command Current_Command;        

        //**********************************//
        private List<DataGridViewRow> CopiedDgvRows = new List<DataGridViewRow>();
        private List<Command> copiedItems = new List<Command>();
        private Command m_ThisCommand;
        public Command ThisCommand { get => m_ThisCommand; set => m_ThisCommand = value; }
        //**********************************//
        public Form1()
        {
            InitializeComponent();

            _NIDriver = new Dictionary<string, CviVisaCtrl> { { "*", null } };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            isLoad = true;

            TsBtn_Enable_Setting();
            
            LoadAreaList();
            LoadCommandList();

            isLoad = false;
        }

        private void TsCmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad) return;
            isAreaSetting = true;
            tsCmb_IP.Text = string.Empty;

            Current_Area = AreaList[AreaList.FindIndex(x => x.Name == tsCmb_Area.Text)];
            tsCmb_IP.Items.Clear();
            foreach (Model model in Current_Area.Models)
                tsCmb_IP.Items.Add(model.IP);

            isAreaSetting = false;
        }
        private void TsCmbIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad || isAreaSetting) return;
            isDeviceChanging = true;
            try
            {
                Current_Model = Current_Area.Models[Current_Area.Models.FindIndex(x => x.IP == tsCmb_IP.Text)];
                txt_ModelName.Text = Current_Model.Name;

                if (!_NIDriver.ContainsKey(Current_Model.IP))
                    _NIDriver.Add(Current_Model.IP, New_CviVisaCtrl());

                WriteCommand(_NIDriver[Current_Model.IP], "*IDN?");
                txt_SN.Text = ReadResponse(_NIDriver[Current_Model.IP], Current_Model.IP).Split(',')[2];

                dgv_On.Rows.Clear();
                Current_Command = CommandList[CommandList.FindIndex(x => x.ID == Current_Area.CommandID)];
                tsTxt_CommandName.Text = Current_Area.CommandID;
                //Current_Command = CommandList[CommandList.FindIndex(x => x.ID == Current_Model.CommandID)];
                //tsTxt_CommandName.Text = Current_Command.Name;
                foreach (Commandline command in Current_Command.OnCommands)
                    dgv_On.Rows.Add(new object[] { command.Active, command.Line });
                foreach (Commandline command in Current_Command.OffCommands)
                    dgv_Off.Rows.Add(new object[] { command.Active, command.Line });
            }
            catch (Exception ex)
            {
                if (isRoot)
                    MessageBox.Show(ex.ToString());
                else
                    MessageBox.Show(ex.Message);
            }
            finally { isDeviceChanging = false; }

            CviVisaCtrl New_CviVisaCtrl()
            {
                CviVisaCtrl cviVisaCtrl = new CviVisaCtrl();

                if (cviVisaCtrl.Open(new DeviceInfo
                {
                    Parity = SerialParity.None,
                    shortDataBits = 8,
                    StopBits = SerialStopBitsMode.One,
                    nBaudrate = 9600,
                    nInterface = (int)InterfaceType.INTERFACE_ENET,
                    strConnectInfo = $"{Current_Model.IP}::2021"
                }))
                {
                    cviVisaCtrl.SetEos(TerminationType.TERMCHAR_LF, 0x0A);
                }
                else
                {
                    throw new Exception($"Device Connect Fail (IP:{Current_Model.IP})");
                }
                return cviVisaCtrl;
            }
        }

        private void Btn_On_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_On.RowCount; i++) {
                    if((bool)dgv_On[0, i].Value == true)
                    {
                        WriteCommand(_NIDriver[Current_Model.IP], dgv_On[1,i].ToString());
                    }
                    else                    
                        continue;                    
                }
            }
            catch (Exception ex)
            {
                if (isRoot)
                    MessageBox.Show(ex.ToString());
                else
                    MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Off_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_Off.RowCount; i++)
                {
                    if ((bool)dgv_Off[0, i].Value == true)
                    {
                        WriteCommand(_NIDriver[Current_Model.IP], dgv_Off[1, i].ToString());
                    }
                    else
                        continue;
                }
            }
            catch (Exception ex)
            {
                if (isRoot)
                    MessageBox.Show(ex.ToString());
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void TsBtn_Copy_Click(object sender, EventArgs e)
        {
            RowsCopy(false);
        }
        private void TsBtn_Cut_Click(object sender, EventArgs e)
        {
            RowsCopy(true);
        }
        private void RowsCopy(bool isCut)
        {
            if (CopiedDgvRows.Count > 0) CopiedDgvRows.Clear();
            if (copiedItems.Count > 0) copiedItems.Clear();

            if (tabControl1.Controls.Owner == tabPage1)
            {
                foreach (DataGridViewRow row in dgv_On.SelectedRows)
                {
                    try
                    {
                        DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();

                        for (int i = 0; i < row.Cells.Count; i++)
                            clonedRow.Cells[i].Value = row.Cells[i].Value;

                        CopiedDgvRows.Add(clonedRow);
                        copiedItems.Add(ThisCommand.Items[row.Index].Clone());
                    }
                    catch { }
                }
                if (isCut)
                {
                    foreach (DataGridViewRow row in dgv_On.SelectedRows)
                    {
                        ThisCommand.Items.RemoveAt(row.Index);
                        dgv_On.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else if (tabControl1.Controls.Owner == tabPage2)
            {
                foreach (DataGridViewRow row in dgv_Off.SelectedRows)
                {
                    try
                    {
                        DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();

                        for (int i = 0; i < row.Cells.Count; i++)
                            clonedRow.Cells[i].Value = row.Cells[i].Value;

                        CopiedDgvRows.Add(clonedRow);
                        copiedItems.Add(ThisCommand.Items[row.Index].Clone());
                    }
                    catch { }
                }
                if (isCut)
                {
                    foreach (DataGridViewRow row in dgv_Off.SelectedRows)
                    {
                        ThisCommand.Items.RemoveAt(row.Index);
                        dgv_Off.Rows.RemoveAt(row.Index);
                    }
                }
            }
            
        }
        private void TsBtn_Paste_Click(object sender, EventArgs e)
        {
            try
            {
                if (CopiedDgvRows.Count > 0)
                {
                    if (tabControl1.Controls.Owner == tabPage1)
                    {
                        if (dgv_On.SelectedRows.Count > 0)
                        {
                            for (int i = CopiedDgvRows.Count - 1, rIdx = dgv_On.SelectedRows[0].Index + 1; i >= 0; i--, rIdx++)
                            {
                                dgv_On.Rows.Insert(rIdx, CopiedDgvRows[i]);
                                ThisCommand.Items.Insert(rIdx, copiedItems[i]);
                            }
                        }
                        else
                        {
                            for (int i = CopiedDgvRows.Count - 1; i >= 0; i--)
                            {
                                dgv_On.Rows.Add(CopiedDgvRows[i]);
                                ThisCommand.Items.Add(copiedItems[i]);
                            }
                        }
                    }
                    else if (tabControl1.Controls.Owner == tabPage2)
                    {
                        if (dgv_Off.SelectedRows.Count > 0)
                        {
                            for (int i = CopiedDgvRows.Count - 1, rIdx = dgv_Off.SelectedRows[0].Index + 1; i >= 0; i--, rIdx++)
                            {
                                dgv_Off.Rows.Insert(rIdx, CopiedDgvRows[i]);
                                ThisCommand.Items.Insert(rIdx, copiedItems[i]);
                            }
                        }
                        else
                        {
                            for (int i = CopiedDgvRows.Count - 1; i >= 0; i--)
                            {
                                dgv_Off.Rows.Add(CopiedDgvRows[i]);
                                ThisCommand.Items.Add(copiedItems[i]);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Selected Row");
                }
            }
            catch (Exception ex) {

                if (isRoot)
                    MessageBox.Show(ex.ToString());
                else
                    MessageBox.Show(ex.Message);
            }
        }
        private void TsBtn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.Controls.Owner == tabPage1)
                {
                    foreach (DataGridViewRow row in dgv_On.SelectedRows)
                    {
                        ThisCommand.Items.RemoveAt(row.Index);
                        dgv_On.Rows.Remove(row);
                    }
                }
                else if(tabControl1.Controls.Owner == tabPage2)
                {
                    foreach (DataGridViewRow row in dgv_Off.SelectedRows)
                    {
                        ThisCommand.Items.RemoveAt(row.Index);
                        dgv_Off.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex) {
                if (isRoot)
                    MessageBox.Show(ex.ToString());
                else
                    MessageBox.Show(ex.Message);
            }
        }
        private void TsBtn_Save_Click(object sender, EventArgs e)
        {
            if (tsTxt_CommandName.Text == string.Empty)
            {
                Console.WriteLine("You need to enter the CommandName.");
                return;
            }
            else if(CmdNameHasChanged)
            {
                dgv_On.EndEdit();
                dgv_Off.EndEdit();

                switch (MessageBox.Show("Command name has changed, save as new command?", string.Empty, MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        //CommandList.Add(Cmd_Setting($"{CommandList.Count:d4}", tsTxt_CommandName.Text));
                        Current_Command = Cmd_Setting($"{CommandList.Count:d4}", tsTxt_CommandName.Text);                        
                        break;
                    case DialogResult.No:
                        Current_Command = Cmd_Setting(Current_Command.ID, tsTxt_CommandName.Text);                        
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            else Current_Command = Cmd_Setting(Current_Command.ID, Current_Command.Name);

            int cmdList_idx = CommandList.FindIndex(x => x.Name == tsTxt_CommandName.Text);
            if (cmdList_idx >= 0)
            {
                Current_Command = CommandList[CommandList.FindIndex(x => x.Name == tsTxt_CommandName.Text)];
                CommandList[cmdList_idx] = Current_Command;
            }
            else
                CommandList.Add(Current_Command);

            File.WriteAllText(CommandList_xml, XmlUtil.Serializer(typeof(List<Command>), CommandList));
            CmdNameHasChanged = false;
        }
        private void TsBtn_Edit_Click(object sender, EventArgs e)
        {
            isRoot = true;
            TsBtn_Enable_Setting();
        }
        private void TsTxtCmdName_TextChanged(object sender, EventArgs e)
        {
            if (isDeviceChanging) return;
            CmdNameHasChanged = true;
        }
        private Command Cmd_Setting(string ID, string Name)
        {
            Command temp_cmd = new Command(ID, Name);

            //for (int i = 0; i < dgv_On.RowCount - 1; i++)
            //{
            //    Commandline temp_cmdl = new Commandline();
            //    temp_cmdl.Active = dgv_On[0, i].Selected;
            //    temp_cmdl.Line = dgv_On[1, i].Value.ToString();
            //    temp_cmd.OnCommands.Add(temp_cmdl);
            //    //temp_cmd.OnCommands.Add(new Commandline((bool)dgv_On[0, i].Selected, dgv_On[1, i].Value.ToString()));
            //}

            for (int i = 0; i < dgv_On.RowCount - 1; i++)
                temp_cmd.OnCommands.Add(new Commandline((bool)(dgv_On[0, i].Value ?? true), dgv_On[1, i].Value.ToString()));

            for (int i = 0; i < dgv_Off.RowCount - 1; i++)
                temp_cmd.OffCommands.Add(new Commandline((bool)(dgv_Off[0, i].Value ?? true), dgv_Off[1, i].Value.ToString()));

            return temp_cmd;
        }

        private void TsBtn_Enable_Setting()
        {
            tsBtn_Copy.Enabled = isRoot;
            tsBtn_Cut.Enabled = isRoot;
            tsBtn_Paste.Enabled = isRoot;
            tsBtn_Delete.Enabled = isRoot;
            tsBtn_Save.Enabled = isRoot;
        }
        private void LoadAreaList()
        {
            string AreaList_Text = string.Empty;

            if (File.Exists(AreaList_xml))
                AreaList_Text = File.ReadAllText(AreaList_xml);

            if (string.IsNullOrEmpty(AreaList_Text))
            {
                AreaList = new List<Area>();
            }
            else
            {
                AreaList = XmlUtil.Deserialize(typeof(List<Area>), AreaList_Text) as List<Area>;
            }
            List<string> areaNames = new List<string>();
            foreach (Area area in AreaList)
                areaNames.Add(area.Name);
            tsCmb_Area.Items.AddRange(areaNames.ToArray());
        }
        private void LoadCommandList()
        {
            string CommandList_Text = string.Empty;

            if (File.Exists(CommandList_xml))
                CommandList_Text = File.ReadAllText(CommandList_xml);

            if (string.IsNullOrEmpty(CommandList_Text))
            {
                CommandList = new List<Command>();
            }
            else
            {
                CommandList = XmlUtil.Deserialize(typeof(List<Command>), CommandList_Text) as List<Command>;
            }
        }

        protected void WriteCommand(CviVisaCtrl NIDriver, object Command)
        {
            Console.WriteLine($"== WriteCommand() ==");
            if (NIDriver.Write(Command.ToString())) Thread.Sleep(200);
            else throw new Exception(NIDriver.ErrorMessage);
        }
        protected string ReadResponse(CviVisaCtrl NIDriver, object IP)
        {
            Console.WriteLine($"== ReadResponse() ==");
            string ReturnString = string.Empty;
            if (NIDriver.Read(ref ReturnString)) Thread.Sleep(200);
            else throw new Exception(NIDriver.ErrorMessage);

            if (string.IsNullOrEmpty(ReturnString)) { throw new Exception("No read value from " + IP); }
            Console.WriteLine("ReturnString: " + ReturnString);

            return ReturnString;
        }

        private void TsBtn_AppendArea_Click(object sender, EventArgs e)
        {
            DlgAreaEditor _DlgAreaEditor = null;
            try
            {
                new Thread((ThreadStart)delegate
                {
                    _DlgAreaEditor = new DlgAreaEditor(AreaList, CommandList) { };
                    Application.Run(_DlgAreaEditor);
                }).Start();
            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }

        private void dgv_On_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"Dgv_Device_CellValueChanged({e.ColumnIndex}, {e.RowIndex})");
            if (e.RowIndex < 0) return;
        }

        private void BtnClear1_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_On.Rows.Clear();
                dgv_Off.Rows.Clear();
            }
            catch { }
        }
    }
}
