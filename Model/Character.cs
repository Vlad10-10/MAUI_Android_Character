using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HeroCreatorr.Model;

public class Character : INotifyPropertyChanged
{
    private string _name = "Geralt";
    private string _characterClass = "Witcher";
    private int _level = 10;
    private int _strength = 40;
    private int _dexterity = 80;
    private int _intelligence = 60;

    public List<string> Classes { get; } =
    [
        "Warrior",
        "Witcher",
        "Mage",
        "Thief"
    ];

    public string Name
    {
        get => _name;
        set
        {
            if (_name == value)
                return;

            _name = value;
            OnPropertyChanged();
        }
    }

    public string CharacterClass
    {
        get => _characterClass;
        set
        {
            if (_characterClass == value)
                return;

            _characterClass = value;
            OnPropertyChanged();
        }
    }

    
    public int Level
    {
        get => _level;
        set
        {
            if (_level == value)
                return;
            
            _level = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(TotalPower));
        }
    }

    
    public int Strength
    {
        get => _strength;
        set
        {
            if (_strength == value)
                return;
            
            _strength = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(TotalPower));
        }
    }

    
    public int Dexterity
    {
        get => _dexterity;
        set
        {
            if (_dexterity == value)
                return;
            
            _dexterity = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(TotalPower));
        }
    }

    
    public int Intelligence
    {
        get => _intelligence;
        set
        {
            if (_intelligence == value)
                return;
            
            _intelligence = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(TotalPower));
        }
    }

    public int TotalPower => (Strength + Dexterity + Intelligence) * Level;

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(
            this,
            new PropertyChangedEventArgs(propertyName));
    }
}