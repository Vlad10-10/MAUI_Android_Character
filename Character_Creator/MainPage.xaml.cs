using HeroCreatorr.Model;

namespace HeroCreatorr;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
         InitializeComponent();

         BindingContext = new Character();
    }

    private void OnRandomiseClicked(object? sender, EventArgs e)
    {
        var random = new Random();
        var character = (Character)BindingContext;
        
        character.Strength = random.Next(1, 101);
        character.Intelligence = random.Next(1, 101);
        character.Dexterity = random.Next(1, 101);
    }
}