namespace WinFormsExplorerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer = new SplitContainer();
            treeViewDirectories = new TreeView();
            imageListDirIcon = new ImageList(components);
            listViewFilesDirs = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderSize = new ColumnHeader();
            imageListFilesIconsLarge = new ImageList(components);
            imageListFilesIconsSmall = new ImageList(components);
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolBar = new ToolStrip();
            toolBarComboViewStyle = new ToolStripComboBox();
            statusLine = new StatusStrip();
            statusLineAboutLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            menuMain.SuspendLayout();
            toolBar.SuspendLayout();
            statusLine.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer.Location = new Point(0, 52);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(treeViewDirectories);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(listViewFilesDirs);
            splitContainer.Size = new Size(924, 464);
            splitContainer.SplitterDistance = 361;
            splitContainer.TabIndex = 0;
            // 
            // treeViewDirectories
            // 
            treeViewDirectories.Dock = DockStyle.Fill;
            treeViewDirectories.Font = new Font("Segoe UI", 16F);
            treeViewDirectories.ImageIndex = 0;
            treeViewDirectories.ImageList = imageListDirIcon;
            treeViewDirectories.Location = new Point(0, 0);
            treeViewDirectories.Name = "treeViewDirectories";
            treeViewDirectories.SelectedImageIndex = 0;
            treeViewDirectories.Size = new Size(361, 464);
            treeViewDirectories.TabIndex = 0;
            treeViewDirectories.BeforeExpand += treeViewDirectories_BeforeExpand;
            treeViewDirectories.BeforeSelect += treeViewDirectories_BeforeSelect;
            // 
            // imageListDirIcon
            // 
            imageListDirIcon.ColorDepth = ColorDepth.Depth32Bit;
            imageListDirIcon.ImageStream = (ImageListStreamer)resources.GetObject("imageListDirIcon.ImageStream");
            imageListDirIcon.TransparentColor = Color.Transparent;
            imageListDirIcon.Images.SetKeyName(0, "folder.jpg");
            // 
            // listViewFilesDirs
            // 
            listViewFilesDirs.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderSize });
            listViewFilesDirs.Dock = DockStyle.Fill;
            listViewFilesDirs.Font = new Font("Segoe UI", 16F);
            listViewFilesDirs.LargeImageList = imageListFilesIconsLarge;
            listViewFilesDirs.Location = new Point(0, 0);
            listViewFilesDirs.Name = "listViewFilesDirs";
            listViewFilesDirs.Size = new Size(559, 464);
            listViewFilesDirs.SmallImageList = imageListFilesIconsSmall;
            listViewFilesDirs.TabIndex = 0;
            listViewFilesDirs.UseCompatibleStateImageBehavior = false;
            listViewFilesDirs.View = View.Details;
            listViewFilesDirs.SelectedIndexChanged += listViewFilesDirs_SelectedIndexChanged;
            listViewFilesDirs.MouseDoubleClick += listViewFilesDirs_MouseDoubleClick;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 300;
            // 
            // columnHeaderSize
            // 
            columnHeaderSize.Text = "Size";
            columnHeaderSize.Width = 200;
            // 
            // imageListFilesIconsLarge
            // 
            imageListFilesIconsLarge.ColorDepth = ColorDepth.Depth32Bit;
            imageListFilesIconsLarge.ImageStream = (ImageListStreamer)resources.GetObject("imageListFilesIconsLarge.ImageStream");
            imageListFilesIconsLarge.TransparentColor = Color.Transparent;
            imageListFilesIconsLarge.Images.SetKeyName(0, "folder.jpg");
            imageListFilesIconsLarge.Images.SetKeyName(1, "WORD.png");
            imageListFilesIconsLarge.Images.SetKeyName(2, "EXCEL.png");
            imageListFilesIconsLarge.Images.SetKeyName(3, "JPG.png");
            imageListFilesIconsLarge.Images.SetKeyName(4, "PDF.png");
            imageListFilesIconsLarge.Images.SetKeyName(5, "PNG.png");
            imageListFilesIconsLarge.Images.SetKeyName(6, "TEXT.png");
            imageListFilesIconsLarge.Images.SetKeyName(7, "OTHER.png");
            // 
            // imageListFilesIconsSmall
            // 
            imageListFilesIconsSmall.ColorDepth = ColorDepth.Depth32Bit;
            imageListFilesIconsSmall.ImageStream = (ImageListStreamer)resources.GetObject("imageListFilesIconsSmall.ImageStream");
            imageListFilesIconsSmall.TransparentColor = Color.Transparent;
            imageListFilesIconsSmall.Images.SetKeyName(0, "folder.jpg");
            imageListFilesIconsSmall.Images.SetKeyName(1, "WORD.png");
            imageListFilesIconsSmall.Images.SetKeyName(2, "EXCEL.png");
            imageListFilesIconsSmall.Images.SetKeyName(3, "JPG.png");
            imageListFilesIconsSmall.Images.SetKeyName(4, "PDF.png");
            imageListFilesIconsSmall.Images.SetKeyName(5, "PNG.png");
            imageListFilesIconsSmall.Images.SetKeyName(6, "TEXT.png");
            imageListFilesIconsSmall.Images.SetKeyName(7, "OTHER.png");
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(924, 24);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(141, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolBar
            // 
            toolBar.Items.AddRange(new ToolStripItem[] { toolBarComboViewStyle });
            toolBar.Location = new Point(0, 24);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(924, 25);
            toolBar.TabIndex = 2;
            toolBar.Text = "toolStrip1";
            // 
            // toolBarComboViewStyle
            // 
            toolBarComboViewStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            toolBarComboViewStyle.Items.AddRange(new object[] { "Large Icons", "Small Icons", "List", "Tile", "Details" });
            toolBarComboViewStyle.Name = "toolBarComboViewStyle";
            toolBarComboViewStyle.Size = new Size(121, 25);
            // 
            // statusLine
            // 
            statusLine.Items.AddRange(new ToolStripItem[] { statusLineAboutLabel });
            statusLine.Location = new Point(0, 519);
            statusLine.Name = "statusLine";
            statusLine.Size = new Size(924, 22);
            statusLine.TabIndex = 3;
            statusLine.Text = "statusStrip1";
            // 
            // statusLineAboutLabel
            // 
            statusLineAboutLabel.Name = "statusLineAboutLabel";
            statusLineAboutLabel.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 541);
            Controls.Add(statusLine);
            Controls.Add(toolBar);
            Controls.Add(menuMain);
            Controls.Add(splitContainer);
            Name = "Form1";
            Text = "Form1";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            statusLine.ResumeLayout(false);
            statusLine.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer;
        private TreeView treeViewDirectories;
        private ImageList imageListDirIcon;
        private ListView listViewFilesDirs;
        private ImageList imageListFilesIconsSmall;
        private ImageList imageListFilesIconsLarge;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderSize;
        private MenuStrip menuMain;
        private ToolStrip toolBar;
        private StatusStrip statusLine;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripComboBox toolBarComboViewStyle;
        private ToolStripStatusLabel statusLineAboutLabel;
    }
}
