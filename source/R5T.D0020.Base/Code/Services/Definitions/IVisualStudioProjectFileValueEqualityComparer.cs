using System;

using R5T.D0016;
using R5T.T0002;
using R5T.T0064;


namespace R5T.D0020
{
    [ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileValueEqualityComparer : IValueEqualityComparer<IVisualStudioProjectFile>, IServiceDefinition
    {
    }
}
