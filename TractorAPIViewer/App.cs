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
using Ninject;
using Ninject.Modules;

namespace TractorAPIViewer
{
    public static class App
    {
        public static StandardKernel Container { get; set; }

        public static void Create(params NinjectModule[] modules)
        {
            Container = new StandardKernel(modules);
            Container.Load(new AppModule());
        }
    }
}