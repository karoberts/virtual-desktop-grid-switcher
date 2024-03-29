using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using VirtualDesktopGridSwitcher.Settings;
using System.Collections.Generic;

namespace VirtualDesktopGridSwitcher
{
    /// <summary>
    /// 
    /// </summary>
    class ContextMenus
    {
        public ContextMenuStrip MenuStrip { get; private set; }

        private readonly SettingValues settings;

        public ContextMenus(SettingValues settings)
        {

            this.settings = settings;

            // Add the default menu options.
            MenuStrip = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Settings
            item = new ToolStripMenuItem
            {
                Text = "Settings"
            };
            item.Click += new EventHandler(Settings_Click);
            //item.Image = Resources.Explorer;
            MenuStrip.Items.Add(item);

            // About.
            item = new ToolStripMenuItem
            {
                Text = "About"
            };
            item.Click += new EventHandler(About_Click);
            //item.Image = Resources.About;
            MenuStrip.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            MenuStrip.Items.Add(sep);

            // Exit.
            item = new ToolStripMenuItem
            {
                Text = "Exit"
            };
            item.Click += new System.EventHandler(Exit_Click);
            //item.Image = Resources.Exit;
            MenuStrip.Items.Add(item);

        }

        bool loadingDialog = false;

        private SettingsDialog settingsDialog;
        void Settings_Click(object sender, EventArgs e)
        {
            if (!loadingDialog)
            {
                loadingDialog = true;
                if (settingsDialog == null)
                {
                    settingsDialog = new SettingsDialog(settings);
                }
                settingsDialog.ShowDialog();
                loadingDialog = false;
            }
        }

        private AboutBox.AboutBox aboutBox;
        void About_Click(object sender, EventArgs e)
        {
            if (!loadingDialog)
            {
                loadingDialog = true;
                if (aboutBox == null)
                {
                    aboutBox = new AboutBox.AboutBox();
                }
                aboutBox.ShowDialog();
                loadingDialog = false;
            }
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public override bool Equals(object obj)
        {
            return obj is ContextMenus menus &&
                   EqualityComparer<SettingValues>.Default.Equals(settings, menus.settings);
        }

        public override int GetHashCode()
        {
            return settings.GetHashCode();
        }
    }
}