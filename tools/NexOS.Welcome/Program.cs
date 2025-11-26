using Gtk;
using Adw;
using System;
using System.Globalization;

namespace NexOS.Welcome;

public class Program
{
    private static Application _app = null!;

    public static int Main(string[] args)
    {
        Gtk.Functions.Init();
        Adw.Functions.Init();

        SetRtlSupport();

        _app = Application.New("org.nexos.welcome", Gio.ApplicationFlags.FlagsNone);
        _app.OnActivate += (sender, e) =>
        {
            var win = new Windows.WelcomeWindow(_app);
            win.Present();
        };

        return _app.RunWithSynchronizationContext(null);
    }

    private static void SetRtlSupport()
    {
        var lang = Environment.GetEnvironmentVariable("LANG")?.ToLowerInvariant();
        var isRtl = (lang?.Contains("ar") ?? false) ||
                    CultureInfo.CurrentCulture.TextInfo.IsRightToLeft;

        if (isRtl)
        {
            var settings = Gtk.Settings.GetDefault();
            if (settings is not null)
            {
                settings.SetProperty("gtk-enable-animations", new GLib.Value(true));
            }
        }
    }
}
