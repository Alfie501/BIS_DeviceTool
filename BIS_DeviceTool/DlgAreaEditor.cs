using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyXmlTool;

namespace BIS_DeviceTool
{
    public partial class DlgAreaEditor : Form
    {
        List<Area> AreaList;
        //List<Model> ModelList;
        List<Command> CommandList;
        //**********************************//
        string Area_Name { get; set; }
        string Command_Name { get; set; }
        Area currentName;        
        Area temp_Area;
        //Model CurrentCommand;
        //Command temp_cammand;

        //bool IscurrentName = false;
        //bool IsCurrentModel = false;
        bool IsDgvAreaHasChanged = false;
        bool IsDgvDeviceHasChanged = false;        

        const string AreaList_xml = @"..\AreaList.xml";
        //**********************************//
        public DlgAreaEditor(List<Area> AreaList, List<Command> CommandList)
        {
            InitializeComponent();            
            this.AreaList = AreaList;
            this.CommandList = CommandList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Area area in AreaList)
            {
                dgv_Area.Rows.Add(new object[] { true, area.Name, area.CommandID });
                //foreach (Model model in area.Models)
                //    dgv_Device.Rows.Add(new object[] { true, model.Name, model.IP });
            }
            this.dgv_Area.DataError += new DataGridViewDataErrorEventHandler(DataGridView1_DataError);
                        
