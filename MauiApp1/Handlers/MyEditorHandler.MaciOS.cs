#nullable enable
using Microsoft.Maui.Handlers;
using MauiApp1.Controls;
using MauiApp1.Platforms.MaciOS;

namespace MauiApp1.Handlers
{
    public partial class MyEditorHandler : ViewHandler<MyEditor, MyMauiEditor>
    {
        protected override MyMauiEditor CreatePlatformView() => new MyMauiEditor();

        protected override void ConnectHandler(MyMauiEditor platformView)
        {
            base.ConnectHandler(platformView);

            // Perform any control setup here
        }

        protected override void DisconnectHandler(MyMauiEditor platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }
    }
}