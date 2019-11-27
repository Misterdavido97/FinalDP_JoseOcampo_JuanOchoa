using Android.App;
using Android.OS;
using FinalDP_JoseOcampo_JuanOchoa.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace FinalDP_JoseOcampo_JuanOchoa.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class QuadraticFunctionView : MvxActivity<QuadraticFunctionViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.QuadraticFunctionPage);
        }
    }
}