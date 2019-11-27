using FinalDP_JoseOcampo_JuanOchoa.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace FinalDP_JoseOcampo_JuanOchoa.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<QuadraticFunctionViewModel>();
        }
    }
}
