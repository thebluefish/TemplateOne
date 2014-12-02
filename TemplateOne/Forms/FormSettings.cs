using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateOne
{
    public partial class FormSettings : Form
    {
         

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Enter(object sender, EventArgs e)
        {

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            bool r = true;
        }

        private void b_newGroup_Click(object sender, EventArgs e)
        {
            if (tb_groupName.Text == "" || tb_groupName.WatermarkActive == true)
                return;

            Data.GroupData group = new Data.GroupData(bColorPicker.BackColor, tb_groupName.Text);
            
            GlobalData.data.groups.Add(group);

            //TreeNode node = new TreeNode(tb_groupName.Text);
            //TreeGroup tgrp = new TreeGroup();
            //node.Tag = tgrp;

            //ContextMenuStrip contextMenu = new ContextMenuStrip();

            //ToolStripMenuItem removeLabel = new ToolStripMenuItem();
            //removeLabel.Text = "Remove";
            ////removeLabel.MouseUp += tgrp.HandleRemove;
            //contextMenu.Items.Add(removeLabel);

            //node.ContextMenuStrip = contextMenu;
            //tv_Items.Nodes.Add(node);
        }

        void removeLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void tv_Items_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bColorPicker_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            bColorPicker.BackColor = colorPicker.Color;
        }
    }
}
