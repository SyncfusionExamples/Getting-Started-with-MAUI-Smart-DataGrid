using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.SmartComponents.Hosting;

namespace SmartDataGridSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureSyncfusionAIServices()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            Uri azureEndPoint = new Uri("https://testingopen.openai.azure.com/");
            string deploymentName = "gpt-4.1";
            string key = "hLGD4wgBAVsB4sWMom6ijN7j6JpEcV4Gw1nFWfxLpOlx5NpfpX7JJQQJ99BKACmepeSXJ3w3AAABACOGLIKd";

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
