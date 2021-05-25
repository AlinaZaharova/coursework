namespace WMPLib
{
    internal class WindowsMediaPlayer
    {
        public _WMPOCXEvents_PlayStateChangeEventHandler PlayStateChange { get; internal set; }
        public _WMPOCXEvents_MediaErrorEventHandler MediaError { get; internal set; }
    }
}