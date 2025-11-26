using Gtk;

namespace NexOS.Welcome.Pages;

public class FinishPage : Box
{
    public FinishPage() : base(Orientation.Vertical, 12)
    {
        SetMarginAll(24);

        var title = Gtk.Label.New("الإعداد مكتمل!");
        title.AddCssClass("title-1");

        var desc = Gtk.Label.New("تم إعداد نظام NexOS بنجاح. يمكنك الآن البدء في استخدام نظامك.");
        desc.Wrap = true;
        desc.Xalign = 0f;

        var restart = Gtk.Button.NewWithLabel("إعادة التشغيل");
        restart.AddCssClass("destructive-action");

        Append(title);
        Append(desc);
        Append(restart);
    }
}
