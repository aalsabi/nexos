using Gtk;

namespace NexOS.Welcome.Pages;

public class GamingPage : Box
{
    public GamingPage() : base(Orientation.Vertical, 12)
    {
        SetMarginAll(24);

        var title = Gtk.Label.New("إعدادات الألعاب");
        title.AddCssClass("title-1");

        var desc = Gtk.Label.New("قم بتثبيت أدوات الألعاب مثل Steam و Proton و Wine لتشغيل الألعاب على NexOS.");
        desc.Wrap = true;
        desc.Xalign = 0f;

        Append(title);
        Append(desc);
    }
}
