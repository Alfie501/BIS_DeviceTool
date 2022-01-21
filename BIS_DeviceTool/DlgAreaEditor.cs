using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS_DeviceTool
{
    public partial class DlgAreaEditor : Form
    {
        List<Area> AreaList;
        public DlgAreaEditor(List<Area> AreaList)
        {
            InitializeComponent();
            //0823
            this.AreaList = AreaList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Area area in AreaList)
                dgv_Area.Rows.Add(new object[] { });
        }
    }
}
