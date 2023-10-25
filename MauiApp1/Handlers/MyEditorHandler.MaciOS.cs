#nullable enable
using Microsoft.Maui.Handlers;
using MauiApp1.Controls;
using MauiApp1.Platforms.MaciOS;
using UIKit;

namespace MauiApp1.Handlers
{
    public partial class MyEditorHandler : ViewHandler<MyEditor, UITextView>
    {
        protected override UITextView CreatePlatformView() => new UITextView();

        protected override void ConnectHandler(UITextView platformView)
        {
            base.ConnectHandler(platformView);

            // Perform any control setup here
        }

        protected override void DisconnectHandler(UITextView platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }
    }
}