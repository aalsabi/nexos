using Gtk;

namespace NexOS.Welcome.Pages;

public class DriversPage : Box
{
    public DriversPage() : base(Orientation.Vertical, 12)
    {
        SetMarginAll(24);

        var title = Gtk.Label.New("إدارة التعريفات");
        title.AddCssClass("title-1");

        var desc = Gtk.Label.New("قم بتثبيت التعريفات المناسبة لجهازك لتحسين الأداء والتوافق.");
        desc.Wrap = true;
        desc.Xalign = 0f;

        Append(title);
        Append(desc);
    }
}
