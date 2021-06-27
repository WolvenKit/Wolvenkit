using System.IO;
using System.Windows;
using Catel.IoC;
using Catel.Services;
using WolvenKit.Core;
using WolvenKit.Functionality.Services;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class LocateGameDateView
    {
        #region Fields

        private readonly FirstSetupWizardModel _firstSetupWizardModel;
        private readonly FirstSetupWizardViewModel _firstSetupWizardViewModel;
        private readonly ISelectDirectoryService _selectDirectoryService;
        private readonly ISettingsManager _settingsManager;

        #endregion Fields

        #region Constructors

        public LocateGameDateView()
        {
            InitializeComponent();

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _firstSetupWizardViewModel = ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>();
            _firstSetupWizardModel = ServiceLocator.Default.ResolveType<FirstSetupWizardModel>();
            _selectDirectoryService = ServiceLocator.Default.ResolveType<ISelectDirectoryService>();
        }

        #endregion Constructors

        #region Methods

        private void CP77ExecutablePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_firstSetupWizardViewModel.OpenCP77GamePathCommand.CanExecute(null))
            {
                _firstSetupWizardViewModel.OpenCP77GamePathCommand.Execute(null);
            }
            validateAllFields();
        }

        private async void DepotPathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
            {
                _settingsManager.DepotPath = result.DirectoryName;
            }
        }

        private void Field_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => validateAllFields();

        private void validateAllFields()
        {
            bool w3IsValid = true, cp77IsValid = true;
            if (_firstSetupWizardModel.CreateModForW3)
            {
                w3IsValid = w3ExeTxtb.VerifyData() && wccLiteExeTxtb.VerifyData();
            }

            if (_firstSetupWizardModel.CreateModForCP77)
            {
                cp77IsValid = cp77ExeTxtb.VerifyData();
            }

            _firstSetupWizardViewModel.AllFieldIsValid = w3IsValid && cp77IsValid;
        }

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            if (File.Exists(str) && Path.GetFileName(str).Equals(Constants.Exe))
            {
                var oodle = Path.Combine(new FileInfo(str).Directory.FullName, Constants.Oodle);
                if (!File.Exists(oodle))
                {
                    ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    ValidationText.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty,
                        $"Oodle dll was not found with the game. Please make sure you have {Constants.Oodle} next to your game executable.");
                    return HandyControl.Data.OperationResult.Failed();
                }
                ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                return HandyControl.Data.OperationResult.Success();
            }

            ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            ValidationText.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty,
                "Game exe location was not found.");
            return HandyControl.Data.OperationResult.Failed();
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str) => System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed();

        private void W3ExecutablePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_firstSetupWizardViewModel.OpenW3GamePathCommand.CanExecute(null))
            {
                _firstSetupWizardViewModel.OpenW3GamePathCommand.Execute(null);
            }
        }

        private void WccLitePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_firstSetupWizardViewModel.OpenWccPathCommand.CanExecute(null))
            {
                _firstSetupWizardViewModel.OpenWccPathCommand.Execute(null);
            }
        }

        #endregion Methods
    }
}
