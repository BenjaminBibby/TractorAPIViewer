using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ninject.Modules;
using TractorAPIViewer.Services;
using TractorAPIViewer.Services.Interfaces;
using TractorAPIViewer.Services.Mock;
using TractorAPIViewer.ViewModels;

namespace TractorAPIViewer
{
    public class AppModule : NinjectModule
    {
        public AppModule()
        {
        }

        public override void Load()
        {
            // ViewModels
            Bind<BaseViewModel>().ToSelf().InSingletonScope();
            Bind<TracorGalleryViewModel>().ToSelf().InSingletonScope();

            // Service bindings
            Bind<ITractorService>().To<TractorService>();
        }
    }
}