using Gtk;

namespace NexOS.Welcome.Pages;

public class AppsPage : Box
{
    public AppsPage() : base(Orientation.Vertical, 12)
    {
        SetMarginAll(24);

        var title = Gtk.Label.New("التطبيقات الموصى بها");
        title.AddCssClass("title-1");

        var desc = Gtk.Label.New("اختر التطبيقات التي ترغب في تثبيتها على نظامك.");
        desc.Wrap = true;
        desc.Xalign = 0f;

        Append(title);
        Append(desc);
    }
}
