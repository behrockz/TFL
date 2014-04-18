using Microsoft.Practices.Unity;

namespace TFLDataReader.Unity
{
    internal interface IGenericDependencyRegister<out T>
    {
        void Register(UnityContainer container);
    }
}