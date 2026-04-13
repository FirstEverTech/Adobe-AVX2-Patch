using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.Windows.AppLifecycle;
using System;
using System.Threading;

namespace AdobeAVX2Patch
{
    public class CustomProgram
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Wymagane dla trybu unpackaged
            Microsoft.Windows.ApplicationModel.DynamicDependency.Bootstrap.Initialize(
                0x00010007); // Windows App SDK 1.7

            try
            {
                Application.Start((p) =>
                {
                    var context = new DispatcherQueueSynchronizationContext(
                        DispatcherQueue.GetForCurrentThread());
                    SynchronizationContext.SetSynchronizationContext(context);
                    new App();
                });
            }
            finally
            {
                Microsoft.Windows.ApplicationModel.DynamicDependency.Bootstrap.Shutdown();
            }
        }
    }
}