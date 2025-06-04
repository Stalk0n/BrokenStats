namespace BrokenStats;

internal static class MainClass
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        var selectorForm = new NetworkInterfaceSelectorForm();
        if (selectorForm.ShowDialog() == DialogResult.OK && selectorForm.SelectedDevice != null)
        {
            Application.Run(new AppForm(selectorForm.SelectedDevice));
        }
        else
        {
            MessageBox.Show("Nie wybrano interfejsu sieciowego.");
        }
    }
}