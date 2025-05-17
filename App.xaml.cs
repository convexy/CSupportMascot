using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace CSupportMascot
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private NotifyIcon _notifyIcon;
        public App()
        {
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Icon = new Icon("Resources/notify.ico");
            _notifyIcon.Visible = true;
            _notifyIcon.Text = "CSupportMascot";
            var menu = new ContextMenuStrip();
            menu.Items.Add("終了", null, (s, ev) => this.ExitApplication());
            _notifyIcon.ContextMenuStrip = menu;
        }

        private void ExitApplication()
        {
            _notifyIcon.Visible = false;
            _notifyIcon.Dispose();
            this.Shutdown();
        }
    }

}
