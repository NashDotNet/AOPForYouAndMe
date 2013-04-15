using AOPForYouAndMe.Part1.Scattered.Models.Caching;
using AOPForYouAndMe.Part1.Scattered.Models.Services;
using Castle.DynamicProxy;
using StructureMap;
namespace AOPForYouAndMe.Part1.Scattered {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
//                            x.For<IReportService>().Use<ReportService>()
//                                .EnrichWith(i => new ReportCacheDecorator(i));

//                            var proxyGenerator = new ProxyGenerator();
//                            x.For<IReportService>().Use<ReportService>()
//                                .EnrichWith(i => proxyGenerator.CreateInterfaceProxyWithTargetInterface<IReportService>(i, new CacheInterceptor()));
                        });
            return ObjectFactory.Container;
        }
    }
}