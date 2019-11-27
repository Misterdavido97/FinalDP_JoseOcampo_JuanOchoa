using FinalDP_JoseOcampo_JuanOchoa.Core.Models;
using FinalDP_JoseOcampo_JuanOchoa.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalDP_JoseOcampo_JuanOchoa.Core.ViewModels
{
    public class QuadraticFunctionViewModel : MvxViewModel
    {
        #region Attributes

        private readonly IQuadraticFunctionService _quadraticFunction;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;
        private MvxCommand _calculateCommand;

        #endregion

        #region Constructor

        public QuadraticFunctionViewModel(IQuadraticFunctionService quadraticFunction)
        {
            _quadraticFunction = quadraticFunction;
        }

        #endregion

        #region Properties

        public double A
        {
            get => _a;
            set
            {
                _a = value;
                RaisePropertyChanged(() => A);
            }
        }

        public double B
        {
            get => _b;
            set
            {
                _b = value;
                RaisePropertyChanged(() => B);
            }
        }

        public double C
        {
            get => _c;
            set
            {
                _c = value;
                RaisePropertyChanged(() => C);
            }
        }

        public double X1
        {
            get => _x1;
            set
            {
                _x1 = value;
                RaisePropertyChanged(() => X1);
            }
        }

        public double X2
        {
            get => _x2;
            set
            {
                _x2 = value;
                RaisePropertyChanged(() => X2);
            }
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Recalculate);
                return _calculateCommand;
            }
        }

        #endregion

        #region Public Methods

        public override async Task Initialize()
        {
            await base.Initialize();

            _a = 2;
            _b = 8;
            _c = 3;
            Recalculate();
        }

        #endregion

        #region Private Methods

        private void Recalculate()
        {
            QuadraticFunctionResult result = _quadraticFunction.Calculate(A, B, C);
            X1 = result.X1;
            X2 = result.X2;
        }

        #endregion
    }
}
