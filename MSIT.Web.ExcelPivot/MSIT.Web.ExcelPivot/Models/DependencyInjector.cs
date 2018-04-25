using Microsoft.Extensions.DependencyInjection;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSIT.Web.ExcelPivot
{
    public class DependencyInjector
    {
        public IServiceProvider Services { get; set; }
        public DependencyInjector()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            Services = serviceCollection.BuildServiceProvider();
        }
        public void ConfigureServices(IServiceCollection serviceCollection)
        {

            //serviceCollection.AddTransient<IBenefit, BenefitService>();
        }
    }
}