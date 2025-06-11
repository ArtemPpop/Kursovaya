using Kursovaya.Utills;
using Kursovaya.View;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursovaya;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        LoadDefaultContent();
        SetupNavigation();
    }

    private void LoadDefaultContent()
    {
        // Загружаем страницу с фильмами по умолчанию
        MainContentArea.Content = new FilmsPage();
    }

    private void SetupNavigation()
    {
        
        var filmsBtn = ( Btn)FindName("FilmsButton");
        var recommendationsBtn = ( Btn)FindName("RecommendationsButton");
        var profileBtn = ( Btn)FindName("ProfileButton");
        var subscriptionBtn = ( Btn)FindName("SubscriptionButton");

        // Подписываемся на события Checked для RadioButton (так как Btn — это RadioButton)
        if (filmsBtn != null) filmsBtn.Checked += (s, e) => MainContentArea.Content = new FilmsPage();
        if (recommendationsBtn != null) recommendationsBtn.Checked += (s, e) => MainContentArea.Content = new RecommendationsPage();
        if (profileBtn != null) profileBtn.Checked += (s, e) => MainContentArea.Content = new ProfilePage();
        if (subscriptionBtn != null) subscriptionBtn.Checked += (s, e) => MainContentArea.Content = new SubscriptionPage();
    }
}

