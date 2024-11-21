using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyFarm
{
    public partial class BoxMessage : Form
    {
        public BoxMessage(String status, String descricao)
        {
            InitializeComponent();
            lbDescricao.Text = descricao;
            lbStatus.Text = status;
            Show();
        }
    }
}
