using Microsoft.Practices.Unity;

namespace TFLDataReader.Unity
{
    internal interface IDependencyRegister
    {
        void Register(UnityContainer container);
    }
}