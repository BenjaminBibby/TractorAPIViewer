using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TractorAPIViewer.Models.Tractor;

namespace TractorAPIViewer.Utils
{
    public static class TractorUtils
    {
        // Tractor
        public static bool HasAllWheelDrive(this Tractor tractor)
            => !string.IsNullOrEmpty(tractor.AllWheelDrive) && tractor.AllWheelDrive == "1";

        public static bool HasTurbo(this Tractor tractor)
            => !string.IsNullOrEmpty(tractor.Engine.HasTurbo) && tractor.Engine.HasTurbo == "1";

        public static bool HasIntercooler(this Tractor tractor)
            => !string.IsNullOrEmpty(tractor.Engine.HasIntercooler) && tractor.Engine.HasIntercooler == "1";

        public static bool HasCompressor(this Tractor tractor)
            => !string.IsNullOrEmpty(tractor.Engine.HasCompressor) && tractor.Engine.HasCompressor == "1";

        // Engine
        public static bool HasTurbo(this Engine engine)
            => !string.IsNullOrEmpty(engine.HasTurbo) && engine.HasTurbo == "1";

        public static bool HasIntercooler(this Engine engine)
            => !string.IsNullOrEmpty(engine.HasIntercooler) && engine.HasIntercooler == "1";

        public static bool HasCompressor(this Engine engine)
            => !string.IsNullOrEmpty(engine.HasCompressor) && engine.HasCompressor == "1";
    }
}