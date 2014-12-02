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

using Polenter.Serialization;

namespace TemplateOne
{
    enum HitTest
    {
        Caption = 2,
        Transparent = -1,
        Nowhere = 0,
        Client = 1,
        Left = 10,
        Right = 11,
        Top = 12,
        TopLeft = 13,
        TopRight = 14,
        Bottom = 15,
        BottomLeft = 16,
        BottomRight = 17,
        Border = 18
    }

    public partial class MainForm : Form
    {
        private Form childForm;

        public MainForm()
        {
            InitializeComponent();   
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case 0x84: //WM_NCHITTEST
                    var result = (HitTest)m.Result.ToInt32();
                    if (result == HitTest.Left || result == HitTest.Right)
                        m.Result = new IntPtr((int)HitTest.Caption);
                    if (result == HitTest.TopLeft || result == HitTest.TopRight)
                        m.Result = new IntPtr((int)HitTest.Top);
                    if (result == HitTest.BottomLeft || result == HitTest.BottomRight)
                        m.Result = new IntPtr((int)HitTest.Bottom);

                    break;
            }
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            SetChildFormPosition();
        }

        private void SetChildFormPosition()
        {
            Point p = new Point(this.Location.X + this.Width, this.Location.Y);

            if (childForm != null)
                childForm.Location = p;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportDialog.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importDialog.ShowDialog();
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (exportDialog.FileName == "")
                return;

            SharpSerializer serializer;
            switch (exportDialog.FilterIndex)
            {
                case 1:
                    serializer = new SharpSerializer();
                    break;
                case 2:
                    serializer = new SharpSerializer(true);
                    break;
                default:
                    return;
            }

            serializer.Serialize(GlobalData.data, exportDialog.FileName);
        }

        private void importDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (importDialog.FileName == "")
                return;

            SharpSerializer serializer;
            switch (importDialog.FilterIndex)
            {
                case 1:
                    serializer = new SharpSerializer();
                    break;
                case 2:
                    serializer = new SharpSerializer(true);
                    break;
                default:
                    return;
            }
            try
            {
                GlobalData.data = (Data.Data)serializer.Deserialize(importDialog.FileName);
            }
            catch(Polenter.Serialization.Core.DeserializingException exception)
            {
                MessageBox.Show("Could not read file " + importDialog.FileName + ", file may be corrupt!");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "FormSettings")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                childForm = new FormSettings();
                childForm.Show();
                childForm.Owner = this;
                childForm.ShowInTaskbar = false;
                childForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }
        }
    }
}
