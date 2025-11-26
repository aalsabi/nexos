using Gtk;
using Adw;

namespace NexOS.Welcome.Windows;

public class WelcomeWindow : Adw.ApplicationWindow
{
    private readonly Stack _stack;
    private readonly ListBox _sidebar;

    public WelcomeWindow(Application app) : base(Adw.ApplicationWindow.New(app))
    {
        Title = "NexOS Welcome";
        DefaultWidth = 800;
        DefaultHeight = 600;

        var header = Adw.HeaderBar.New();
        header.SetTitleWidget(new Gtk.Label("NexOS Welcome"));
        header.SetShowEndTitleButtons(true);

        var mainBox = Gtk.Box.New(Orientation.Vertical, 0);
        mainBox.Append(header);

        _sidebar = Gtk.ListBox.New();
        _sidebar.SetSizeRequest(200, -1);
        _sidebar.AddCssClass("sidebar");

        _stack = Gtk.Stack.New();
        _stack.SetTransitionType(StackTransitionType.SlideLeftRight);
        _stack.SetTransitionDuration(300);

        CreatePages();

        _sidebar.OnRowSelected += (sender, e) =>
        {
            if (e.Row?.Name is { } name)
                _stack.SetVisibleChildName(name);
        };

        var paned = Gtk.Paned.New(Orientation.Horizontal);
        paned.StartChild = _sidebar;
        paned.EndChild = _stack;
        paned.SetPosition(220);

        mainBox.Append(paned);
        SetContent(mainBox);
    }

    private void CreatePages()
    {
        AddPage("welcome", "مرحباً", new Pages.WelcomePage());
        AddPage("updates", "التحديثات", new Pages.UpdatesPage());
        AddPage("drivers", "التعريفات", new Pages.DriversPage());
        AddPage("gaming", "الألعاب", new Pages.GamingPage());
        AddPage("apps", "التطبيقات", new Pages.AppsPage());
        AddPage("finish", "جاهز", new Pages.FinishPage());
    }

    private void AddPage(string name, string title, Widget content)
    {
        var row = Gtk.ListBoxRow.New();
        row.Name = name;
        row.Child = Gtk.Label.New(title);
        _sidebar.Append(row);

        _stack.AddNamed(content, name);
    }
}
