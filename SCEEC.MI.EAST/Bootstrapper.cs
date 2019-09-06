using System;
using Stylet;
using StyletIoC;
using SCEEC.MI.EAST.Pages;

namespace SCEEC.MI.EAST
{
    public class Bootstrapper : Bootstrapper<ViewModels.MainViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here
        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }

       
    }
}
