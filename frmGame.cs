using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713153.Properties;

namespace WP_2020_01_HW02_3A713153
{

    public partial class frmGame : Form
    {
        List<Image> list = new List<Image>();

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);
            list.Add(Resources._004);
            list.Add(Resources._005);
            list.Add(Resources._006);
            list.Add(Resources._007);
            list.Add(Resources._008);
            list.Add(Resources._009);
            list.Add(Resources._010);
            list.Add(Resources._011);
            list.Add(Resources._012);
            list.Add(Resources._013);
            list.Add(Resources._014);
            list.Add(Resources._015);
            list.Add(Resources._016);
            list.Add(Resources._017);
            list.Add(Resources._018);
            list.Add(Resources._019);
            list.Add(Resources._020);
            list.Add(Resources._021);
            list.Add(Resources._022);
            list.Add(Resources._023);
            list.Add(Resources._024);
            list.Add(Resources._025);
            list.Add(Resources._026);
            list.Add(Resources._027);
            list.Add(Resources._028);
            list.Add(Resources._029);
            list.Add(Resources._030);
            list.Add(Resources._031);
            list.Add(Resources._032);
            list.Add(Resources._033);
            list.Add(Resources._034);
            list.Add(Resources._035);
            list.Add(Resources._036);
            list.Add(Resources._037);
            list.Add(Resources._038);
            list.Add(Resources._039);
            list.Add(Resources._040);
            list.Add(Resources._041);
            list.Add(Resources._042);
            list.Add(Resources._043);
            list.Add(Resources._044);
            list.Add(Resources._045);
            list.Add(Resources._046);
            list.Add(Resources._047);
            list.Add(Resources._048);
            list.Add(Resources._049);
            list.Add(Resources._050);
            list.Add(Resources._051);
            list.Add(Resources._052);
            
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            int index = (new Random()).Next(51);//模擬隨機產生 一個值;
            
            
            picResult.Image = list[index];
        }
    }
}
