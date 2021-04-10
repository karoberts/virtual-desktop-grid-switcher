namespace VirtualDesktopGridSwitcher.Settings {
    partial class SettingsDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.checkBoxWrapAround = new System.Windows.Forms.CheckBox();
            this.labelKeyModifiers = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.checkBoxCtrlModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxWinModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxFKeys = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxWinModifierMove = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierMove = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierMove = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlModifierMove = new System.Windows.Forms.CheckBox();
            this.labelMoveToDesktopModifiers = new System.Windows.Forms.Label();
            this.checkBoxActivateWebBrowser = new System.Windows.Forms.CheckBox();
            this.toolTipSettingsDialog = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxWinModifierSticky = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierSticky = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierSticky = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlModifierSticky = new System.Windows.Forms.CheckBox();
            this.labelToggleSticky = new System.Windows.Forms.Label();
            this.checkBoxWinModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.labelToggleAkwaysOnTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prevSizeRatio = new System.Windows.Forms.TextBox();
            this.prevPosOff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKeySticky = new System.Windows.Forms.ComboBox();
            this.comboBoxAlwaysOnTopKey = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prevHoverChk = new System.Windows.Forms.CheckBox();
            this.prevCloseDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRows.Location = new System.Drawing.Point(215, 14);
            this.labelRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(62, 20);
            this.labelRows.TabIndex = 3;
            this.labelRows.Text = "Rows:";
            this.toolTipSettingsDialog.SetToolTip(this.labelRows, "Number of rows in desktop grid");
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelColumns.Location = new System.Drawing.Point(16, 14);
            this.labelColumns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(92, 20);
            this.labelColumns.TabIndex = 1;
            this.labelColumns.Text = "Columns:";
            this.toolTipSettingsDialog.SetToolTip(this.labelColumns, "Number of columns in desktop grid");
            // 
            // checkBoxWrapAround
            // 
            this.checkBoxWrapAround.AutoSize = true;
            this.checkBoxWrapAround.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWrapAround.Location = new System.Drawing.Point(424, 12);
            this.checkBoxWrapAround.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWrapAround.Name = "checkBoxWrapAround";
            this.checkBoxWrapAround.Size = new System.Drawing.Size(144, 24);
            this.checkBoxWrapAround.TabIndex = 5;
            this.checkBoxWrapAround.Text = "Wrap Around";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWrapAround, "Switch/Move to opposite side of grid when move beyond edge");
            this.checkBoxWrapAround.UseVisualStyleBackColor = true;
            // 
            // labelKeyModifiers
            // 
            this.labelKeyModifiers.AutoSize = true;
            this.labelKeyModifiers.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelKeyModifiers.Location = new System.Drawing.Point(16, 47);
            this.labelKeyModifiers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyModifiers.Name = "labelKeyModifiers";
            this.labelKeyModifiers.Size = new System.Drawing.Size(234, 20);
            this.labelKeyModifiers.TabIndex = 6;
            this.labelKeyModifiers.Text = "Switch Desktop Modifiers:";
            this.toolTipSettingsDialog.SetToolTip(this.labelKeyModifiers, "Key modifier combination to use with arrow keys to switch to another desktop");
            // 
            // textBoxRows
            // 
            this.textBoxRows.Enabled = false;
            this.textBoxRows.Location = new System.Drawing.Point(287, 12);
            this.textBoxRows.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(64, 22);
            this.textBoxRows.TabIndex = 4;
            this.toolTipSettingsDialog.SetToolTip(this.textBoxRows, "Number of rows in desktop grid");
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Enabled = false;
            this.textBoxColumns.Location = new System.Drawing.Point(115, 12);
            this.textBoxColumns.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(64, 22);
            this.textBoxColumns.TabIndex = 2;
            this.toolTipSettingsDialog.SetToolTip(this.textBoxColumns, "Number of columns in desktop grid");
            // 
            // checkBoxCtrlModifierSwitch
            // 
            this.checkBoxCtrlModifierSwitch.AutoSize = true;
            this.checkBoxCtrlModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierSwitch.Location = new System.Drawing.Point(275, 46);
            this.checkBoxCtrlModifierSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCtrlModifierSwitch.Name = "checkBoxCtrlModifierSwitch";
            this.checkBoxCtrlModifierSwitch.Size = new System.Drawing.Size(62, 24);
            this.checkBoxCtrlModifierSwitch.TabIndex = 7;
            this.checkBoxCtrlModifierSwitch.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxCtrlModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierSwitch
            // 
            this.checkBoxShiftModifierSwitch.AutoSize = true;
            this.checkBoxShiftModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierSwitch.Location = new System.Drawing.Point(493, 46);
            this.checkBoxShiftModifierSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShiftModifierSwitch.Name = "checkBoxShiftModifierSwitch";
            this.checkBoxShiftModifierSwitch.Size = new System.Drawing.Size(72, 24);
            this.checkBoxShiftModifierSwitch.TabIndex = 10;
            this.checkBoxShiftModifierSwitch.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxShiftModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierSwitch
            // 
            this.checkBoxAltModifierSwitch.AutoSize = true;
            this.checkBoxAltModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierSwitch.Location = new System.Drawing.Point(424, 46);
            this.checkBoxAltModifierSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAltModifierSwitch.Name = "checkBoxAltModifierSwitch";
            this.checkBoxAltModifierSwitch.Size = new System.Drawing.Size(55, 24);
            this.checkBoxAltModifierSwitch.TabIndex = 9;
            this.checkBoxAltModifierSwitch.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxAltModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinModifierSwitch
            // 
            this.checkBoxWinModifierSwitch.AutoSize = true;
            this.checkBoxWinModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierSwitch.Location = new System.Drawing.Point(349, 46);
            this.checkBoxWinModifierSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWinModifierSwitch.Name = "checkBoxWinModifierSwitch";
            this.checkBoxWinModifierSwitch.Size = new System.Drawing.Size(64, 24);
            this.checkBoxWinModifierSwitch.TabIndex = 8;
            this.checkBoxWinModifierSwitch.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxWinModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxFKeys
            // 
            this.checkBoxFKeys.AutoSize = true;
            this.checkBoxFKeys.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxFKeys.Location = new System.Drawing.Point(20, 107);
            this.checkBoxFKeys.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFKeys.Name = "checkBoxFKeys";
            this.checkBoxFKeys.Size = new System.Drawing.Size(195, 24);
            this.checkBoxFKeys.TabIndex = 16;
            this.checkBoxFKeys.Text = "F1-12 for Numbers";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxFKeys, "Use normal number keys or F number keys with modifiers to jump to specific deskto" +
        "p");
            this.checkBoxFKeys.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonApply.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonApply.Location = new System.Drawing.Point(536, 312);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 28);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonCancel.Location = new System.Drawing.Point(647, 312);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinModifierMove
            // 
            this.checkBoxWinModifierMove.AutoSize = true;
            this.checkBoxWinModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierMove.Location = new System.Drawing.Point(349, 78);
            this.checkBoxWinModifierMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWinModifierMove.Name = "checkBoxWinModifierMove";
            this.checkBoxWinModifierMove.Size = new System.Drawing.Size(64, 24);
            this.checkBoxWinModifierMove.TabIndex = 13;
            this.checkBoxWinModifierMove.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxWinModifierMove.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierMove
            // 
            this.checkBoxAltModifierMove.AutoSize = true;
            this.checkBoxAltModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierMove.Location = new System.Drawing.Point(424, 78);
            this.checkBoxAltModifierMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAltModifierMove.Name = "checkBoxAltModifierMove";
            this.checkBoxAltModifierMove.Size = new System.Drawing.Size(55, 24);
            this.checkBoxAltModifierMove.TabIndex = 14;
            this.checkBoxAltModifierMove.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxAltModifierMove.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierMove
            // 
            this.checkBoxShiftModifierMove.AutoSize = true;
            this.checkBoxShiftModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierMove.Location = new System.Drawing.Point(493, 78);
            this.checkBoxShiftModifierMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShiftModifierMove.Name = "checkBoxShiftModifierMove";
            this.checkBoxShiftModifierMove.Size = new System.Drawing.Size(72, 24);
            this.checkBoxShiftModifierMove.TabIndex = 15;
            this.checkBoxShiftModifierMove.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxShiftModifierMove.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrlModifierMove
            // 
            this.checkBoxCtrlModifierMove.AutoSize = true;
            this.checkBoxCtrlModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierMove.Location = new System.Drawing.Point(275, 78);
            this.checkBoxCtrlModifierMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCtrlModifierMove.Name = "checkBoxCtrlModifierMove";
            this.checkBoxCtrlModifierMove.Size = new System.Drawing.Size(62, 24);
            this.checkBoxCtrlModifierMove.TabIndex = 12;
            this.checkBoxCtrlModifierMove.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxCtrlModifierMove.UseVisualStyleBackColor = true;
            // 
            // labelMoveToDesktopModifiers
            // 
            this.labelMoveToDesktopModifiers.AutoSize = true;
            this.labelMoveToDesktopModifiers.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelMoveToDesktopModifiers.Location = new System.Drawing.Point(16, 79);
            this.labelMoveToDesktopModifiers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoveToDesktopModifiers.Name = "labelMoveToDesktopModifiers";
            this.labelMoveToDesktopModifiers.Size = new System.Drawing.Size(244, 20);
            this.labelMoveToDesktopModifiers.TabIndex = 11;
            this.labelMoveToDesktopModifiers.Text = "Move To Desktop Modifiers:";
            this.toolTipSettingsDialog.SetToolTip(this.labelMoveToDesktopModifiers, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            // 
            // checkBoxActivateWebBrowser
            // 
            this.checkBoxActivateWebBrowser.AutoSize = true;
            this.checkBoxActivateWebBrowser.Enabled = false;
            this.checkBoxActivateWebBrowser.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxActivateWebBrowser.Location = new System.Drawing.Point(20, 206);
            this.checkBoxActivateWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActivateWebBrowser.Name = "checkBoxActivateWebBrowser";
            this.checkBoxActivateWebBrowser.Size = new System.Drawing.Size(260, 24);
            this.checkBoxActivateWebBrowser.TabIndex = 29;
            this.checkBoxActivateWebBrowser.Text = "Default Browser Activation";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxActivateWebBrowser, "On desktop switch, last active default browser window on that desktop is activate" +
        "d before active window so that links open in current desktop");
            this.checkBoxActivateWebBrowser.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinModifierSticky
            // 
            this.checkBoxWinModifierSticky.AutoSize = true;
            this.checkBoxWinModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierSticky.Location = new System.Drawing.Point(308, 174);
            this.checkBoxWinModifierSticky.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWinModifierSticky.Name = "checkBoxWinModifierSticky";
            this.checkBoxWinModifierSticky.Size = new System.Drawing.Size(64, 24);
            this.checkBoxWinModifierSticky.TabIndex = 25;
            this.checkBoxWinModifierSticky.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxWinModifierSticky.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierSticky
            // 
            this.checkBoxAltModifierSticky.AutoSize = true;
            this.checkBoxAltModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierSticky.Location = new System.Drawing.Point(383, 174);
            this.checkBoxAltModifierSticky.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAltModifierSticky.Name = "checkBoxAltModifierSticky";
            this.checkBoxAltModifierSticky.Size = new System.Drawing.Size(55, 24);
            this.checkBoxAltModifierSticky.TabIndex = 26;
            this.checkBoxAltModifierSticky.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxAltModifierSticky.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierSticky
            // 
            this.checkBoxShiftModifierSticky.AutoSize = true;
            this.checkBoxShiftModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierSticky.Location = new System.Drawing.Point(452, 174);
            this.checkBoxShiftModifierSticky.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShiftModifierSticky.Name = "checkBoxShiftModifierSticky";
            this.checkBoxShiftModifierSticky.Size = new System.Drawing.Size(72, 24);
            this.checkBoxShiftModifierSticky.TabIndex = 27;
            this.checkBoxShiftModifierSticky.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxShiftModifierSticky.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrlModifierSticky
            // 
            this.checkBoxCtrlModifierSticky.AutoSize = true;
            this.checkBoxCtrlModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierSticky.Location = new System.Drawing.Point(233, 174);
            this.checkBoxCtrlModifierSticky.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCtrlModifierSticky.Name = "checkBoxCtrlModifierSticky";
            this.checkBoxCtrlModifierSticky.Size = new System.Drawing.Size(62, 24);
            this.checkBoxCtrlModifierSticky.TabIndex = 24;
            this.checkBoxCtrlModifierSticky.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxCtrlModifierSticky.UseVisualStyleBackColor = true;
            // 
            // labelToggleSticky
            // 
            this.labelToggleSticky.AutoSize = true;
            this.labelToggleSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelToggleSticky.Location = new System.Drawing.Point(16, 175);
            this.labelToggleSticky.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToggleSticky.Name = "labelToggleSticky";
            this.labelToggleSticky.Size = new System.Drawing.Size(205, 20);
            this.labelToggleSticky.TabIndex = 23;
            this.labelToggleSticky.Text = "Toggle Sticky Window:";
            this.toolTipSettingsDialog.SetToolTip(this.labelToggleSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            // 
            // checkBoxWinModifierAlwaysOnTop
            // 
            this.checkBoxWinModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxWinModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierAlwaysOnTop.Location = new System.Drawing.Point(308, 137);
            this.checkBoxWinModifierAlwaysOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWinModifierAlwaysOnTop.Name = "checkBoxWinModifierAlwaysOnTop";
            this.checkBoxWinModifierAlwaysOnTop.Size = new System.Drawing.Size(64, 24);
            this.checkBoxWinModifierAlwaysOnTop.TabIndex = 19;
            this.checkBoxWinModifierAlwaysOnTop.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxWinModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierAlwaysOnTop
            // 
            this.checkBoxAltModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxAltModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierAlwaysOnTop.Location = new System.Drawing.Point(383, 137);
            this.checkBoxAltModifierAlwaysOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAltModifierAlwaysOnTop.Name = "checkBoxAltModifierAlwaysOnTop";
            this.checkBoxAltModifierAlwaysOnTop.Size = new System.Drawing.Size(55, 24);
            this.checkBoxAltModifierAlwaysOnTop.TabIndex = 20;
            this.checkBoxAltModifierAlwaysOnTop.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxAltModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierAlwaysOnTop
            // 
            this.checkBoxShiftModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxShiftModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierAlwaysOnTop.Location = new System.Drawing.Point(452, 137);
            this.checkBoxShiftModifierAlwaysOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShiftModifierAlwaysOnTop.Name = "checkBoxShiftModifierAlwaysOnTop";
            this.checkBoxShiftModifierAlwaysOnTop.Size = new System.Drawing.Size(72, 24);
            this.checkBoxShiftModifierAlwaysOnTop.TabIndex = 21;
            this.checkBoxShiftModifierAlwaysOnTop.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxShiftModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrlModifierAlwaysOnTop
            // 
            this.checkBoxCtrlModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxCtrlModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierAlwaysOnTop.Location = new System.Drawing.Point(233, 137);
            this.checkBoxCtrlModifierAlwaysOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCtrlModifierAlwaysOnTop.Name = "checkBoxCtrlModifierAlwaysOnTop";
            this.checkBoxCtrlModifierAlwaysOnTop.Size = new System.Drawing.Size(62, 24);
            this.checkBoxCtrlModifierAlwaysOnTop.TabIndex = 18;
            this.checkBoxCtrlModifierAlwaysOnTop.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxCtrlModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // labelToggleAkwaysOnTop
            // 
            this.labelToggleAkwaysOnTop.AutoSize = true;
            this.labelToggleAkwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelToggleAkwaysOnTop.Location = new System.Drawing.Point(16, 138);
            this.labelToggleAkwaysOnTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToggleAkwaysOnTop.Name = "labelToggleAkwaysOnTop";
            this.labelToggleAkwaysOnTop.Size = new System.Drawing.Size(203, 20);
            this.labelToggleAkwaysOnTop.TabIndex = 17;
            this.labelToggleAkwaysOnTop.Text = "Toggle Always On Top:";
            this.toolTipSettingsDialog.SetToolTip(this.labelToggleAkwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Size Ratio:";
            this.toolTipSettingsDialog.SetToolTip(this.label1, "The ratio to use to determine the window size relative to the screen size");
            // 
            // prevSizeRatio
            // 
            this.prevSizeRatio.Location = new System.Drawing.Point(124, 28);
            this.prevSizeRatio.Margin = new System.Windows.Forms.Padding(4);
            this.prevSizeRatio.Name = "prevSizeRatio";
            this.prevSizeRatio.Size = new System.Drawing.Size(64, 22);
            this.prevSizeRatio.TabIndex = 31;
            this.toolTipSettingsDialog.SetToolTip(this.prevSizeRatio, "Ratio of preview window to size of screen");
            // 
            // prevPosOff
            // 
            this.prevPosOff.Location = new System.Drawing.Point(154, 57);
            this.prevPosOff.Margin = new System.Windows.Forms.Padding(4);
            this.prevPosOff.Name = "prevPosOff";
            this.prevPosOff.Size = new System.Drawing.Size(64, 22);
            this.prevPosOff.TabIndex = 32;
            this.toolTipSettingsDialog.SetToolTip(this.prevPosOff, "Ratio of preview window to size of screen");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Position Offset";
            this.toolTipSettingsDialog.SetToolTip(this.label2, "How far left of the screen will the window be positioned");
            // 
            // comboBoxKeySticky
            // 
            this.comboBoxKeySticky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxKeySticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxKeySticky.FormattingEnabled = true;
            this.comboBoxKeySticky.Location = new System.Drawing.Point(536, 171);
            this.comboBoxKeySticky.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKeySticky.Name = "comboBoxKeySticky";
            this.comboBoxKeySticky.Size = new System.Drawing.Size(209, 29);
            this.comboBoxKeySticky.TabIndex = 28;
            this.comboBoxKeySticky.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxKeySticky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBoxAlwaysOnTopKey
            // 
            this.comboBoxAlwaysOnTopKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxAlwaysOnTopKey.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxAlwaysOnTopKey.FormattingEnabled = true;
            this.comboBoxAlwaysOnTopKey.Location = new System.Drawing.Point(536, 134);
            this.comboBoxAlwaysOnTopKey.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAlwaysOnTopKey.Name = "comboBoxAlwaysOnTopKey";
            this.comboBoxAlwaysOnTopKey.Size = new System.Drawing.Size(209, 29);
            this.comboBoxAlwaysOnTopKey.TabIndex = 22;
            this.comboBoxAlwaysOnTopKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxAlwaysOnTopKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prevCloseDelay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.prevHoverChk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.prevPosOff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prevSizeRatio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 100);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview Window";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label3.Location = new System.Drawing.Point(270, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Show On Hover";
            this.toolTipSettingsDialog.SetToolTip(this.label3, "Whether to show on hover or click");
            // 
            // prevHoverChk
            // 
            this.prevHoverChk.AutoSize = true;
            this.prevHoverChk.Location = new System.Drawing.Point(249, 30);
            this.prevHoverChk.Name = "prevHoverChk";
            this.prevHoverChk.Size = new System.Drawing.Size(18, 17);
            this.prevHoverChk.TabIndex = 35;
            this.prevHoverChk.UseVisualStyleBackColor = true;
            // 
            // prevCloseDelay
            // 
            this.prevCloseDelay.Location = new System.Drawing.Point(362, 58);
            this.prevCloseDelay.Margin = new System.Windows.Forms.Padding(4);
            this.prevCloseDelay.Name = "prevCloseDelay";
            this.prevCloseDelay.Size = new System.Drawing.Size(64, 22);
            this.prevCloseDelay.TabIndex = 36;
            this.toolTipSettingsDialog.SetToolTip(this.prevCloseDelay, "Ratio of preview window to size of screen");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label4.Location = new System.Drawing.Point(245, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Close Delay";
            this.toolTipSettingsDialog.SetToolTip(this.label4, "How long in seconds that the preview window will show");
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxWinModifierAlwaysOnTop);
            this.Controls.Add(this.checkBoxAltModifierAlwaysOnTop);
            this.Controls.Add(this.checkBoxShiftModifierAlwaysOnTop);
            this.Controls.Add(this.checkBoxCtrlModifierAlwaysOnTop);
            this.Controls.Add(this.labelToggleAkwaysOnTop);
            this.Controls.Add(this.comboBoxAlwaysOnTopKey);
            this.Controls.Add(this.checkBoxWinModifierSticky);
            this.Controls.Add(this.checkBoxAltModifierSticky);
            this.Controls.Add(this.checkBoxShiftModifierSticky);
            this.Controls.Add(this.checkBoxCtrlModifierSticky);
            this.Controls.Add(this.labelToggleSticky);
            this.Controls.Add(this.comboBoxKeySticky);
            this.Controls.Add(this.checkBoxActivateWebBrowser);
            this.Controls.Add(this.checkBoxWinModifierMove);
            this.Controls.Add(this.checkBoxAltModifierMove);
            this.Controls.Add(this.checkBoxShiftModifierMove);
            this.Controls.Add(this.checkBoxCtrlModifierMove);
            this.Controls.Add(this.labelMoveToDesktopModifiers);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.checkBoxFKeys);
            this.Controls.Add(this.checkBoxWinModifierSwitch);
            this.Controls.Add(this.checkBoxAltModifierSwitch);
            this.Controls.Add(this.checkBoxShiftModifierSwitch);
            this.Controls.Add(this.checkBoxCtrlModifierSwitch);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.labelKeyModifiers);
            this.Controls.Add(this.checkBoxWrapAround);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelRows);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsDialog";
            this.Text = "Virtual Desktop Grid Switcher Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.CheckBox checkBoxWrapAround;
        private System.Windows.Forms.Label labelKeyModifiers;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxAltModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxWinModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxFKeys;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxWinModifierMove;
        private System.Windows.Forms.CheckBox checkBoxAltModifierMove;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierMove;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierMove;
        private System.Windows.Forms.Label labelMoveToDesktopModifiers;
        private System.Windows.Forms.CheckBox checkBoxActivateWebBrowser;
        private System.Windows.Forms.ToolTip toolTipSettingsDialog;
        private System.Windows.Forms.ComboBox comboBoxKeySticky;
        private System.Windows.Forms.CheckBox checkBoxWinModifierSticky;
        private System.Windows.Forms.CheckBox checkBoxAltModifierSticky;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierSticky;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierSticky;
        private System.Windows.Forms.Label labelToggleSticky;
        private System.Windows.Forms.CheckBox checkBoxWinModifierAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxAltModifierAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierAlwaysOnTop;
        private System.Windows.Forms.Label labelToggleAkwaysOnTop;
        private System.Windows.Forms.ComboBox comboBoxAlwaysOnTopKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox prevPosOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prevSizeRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox prevHoverChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prevCloseDelay;
        private System.Windows.Forms.Label label4;
    }
}