namespace WinFormsExplorerApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, FileType> fileExtensions;
        string currentPath = "";

        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem itemMenu = new ToolStripMenuItem("&Help");
            ToolStripMenuItem aboutItem = new ToolStripMenuItem("&About");
            aboutItem.Image = Bitmap.FromFile(@"D:\icon2.png");
            aboutItem.Click += AboutItem_Click;
            aboutItem.ShortcutKeys = Keys.Control | Keys.A;
            itemMenu.DropDownItems.Add(aboutItem);

            menuMain.Items.Add(itemMenu);

            listViewFilesDirs.View = View.List;
            toolBarComboViewStyle.SelectedIndex = 2;
            toolBarComboViewStyle.SelectedIndexChanged += ToolBarComboViewStyle_SelectedIndexChanged;


            fileExtensions = new()
            {
                { "docx", FileType.Word },
                { "xclx", FileType.Excel },
                { "pdf", FileType.Pdf },
                { "jpg", FileType.Jpg },
                { "png", FileType.Png },
                { "txt", FileType.Text }
            };

            FillDrives();
            treeViewDirectories.ImageIndex = (int)FileType.Folder;
        }

        private void ToolBarComboViewStyle_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch(toolBarComboViewStyle.SelectedIndex)
            {
                case 0: listViewFilesDirs.View = View.LargeIcon; break;
                case 1: listViewFilesDirs.View = View.SmallIcon; break;
                case 2: listViewFilesDirs.View = View.List; break;
                case 3: listViewFilesDirs.View = View.Tile; break;
                case 4: listViewFilesDirs.View = View.Details; break;
            }
        }

        private void AboutItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Explorer v1.0",
                            "About program",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void treeViewDirectories_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();
            if (Directory.Exists(e.Node?.FullPath))
            {
                FillDirNode(e.Node, e.Node.FullPath);
                FillFilesDirsList(e.Node.FullPath);
                currentPath = e.Node.FullPath;
                statusLineAboutLabel.Text = currentPath;
            }
        }

        private void treeViewDirectories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();
            if (Directory.Exists(e.Node?.FullPath))
            {
                FillDirNode(e.Node, e.Node.FullPath);
                FillFilesDirsList(e.Node.FullPath);
            }
        }

        private void FillDrives()
        {
            try
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady)
                    {
                        TreeNode driveNode = new TreeNode();
                        driveNode.Text = drive.Name;
                        driveNode.ImageIndex = (int)FileType.Folder;
                        FillDirNode(driveNode, drive.Name);
                        treeViewDirectories.Nodes.Add(driveNode);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDirNode(TreeNode parentNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (var dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf(@"\") + 1);
                    parentNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFilesDirsList(string path)
        {
            listViewFilesDirs.Items.Clear();

            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dir.Remove(0, dir.LastIndexOf(@"\") + 1);
                item.ImageIndex = (int)FileType.Folder;
                item.SubItems.Add("<directory>");

                listViewFilesDirs.Items.Add(item);
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = file.Remove(0, file.LastIndexOf(@"\") + 1);

                string ext = file.Remove(0, file.LastIndexOf(@".") + 1);
                if (fileExtensions.ContainsKey(ext))
                    item.ImageIndex = (int)fileExtensions[ext];
                else
                    item.ImageIndex = (int)FileType.Other;

                var fileInfo = new FileInfo(file);
                item.SubItems.Add((fileInfo.Length / 1024).ToString() + " Kb");

                listViewFilesDirs.Items.Add(item);
            }
        }

        private void listViewFilesDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statusStr = "Items: " + listViewFilesDirs.SelectedIndices.Count.ToString();
            //statusLineAboutLabel.Text = statusStr;
        }

        private void listViewFilesDirs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItem = currentPath + @"\" + listViewFilesDirs.SelectedItems[0].Text;
            //statusLineAboutLabel.Text = selectedItem;
            //treeViewDirectories.SelectedNode.Nodes.
        }
    }
}
