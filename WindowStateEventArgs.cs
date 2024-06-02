using System.Windows;

namespace mdilib
{
    public delegate void WindowStateEventHandler(object sender, WindowStateEventArgs e);

    public class WindowStateEventArgs : EventArgs
    {
        public WindowState State { get; set; } = default;

        public WindowStateEventArgs(WindowState state)
        {
            State = state;
        }
    }
}
