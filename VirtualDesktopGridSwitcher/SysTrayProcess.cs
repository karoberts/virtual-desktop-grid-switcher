using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VirtualDesktopGridSwitcher.Settings;

namespace VirtualDesktopGridSwitcher {
    class SysTrayProcess : IDisposable {

        private NotifyIcon notifyIcon;
        private Icon[] desktopIcons;

        private ContextMenus contextMenu;
        private Action<int> switchAction;
        private readonly SettingValues settings;

        private bool isShowingClickSwitch = false;

        public SysTrayProcess(SettingValues settings)
        {
            this.settings = settings;

            notifyIcon = new NotifyIcon
            {
                Visible = true,
                Text = "Virtual Desktop Grid Switcher"
            };

            notifyIcon.Click += NotifyIcon_Click;
            notifyIcon.MouseMove += NotifyIcon_MouseMove;

            contextMenu = new ContextMenus(settings);
            notifyIcon.ContextMenuStrip = contextMenu.MenuStrip;

            LoadIconImages();
        }

        private void NotifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (settings.PreviewWindowOnClick)
                return;

            ShowPreviewWindow();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            if (!settings.PreviewWindowOnClick)
                return;

            ShowPreviewWindow();
        }

        private void ShowPreviewWindow()
        {
            if (isShowingClickSwitch)
                return;

            isShowingClickSwitch = true;
            var clickSwitch = new ClickSwitch.ClickSwitch(switchAction, settings);
            clickSwitch.ShowDialog();
            isShowingClickSwitch = false;
        }

        public void SetClickSwitchHandler(Action<int> switchAction)
        {
            this.switchAction = switchAction;
        }

        public void Dispose() {
            notifyIcon.Dispose();
        }

        public void ShowIconForDesktop(int desktopIndex) {
            notifyIcon.Icon = desktopIcons[desktopIndex];
        }

        private void LoadIconImages() {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var iconDir = Path.Combine(baseDir, "Icons");

            var icons = new List<Icon>();
            foreach (var f in Directory.GetFiles(iconDir, "*.ico").OrderBy(f => int.Parse(Path.GetFileNameWithoutExtension(f)))) {
                icons.Add(new Icon(f));
            }

            desktopIcons = icons.ToArray();
        }

    }
}