            //dgv_Area.Rows[2].Cells.Clear();       
            //Column3.Items.Add(string.Empty);
            //foreach (Command command in CommandList)
            //{
            //    //dgv_Area.Rows[2].Add(command.Name);
            //    Column3.Items.Add(command.Name);
            //}

        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is
            // commited, display an error message.
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("uh...");
            }
        }
        private void Search_Temp_Device(Area currentName)
        {            
            try
            {
                //dgv_Device.Rows.Clear();
                foreach (Model model in currentName.Models)
                {
                    dgv_Device.Rows.Add(new object[] { true, model.Name, model.IP });                    
                }
            }
            catch { }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Device.Rows.Clear();
            }
            catch { }
        }
        private void TsBtn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgv_Device.SelectedRows)
                {
                    foreach (Model model in currentName.Models)
                    {
                        if (model.IP == dgv_Device[2, row.Index].Value.ToString())
                        {    currentName.Models.Remove(model);
                            break;
                        }
                    }
                }
                dgv_Device.Rows.Clear();
                foreach (Model model in currentName.Models)
                    dgv_Device.Rows.Add(new object[] { true, model.Name, model.IP });
            }
            catch(Exception ex) { Console.WriteLine(ex); }   
        }
        private void Btn_NewArea_Click(object sender, EventArgs e)
        {
            if (dgv_Area == null) { MessageBox.Show("No Selected Sheet", "Error"); return; }
            try
            {
                dgv_Area.Rows.Add();
                Console.WriteLine($"{dgv_Area.Name}.Rows Added");
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        private void TsBtn_NewDevice_Click(object sender, EventArgs e)
        {
            if (dgv_Device == null) { MessageBox.Show("No Selected Sheet", "Error"); return; }
            try
            {
                dgv_Device.Rows.Add();
                Console.WriteLine($"{dgv_Device.Name}.Rows Added");
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        private void TsBtn_Save_Click(object sender, EventArgs e)
        {
            #region pass
            //if (CmdHasChanged)
            //{
            //    switch (MessageBox.Show("Command name has changed, save as new command?", string.Empty, MessageBoxButtons.YesNoCancel))
            //    {
            //        case DialogResult.Yes:
            //            for (int i = 0; i < dgv_Area.RowCount-1; i++)
            //            {
            //                int CMDList_found = AreaList.FindIndex(x => x.Name == dgv_Area[1, i].Value.ToString());
            //                if (CMDList_found >= 0)
            //                {
            //                    currentName = AreaList[AreaList.FindIndex(x => x.Name == dgv_Area[1, i].Value.ToString())];                                
            //                    AreaList[CMDList_found] = currentName;
            //                    //Area_Change_device(dgv_Area[1, i].Value.ToString(), dgv_Area[2, i].Value.ToString());
            //                }
            //                else
            //                {
            //                    AreaList.Add(Area_Setting(dgv_Area[1, i].Value.ToString(), dgv_Area[2, i].Value.ToString()));
            //                }
            //                //BtnClear.PerformClick();
            //                //currentName = AreaList[AreaList.FindIndex(x => x.CommandID == dgv_Area[2, i].Value.ToString())];
            //                //int CMDList_Idx = AreaList.FindIndex(x => x.Name == dgv_Area[1, i].Value.ToString());
            //                //AreaList.Add(Area_Setting(dgv_Area[1, i].Value.ToString(), dgv_Area[2, i].Value.ToString()));
            //            }
            //            break;
            //        case DialogResult.Cancel:
            //            return;
            //    }
            //}
            ////else currentName = Area_Setting(currentName.Name, currentName.CommandID);
            ////int CMDList_Idx = AreaList.FindIndex(x => x.Name == currentName.Name);
            ////AreaList[CMDList_Idx] = currentName;
            #endregion
            switch (MessageBox.Show("Command name has changed, save as new command?", string.Empty, MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    return;
            }

            File.WriteAllText(AreaList_xml, XmlUtil.Serializer(typeof(List<Area>), AreaList));            
        }
        private Area Area_Setting(string AreaName, string CommandName)
        {
            temp_Area = new Area(Name, CommandName)
            {
                Name = AreaName,
                CommandID = CommandName
            };
            for (int j = 0; j < dgv_Device.RowCount; j++)
            {
                Model temp_Model = new Model
                {
                    Active = true,
                    Name = dgv_Device[1, j].Value.ToString(),
                    IP = dgv_Device[2, j].Value.ToString()
                };
                temp_Area.Models.Add(temp_Model);
            }
            return temp_Area;
        }

        private void Dgv_Area_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"Dgv_Area_CellClick({e.ColumnIndex}, {e.RowIndex})");
            if (e.RowIndex < 0) return;
            switch (e.ColumnIndex)
            {
                case (int)ColDgv_Area.AreaName:
                    tsBtn_Clear.PerformClick();

                    Area_Name = dgv_Area[e.ColumnIndex , e.RowIndex].Value.ToString();
                    Command_Name = dgv_Area[e.ColumnIndex+1, e.RowIndex].Value.ToString();
                    currentName = AreaList[AreaList.FindIndex(x => x.Name == Area_Name)];

                    Search_Temp_Device(currentName);
                    break;

                case (int)ColDgv_Area.CommandName:
                    break;

                default:
                    break;
            }
        }
        private void Dgv_Area_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"Dgv_Area_CellContentClick({e.ColumnIndex}, {e.RowIndex})");
            if (e.RowIndex < 0) return;
            switch (e.ColumnIndex)
            {
                case (int)ColDgv_Area.AreaName:
                    break;

                case (int)ColDgv_Area.CommandName:
                    tsBtn_Clear.PerformClick();

                    Area_Name = dgv_Area[e.ColumnIndex - 1, e.RowIndex].Value.ToString();
                    Command_Name = dgv_Area[e.ColumnIndex, e.RowIndex].Value.ToString();
                    currentName = AreaList[AreaList.FindIndex(x => x.Name == Area_Name)];

                    Search_Temp_Device(currentName);
                    break;

                default:
                    break;
            }
        }
        private void Dgv_Area_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"Dgv_Device_CellValueChanged({e.ColumnIndex}, {e.RowIndex})");
            if (e.RowIndex < 0) return;

            switch (e.ColumnIndex)
            {
                case (int)ColDgv_Area.AreaName:
                    //Area_Name = dgv_Area[e.ColumnIndex, e.RowIndex].Value.ToString();
                    break;
                case (int)ColDgv_Area.CommandName:
                    IsDgvAreaHasChanged = true;
                    Area_Name = dgv_Area[e.ColumnIndex-1, e.RowIndex].Value.ToString();
                    Command_Name = dgv_Area[e.ColumnIndex, e.RowIndex].Value.ToString();
                    break;
                default:
                    break;
            }
        }
        private void Dgv_Device_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"Dgv_Device_CellValueChanged({e.ColumnIndex}, {e.RowIndex})");
            if (e.RowIndex < 0) return;

            switch (e.ColumnIndex)
            {
                case (int)ColDgv_Device.ModelName:
                    if (dgv_Device[e.ColumnIndex +1, e.RowIndex].ToString() != string.Empty)
                    {
                        Console.WriteLine("You need to enter the IP again.");
                        return;
                    }
                    break;
                case (int)ColDgv_Device.IP:
                    IsDgvDeviceHasChanged = true;
                    if (dgv_Device[e.ColumnIndex - 1, e.RowIndex].ToString() == string.Empty)
                    {
                        Console.WriteLine("You need to enter the ModelName before you enter the IP.");
                        return;
                    }
                    temp_Area = Area_Setting(Area_Name, Command_Name);

                    if (IsDgvAreaHasChanged == false || IsDgvDeviceHasChanged == false)
                    {
                        Console.WriteLine($"DgvArea or DgvDevice didn't changed.");
                        return;
                    }
                    else
                    {
                        int CMDList_found = AreaList.FindIndex(x => x.Name == Area_Name);
                        if (CMDList_found >= 0)
                        {
                            //currentName = AreaList[AreaList.FindIndex(x => x.Name == Area_Name)];
                            AreaList[CMDList_found] = temp_Area;//currentName;
                        }
                        else
                            AreaList.Add(temp_Area);
                        IsDgvAreaHasChanged = false;
                        IsDgvDeviceHasChanged = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void Dgv_Device_Leave(object sender, EventArgs e)
        {
            if (IsDgvAreaHasChanged == false || IsDgvDeviceHasChanged == false)
            {
                Console.WriteLine($"DgvArea or DgvDevice didn't changed.");
                return;
            }

            int CMDList_found = AreaList.FindIndex(x => x.Name == Area_Name);
            if (CMDList_found >= 0)
            {
                //currentName = AreaList[AreaList.FindIndex(x => x.Name == Area_Name)];
                AreaList[CMDList_found] = temp_Area;//currentName;
            }
            else
                AreaList.Add(temp_Area);

            IsDgvAreaHasChanged = false;
            IsDgvDeviceHasChanged = false;
        }

        private void Dgv_Device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                dgv_Device.Rows[e.RowIndex].Selected = true;
            }
        }
        private void Dgv_Area_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine($"dgv_Area_CellClick({e.ColumnIndex}, {e.RowIndex})");
            if (e.ColumnIndex < 0 || e.RowIndex < 0 ) return; //|| e.RowIndex == dgv_Area.RowCount
            try
            {
                switch (e.ColumnIndex)
                {
                    case (int)ColDgv_Area.AreaName:
                        break;

                    case (int)ColDgv_Area.CommandName:
                        dgv_Area.EndEdit();
                        dgv_Area.ReadOnly = true;

                        object ev = dgv_Area[e.ColumnIndex, e.RowIndex].Value;
                        DataGridViewComboBoxCell CommandCell = new DataGridViewComboBoxCell();
                        CommandCell.Items.Clear();//.Add(string.Empty);
                        foreach (Command command in CommandList)
                            CommandCell.Items.Add(command.Name);
                        CommandCell.Value = ev ?? string.Empty;
                        dgv_Area[e.ColumnIndex, e.RowIndex] = CommandCell;

                        dgv_Area.ReadOnly = false;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        enum ColDgv_Area { CheckBox, AreaName, CommandName }
        enum ColDgv_Device { CheckBox, ModelName, IP }
    }
}
