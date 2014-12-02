using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using Polenter.Serialization;

namespace TemplateOne.Data
{
    public class ItemData
    {
        public String buttonText { get; set; }
        public KeyValuePair<String, String> fields { get; set; }

        public ItemData()
        {
            this.buttonText = "";
            fields = new KeyValuePair<string, string>();
        }
        public ItemData(String buttonText = "")
        {
            this.buttonText = buttonText;
            fields = new KeyValuePair<string, string>();
        }
    }

    public class GroupData
    {
        public Color color;

        [ExcludeFromSerialization]
        public Color groupColor
        {
            get { return color; }
            set { color = value; }
        }
        [XmlElement("groupColor")]
        public string groupColorHtml
        {
            get { return ColorTranslator.ToHtml(groupColor); }
            set { groupColor = ColorTranslator.FromHtml(value); }
        }

        public String groupName;
        public List<ItemData> items;

        public GroupData()
        {
            this.color = Color.White;
            this.groupName = "";
            items = new List<ItemData>();
        }
        public GroupData(Color color, string groupName = "")
        {
            this.color = color;
            this.groupName = groupName;
            items = new List<ItemData>();
        }

        public void HandleRemove(object sender, EventArgs e)
        {
            
        }
    }

    public class SettingsData
    {
        public bool alwaysOnTop { get; set; }

        public SettingsData()
        {
            this.alwaysOnTop = false;
        }
        public SettingsData(bool alwaysOnTop = false)
        {
            this.alwaysOnTop = alwaysOnTop;
        }
    }

    public class Data
    {
        public SettingsData settings { get; set; }
        public List<GroupData>  groups { get; set; }

        public Data()
        {
            settings = new SettingsData();
            groups = new List<GroupData>();
        }
    }
}
