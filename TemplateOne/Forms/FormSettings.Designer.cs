namespace TemplateOne
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        { 
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.b_newGroup = new System.Windows.Forms.Button();
            this.tv_Items = new System.Windows.Forms.TreeView();
            this.showOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.itemsTab = new System.Windows.Forms.TabPage();
            this.variablesTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_groupName = new TemplateOne.WatermarkTextBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.bColorPicker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(44, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Size = new System.Drawing.Size(284, 364);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTab);
            this.tabControl1.Controls.Add(this.itemsTab);
            this.tabControl1.Controls.Add(this.variablesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.bColorPicker);
            this.generalTab.Controls.Add(this.tb_groupName);
            this.generalTab.Controls.Add(this.b_newGroup);
            this.generalTab.Controls.Add(this.tv_Items);
            this.generalTab.Controls.Add(this.showOnTopCheckbox);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(276, 305);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // b_newGroup
            // 
            this.b_newGroup.Location = new System.Drawing.Point(153, 52);
            this.b_newGroup.Name = "b_newGroup";
            this.b_newGroup.Size = new System.Drawing.Size(115, 23);
            this.b_newGroup.TabIndex = 2;
            this.b_newGroup.Text = "New Group";
            this.b_newGroup.UseVisualStyleBackColor = true;
            this.b_newGroup.Click += new System.EventHandler(this.b_newGroup_Click);
            // 
            // tv_Items
            // 
            this.tv_Items.Location = new System.Drawing.Point(8, 3);
            this.tv_Items.Name = "tv_Items";
            this.tv_Items.Size = new System.Drawing.Size(139, 299);
            this.tv_Items.TabIndex = 1;
            this.tv_Items.Click += new System.EventHandler(this.treeView1_Click);
            this.tv_Items.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tv_Items_MouseDown);
            // 
            // showOnTopCheckbox
            // 
            this.showOnTopCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showOnTopCheckbox.AutoSize = true;
            this.showOnTopCheckbox.Location = new System.Drawing.Point(153, 3);
            this.showOnTopCheckbox.Name = "showOnTopCheckbox";
            this.showOnTopCheckbox.Size = new System.Drawing.Size(120, 17);
            this.showOnTopCheckbox.TabIndex = 0;
            this.showOnTopCheckbox.Text = "Always show on top";
            this.showOnTopCheckbox.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Location = new System.Drawing.Point(4, 22);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(276, 305);
            this.itemsTab.TabIndex = 1;
            this.itemsTab.Text = "Items";
            this.itemsTab.UseVisualStyleBackColor = true;
            // 
            // variablesTab
            // 
            this.variablesTab.Location = new System.Drawing.Point(4, 22);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.Size = new System.Drawing.Size(276, 305);
            this.variablesTab.TabIndex = 2;
            this.variablesTab.Text = "Variables";
            this.variablesTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(206, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(125, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tb_groupName
            // 
            this.tb_groupName.ForeColor = System.Drawing.Color.Gray;
            this.tb_groupName.Location = new System.Drawing.Point(153, 26);
            this.tb_groupName.Name = "tb_groupName";
            this.tb_groupName.Size = new System.Drawing.Size(89, 20);
            this.tb_groupName.TabIndex = 3;
            this.tb_groupName.Text = "Group Name";
            this.tb_groupName.WatermarkActive = true;
            this.tb_groupName.WatermarkText = "Group Name";
            // 
            // bColorPicker
            // 
            this.bColorPicker.BackColor = System.Drawing.Color.White;
            this.bColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bColorPicker.Location = new System.Drawing.Point(248, 26);
            this.bColorPicker.Name = "bColorPicker";
            this.bColorPicker.Size = new System.Drawing.Size(20, 20);
            this.bColorPicker.TabIndex = 4;
            this.bColorPicker.UseVisualStyleBackColor = false;
            this.bColorPicker.Click += new System.EventHandler(this.bColorPicker_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 364);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Enter += new System.EventHandler(this.FormSettings_Enter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TreeView tv_Items;
        private System.Windows.Forms.CheckBox showOnTopCheckbox;
        private System.Windows.Forms.TabPage itemsTab;
        private System.Windows.Forms.TabPage variablesTab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private WatermarkTextBox tb_groupName;
        private System.Windows.Forms.Button b_newGroup;
        private System.Windows.Forms.Button bColorPicker;
        private System.Windows.Forms.ColorDialog colorPicker;
    }
}