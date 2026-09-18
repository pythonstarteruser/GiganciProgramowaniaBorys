using System.Windows;
using System.Windows.Forms;

namespace MiniMusicRandomizer;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ChooseFolder_Click(object sender, RoutedEventArgs e)
    {
        using var dialog = new FolderBrowserDialog();

        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            System.Windows.MessageBox.Show(
                $"Wybrany folder:\n{dialog.SelectedPath}",
                "Mini Music Randomizer");
        }
    }
}