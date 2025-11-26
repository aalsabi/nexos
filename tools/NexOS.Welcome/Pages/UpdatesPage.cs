using Gtk;
using System.Diagnostics;
using System.Threading.Tasks;

namespace NexOS.Welcome.Pages;

public class UpdatesPage : Box
{
    private readonly Label _status;

    public UpdatesPage() : base(Orientation.Vertical, 12)
    {
        SetMarginAll(24);

        var title = Gtk.Label.New("تحديثات النظام");
        title.AddCssClass("title-1");

        _status = Gtk.Label.New("انقر على الزر للتحقق من التحديثات المتاحة");
        _status.Wrap = true;
        _status.Xalign = 0f;

        var btn = Gtk.Button.NewWithLabel("التحقق من التحديثات");
        btn.OnClicked += async (s, e) => await CheckUpdatesAsync();

        Append(title);
        Append(_status);
        Append(btn);
    }

    private async Task CheckUpdatesAsync()
    {
        try
        {
            _status.SetText("جاري التحقق من التحديثات...");

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "pkexec",
                    Arguments = "apt update",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            proc.Start();
            await proc.WaitForExitAsync();

            _status.SetText("تم التحقق من التحديثات بنجاح!");
        }
        catch (System.Exception ex)
        {
            _status.SetText($"خطأ في التحقق من التحديثات: {ex.Message}");
        }
    }
}
