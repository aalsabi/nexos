using Gtk;

namespace NexOS.Welcome.Pages;

public class WelcomePage : Box
{
    public WelcomePage() : base(Orientation.Vertical, 12)
    {
        SetMarginStart(24);
        SetMarginEnd(24);
        SetMarginTop(24);
        SetMarginBottom(24);

        var title = Gtk.Label.New("مرحباً بك في NexOS");
        title.AddCssClass("title-1");

        var desc = Gtk.Label.New("شكراً لاختيارك NexOS. سيساعدك هذا البرنامج في إعداد نظامك بسهولة.");
        desc.Wrap = true;
        desc.Xalign = 0f;

        var next = Gtk.Button.NewWithLabel("التالي");
        next.AddCssClass("suggested-action");

        Append(title);
        Append(desc);
        Append(next);
    }
}
