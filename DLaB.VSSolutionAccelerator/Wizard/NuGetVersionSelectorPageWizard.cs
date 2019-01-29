﻿using System.Windows.Forms;

namespace DLaB.VSSolutionAccelerator.Wizard
{
    public partial class NuGetVersionSelectorPage : IWizardPage
    {
        public UserControl Content => this;
        public bool IsBusy => false;

        public bool PageValid => PackageSelector.SelectedIndex > -1;

        public string ValidationMessage => "Please enter or select a value!";

        public void Cancel()
        {
        }

        public object Save()
        {
            return (NuGetPackage) PackageSelector.SelectedItem;
        }

        void IWizardPage.Load()
        {
            // Called when the Page is loaded in the wizard.
            // Helpful if additional logic is required before loading
        }
    }
}
