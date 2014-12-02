using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateOne.Data
{
    [Serializable]
    class Group
    {
        private List<EMTemplate>    _templates;
        private Color               _backgroundColor;
        private GroupBox            _groupBox;

        public GroupBox GetGroupBox()
        {
            return _groupBox;
        }
    }
}
