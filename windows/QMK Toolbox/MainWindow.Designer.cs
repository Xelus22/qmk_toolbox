namespace QMK_Toolbox {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.flashButton = new System.Windows.Forms.Button();
            this.autoflashCheckbox = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.mcuLabel = new System.Windows.Forms.Label();
            this.qmkfmGroupBox = new System.Windows.Forms.GroupBox();
            this.keymapLabel = new System.Windows.Forms.Label();
            this.keymapBox = new System.Windows.Forms.ComboBox();
            this.keyboardBox = new System.Windows.Forms.ComboBox();
            this.loadKeymapButton = new System.Windows.Forms.Button();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.mcuBox = new System.Windows.Forms.ComboBox();
            this.clearEepromButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.logContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logContextMenuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logContextMenuSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidList = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuSep = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuSep = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuSep = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filepathBox = new QMK_Toolbox.BetterComboBox();
            this.qmkfmGroupBox.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.logContextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flashButton
            // 
            this.flashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flashButton.Enabled = false;
            this.flashButton.Location = new System.Drawing.Point(653, 86);
            this.flashButton.Name = "flashButton";
            this.flashButton.Size = new System.Drawing.Size(62, 23);
            this.flashButton.TabIndex = 6;
            this.flashButton.Text = "Flash";
            this.flashButton.Click += new System.EventHandler(this.flashButton_Click);
            // 
            // autoflashCheckbox
            // 
            this.autoflashCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoflashCheckbox.AutoSize = true;
            this.autoflashCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.autoflashCheckbox.Location = new System.Drawing.Point(653, 115);
            this.autoflashCheckbox.Name = "autoflashCheckbox";
            this.autoflashCheckbox.Size = new System.Drawing.Size(76, 17);
            this.autoflashCheckbox.TabIndex = 5;
            this.autoflashCheckbox.Text = "Auto-Flash";
            this.autoflashCheckbox.UseVisualStyleBackColor = false;
            this.autoflashCheckbox.CheckedChanged += new System.EventHandler(this.autoflashCheckbox_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Intel Hex and Binary (*.hex;*.bin)|*.hex;*.bin|Intel Hex (*.hex)|*.hex|Binary (*." +
    "bin)|*.bin";
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.Location = new System.Drawing.Point(571, 18);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(64, 23);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(721, 86);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(67, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Exit DFU";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // mcuLabel
            // 
            this.mcuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcuLabel.AutoSize = true;
            this.mcuLabel.Location = new System.Drawing.Point(638, 0);
            this.mcuLabel.Name = "mcuLabel";
            this.mcuLabel.Size = new System.Drawing.Size(84, 13);
            this.mcuLabel.TabIndex = 22;
            this.mcuLabel.Text = "MCU (AVR only)";
            // 
            // qmkfmGroupBox
            // 
            this.qmkfmGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qmkfmGroupBox.Controls.Add(this.keymapLabel);
            this.qmkfmGroupBox.Controls.Add(this.keymapBox);
            this.qmkfmGroupBox.Controls.Add(this.keyboardBox);
            this.qmkfmGroupBox.Controls.Add(this.loadKeymapButton);
            this.qmkfmGroupBox.Location = new System.Drawing.Point(12, 86);
            this.qmkfmGroupBox.Name = "qmkfmGroupBox";
            this.qmkfmGroupBox.Size = new System.Drawing.Size(635, 48);
            this.qmkfmGroupBox.TabIndex = 23;
            this.qmkfmGroupBox.TabStop = false;
            this.qmkfmGroupBox.Text = "Keyboard from qmk.fm";
            // 
            // keymapLabel
            // 
            this.keymapLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keymapLabel.AutoSize = true;
            this.keymapLabel.Location = new System.Drawing.Point(447, 0);
            this.keymapLabel.Name = "keymapLabel";
            this.keymapLabel.Size = new System.Drawing.Size(45, 13);
            this.keymapLabel.TabIndex = 24;
            this.keymapLabel.Text = "Keymap";
            // 
            // keymapBox
            // 
            this.keymapBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keymapBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMK_Toolbox.Properties.Settings.Default, "keymap", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keymapBox.Enabled = false;
            this.keymapBox.FormattingEnabled = true;
            this.keymapBox.Items.AddRange(new object[] {
            "later version!"});
            this.keymapBox.Location = new System.Drawing.Point(450, 19);
            this.keymapBox.Name = "keymapBox";
            this.keymapBox.Size = new System.Drawing.Size(109, 21);
            this.keymapBox.TabIndex = 4;
            this.keymapBox.Text = global::QMK_Toolbox.Properties.Settings.Default.keymap;
            // 
            // keyboardBox
            // 
            this.keyboardBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyboardBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.keyboardBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.keyboardBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMK_Toolbox.Properties.Settings.Default, "keyboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keyboardBox.Enabled = false;
            this.keyboardBox.FormattingEnabled = true;
            this.keyboardBox.Items.AddRange(new object[] {
            "this feature coming in"});
            this.keyboardBox.Location = new System.Drawing.Point(6, 19);
            this.keyboardBox.Name = "keyboardBox";
            this.keyboardBox.Size = new System.Drawing.Size(438, 21);
            this.keyboardBox.TabIndex = 4;
            this.keyboardBox.Text = global::QMK_Toolbox.Properties.Settings.Default.keyboard;
            this.keyboardBox.TextChanged += new System.EventHandler(this.keyboardBox_TextChanged);
            // 
            // loadKeymapButton
            // 
            this.loadKeymapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadKeymapButton.Enabled = false;
            this.loadKeymapButton.Location = new System.Drawing.Point(565, 18);
            this.loadKeymapButton.Name = "loadKeymapButton";
            this.loadKeymapButton.Size = new System.Drawing.Size(64, 23);
            this.loadKeymapButton.TabIndex = 3;
            this.loadKeymapButton.Text = "Load";
            this.loadKeymapButton.UseVisualStyleBackColor = true;
            this.loadKeymapButton.Click += new System.EventHandler(this.loadKeymapButton_Click);
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGroupBox.Controls.Add(this.openFileButton);
            this.fileGroupBox.Controls.Add(this.filepathBox);
            this.fileGroupBox.Controls.Add(this.mcuLabel);
            this.fileGroupBox.Controls.Add(this.mcuBox);
            this.fileGroupBox.Location = new System.Drawing.Point(12, 32);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(776, 48);
            this.fileGroupBox.TabIndex = 25;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Local file";
            // 
            // mcuBox
            // 
            this.mcuBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcuBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMK_Toolbox.Properties.Settings.Default, "targetSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mcuBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcuBox.FormattingEnabled = true;
            this.mcuBox.Location = new System.Drawing.Point(641, 19);
            this.mcuBox.Name = "mcuBox";
            this.mcuBox.Size = new System.Drawing.Size(129, 21);
            this.mcuBox.TabIndex = 4;
            this.mcuBox.Text = global::QMK_Toolbox.Properties.Settings.Default.targetSetting;
            // 
            // clearEepromButton
            // 
            this.clearEepromButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearEepromButton.Enabled = false;
            this.clearEepromButton.Location = new System.Drawing.Point(12, 630);
            this.clearEepromButton.Name = "clearEepromButton";
            this.clearEepromButton.Size = new System.Drawing.Size(110, 23);
            this.clearEepromButton.TabIndex = 27;
            this.clearEepromButton.Text = "Clear EEPROM";
            this.clearEepromButton.UseVisualStyleBackColor = true;
            this.clearEepromButton.Click += new System.EventHandler(this.clearEepromButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.ContextMenuStrip = this.logContextMenu;
            this.logTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ZoomFactor", global::QMK_Toolbox.Properties.Settings.Default, "outputZoom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.logTextBox.DetectUrls = false;
            this.logTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.HideSelection = false;
            this.logTextBox.Location = new System.Drawing.Point(12, 140);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(776, 484);
            this.logTextBox.TabIndex = 1;
            this.logTextBox.Text = "";
            this.logTextBox.WordWrap = false;
            this.logTextBox.ZoomFactor = global::QMK_Toolbox.Properties.Settings.Default.outputZoom;
            // 
            // logContextMenu
            // 
            this.logContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.logContextMenuSep1,
            this.selectAllToolStripMenuItem,
            this.logContextMenuSep2,
            this.clearToolStripMenuItem});
            this.logContextMenu.Name = "contextMenuStrip2";
            this.logContextMenu.ShowImageMargin = false;
            this.logContextMenu.Size = new System.Drawing.Size(140, 126);
            this.logContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.logContextMenuStrip_Opening);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // logContextMenuSep1
            // 
            this.logContextMenuSep1.Name = "logContextMenuSep1";
            this.logContextMenuSep1.Size = new System.Drawing.Size(136, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // logContextMenuSep2
            // 
            this.logContextMenuSep2.Name = "logContextMenuSep2";
            this.logContextMenuSep2.Size = new System.Drawing.Size(136, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearToolStripMenuItem.Text = "Clea&r";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // hidList
            // 
            this.hidList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hidList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hidList.FormattingEnabled = true;
            this.hidList.Location = new System.Drawing.Point(128, 631);
            this.hidList.Name = "hidList";
            this.hidList.Size = new System.Drawing.Size(660, 21);
            this.hidList.TabIndex = 29;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 30;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.fileToolStripMenuSep,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // fileToolStripMenuSep
            // 
            this.fileToolStripMenuSep.Name = "fileToolStripMenuSep";
            this.fileToolStripMenuSep.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installDriversToolStripMenuItem,
            this.toolsToolStripMenuSep,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // installDriversToolStripMenuItem
            // 
            this.installDriversToolStripMenuItem.Name = "installDriversToolStripMenuItem";
            this.installDriversToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.installDriversToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.installDriversToolStripMenuItem.Text = "I&nstall Drivers...";
            this.installDriversToolStripMenuItem.Click += new System.EventHandler(this.installDriversMenuItem_Click);
            // 
            // toolsToolStripMenuSep
            // 
            this.toolsToolStripMenuSep.Name = "toolsToolStripMenuSep";
            this.toolsToolStripMenuSep.Size = new System.Drawing.Size(193, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.optionsToolStripMenuItem.Text = "O&ptions...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.helpToolStripMenuSep,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Enabled = false;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates...";
            // 
            // helpToolStripMenuSep
            // 
            this.helpToolStripMenuSep.Name = "helpToolStripMenuSep";
            this.helpToolStripMenuSep.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // filepathBox
            // 
            this.filepathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filepathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMK_Toolbox.Properties.Settings.Default, "hexFileSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.filepathBox.FormattingEnabled = true;
            this.filepathBox.Location = new System.Drawing.Point(6, 19);
            this.filepathBox.Name = "filepathBox";
            this.filepathBox.Size = new System.Drawing.Size(558, 21);
            this.filepathBox.TabIndex = 2;
            this.filepathBox.Text = global::QMK_Toolbox.Properties.Settings.Default.hexFileSetting;
            this.filepathBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filepathBox_KeyDown);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.hidList);
            this.Controls.Add(this.clearEepromButton);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.qmkfmGroupBox);
            this.Controls.Add(this.flashButton);
            this.Controls.Add(this.autoflashCheckbox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.resetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(816, 703);
            this.Name = "MainWindow";
            this.Text = "QMK Toolbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.qmkfmGroupBox.ResumeLayout(false);
            this.qmkfmGroupBox.PerformLayout();
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.logContextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox mcuBox;
        private System.Windows.Forms.Button flashButton;
        private System.Windows.Forms.CheckBox autoflashCheckbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label mcuLabel;
        private System.Windows.Forms.GroupBox qmkfmGroupBox;
        private System.Windows.Forms.ComboBox keymapBox;
        private System.Windows.Forms.ComboBox keyboardBox;
        private System.Windows.Forms.Button loadKeymapButton;
        private System.Windows.Forms.Label keymapLabel;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.Button clearEepromButton;
        private System.Windows.Forms.ComboBox hidList;
        private System.Windows.Forms.ContextMenuStrip logContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private BetterComboBox filepathBox;
        private System.Windows.Forms.ToolStripSeparator logContextMenuSep1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator logContextMenuSep2;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileToolStripMenuSep;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolsToolStripMenuSep;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator helpToolStripMenuSep;
    }
}

