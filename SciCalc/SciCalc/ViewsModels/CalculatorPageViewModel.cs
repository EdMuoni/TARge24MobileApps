using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Maui.Controls.Compatibility;

namespace SciCalc.ViewsModels
{
    [INotifyPropertyChanged]
    internal partial class CalculatorPageViewModel : ObservableObject
    // :ObservableObject
    {
        [ObservableProperty]
        private string inputText = string.Empty;

        [ObservableProperty]
        private string calculatedResult = "0";

        private bool isSciOpWaiting = false;

        [RelayCommand]
        private void Reset()
        {
            CalculatedResult = "0";
            inputText = string.Empty;
            isSciOpWaiting = false;
        }

        [RelayCommand]
        private void Calculate()
        {
            if (InputText.Length == 0)
            {
                return;
            }

            if (isSciOpWaiting)
            {
                InputText += ")";
                isSciOpWaiting = false;
            }

            try
            {
                var inputString = NormalizeInputString();
                var expression = new NCalc.Expression(inputString);
                var result = expression.Evaluate();


                CalculatedResult = calculatedResult.ToString();
            }



            catch (Exception ex)
            {

                CalculatedResult = "NaN";
            }
        }

        private string NormalizeInputString()
        {
            Dictionary<string, string> _opMapper = new()
            {

            {"×", "*"},
            {"÷", "/"},
            {"SIN", "Sin"},
            {"COS", "Cos"},
            {"TAN", "Tan"},
            {"ASIN", "Asin"},
            {"ACOS", "Acos"},
            {"ATAN", "Atan"},
            {"LOG", "Log"},
            {"EXP", "Exp"},
            {"LOG", "Log10"},
            {"^", "Pow"},
            {"√", "Sqrt"},
            {"ABS", "Abs"},
            {"(", "("},
            {")", ")"},
            {"π", Math.PI.ToString()},
            {"e", Math.E.ToString()},

            };

            var reString = InputText;
            foreach (var key in _opMapper.Keys)
            {
                reString = reString.Replace(key, _opMapper[key]);
            }

            return reString;
        }

        [RelayCommand]
        private void Backspace()
        {
            if (InputText.Length > 0)
            {
                InputText = InputText.Substring(0, InputText.Length - 1);
            }

        }

        [RelayCommand]

        private void MathOperator(string op)
        {
            if (isSciOpWaiting)
            {
                InputText += ")";
                isSciOpWaiting = false;
            }
            InputText += $"{op}";
        }


        [RelayCommand]
        private void RegionOperator(string op)
        {
            if (isSciOpWaiting)
            {
                InputText += ")";
                isSciOpWaiting = false;
            }
            InputText += $"{op}";
        }

        [RelayCommand]
        private void ScientificOperator(string op)
        {

            InputText += $"{op}(";
            isSciOpWaiting = false;


        }

    }
}

