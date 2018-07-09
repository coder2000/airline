﻿using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using Airline.ViewModels;
using Airline.Views;
using Airline.Infrastructure;

namespace Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineBootstrapper bootstrapper = new AirlineBootstrapper();
            bootstrapper.Run();
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug()
                .SetupWithoutStarting();
    }
}