#if IOS || MACCATALYST
using PlatformView = MauiApp1.Platforms.MaciOS.MyMauiEditor;
#elif ANDROID
using PlatformView = VideoDemos.Platforms.Android.MauiVideoPlayer;
#elif WINDOWS
using PlatformView = VideoDemos.Platforms.Windows.MauiVideoPlayer;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif
using MauiApp1.Controls;
using Microsoft.Maui.Handlers;

namespace MauiApp1.Handlers;

    public partial class MyEditorHandler
    {
     public static IPropertyMapper<MyEditor, MyEditorHandler> PropertyMapper = new PropertyMapper<MyEditor, MyEditorHandler>(ViewHandler.ViewMapper)
        {
        };

        public MyEditorHandler() : base(PropertyMapper)
        {
        }
    }