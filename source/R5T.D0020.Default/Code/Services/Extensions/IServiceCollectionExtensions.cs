using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0001;

using R5T.Dacia;


namespace R5T.D0020.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileValueEqualityComparer"/> implementation of <see cref="IVisualStudioProjectFileValueEqualityComparer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileValueEqualityComparer(this IServiceCollection services,
            IServiceAction<INowUtcProvider> nowUtcProviderAction)
        {
            services
                .AddSingleton<IVisualStudioProjectFileValueEqualityComparer, VisualStudioProjectFileValueEqualityComparer>()
                .Run(nowUtcProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileValueEqualityComparer"/> implementation of <see cref="IVisualStudioProjectFileValueEqualityComparer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioProjectFileValueEqualityComparer> AddVisualStudioProjectFileValueEqualityComparerAction(this IServiceCollection services,
            IServiceAction<INowUtcProvider> nowUtcProviderAction)
        {
            var serviceAction = ServiceAction<IVisualStudioProjectFileValueEqualityComparer>.New(() => services.AddVisualStudioProjectFileValueEqualityComparer(
                nowUtcProviderAction));

            return serviceAction;
        }
    }
}
