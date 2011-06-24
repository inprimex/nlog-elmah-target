using Elmah;
using NLog;

namespace nlog_elmah_target
{
    [Target("ElmahTarget")]
    public sealed class ElmahTarget : TargetWithLayout
    {
        protected override void Write(LogEventInfo logEvent)
        {
            if (logEvent.Exception != null)
            {
                ErrorSignal.FromCurrentContext().Raise(logEvent.Exception);  
            }            
        }
    }
}