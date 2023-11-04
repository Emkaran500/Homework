namespace EB_DZ_45.ProfileData;

using EB_DZ_45.ProfileData.Mementos;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

public class Profile : INotifyPropertyChanged
{
    private static Profile profile;

    public static Profile Instance
    {
        get
        {
            if (profile == null)
            {
                profile = new Profile();
            }
            return profile;
        }
    }

    private Profile() { }

    private string? name;
    public string? Name
    {
        get => this.name;
        set
        {
            this.ChangeProperty(this.Name, value);
            this.name = value;
            this.OnPropertyChanged();
        }
    }

    private string? surname;
    public string? Surname
    {
        get => this.surname;
        set
        {
            this.ChangeProperty(this.Surname, value);
            this.surname = value;
            this.OnPropertyChanged();
        }
    }

    private string? description;
    public string? Description
    {
        get => this.description;
        set
        {
            this.ChangeProperty(this.Description, value);
            this.description = value;
            this.OnPropertyChanged();
        }
    }

    private BitmapImage? avatar;
    public BitmapImage? Avatar
    {
        get => this.avatar;
        set
        {
            this.ChangeProperty(this.Avatar?.ToString(), value?.ToString());
            this.avatar = value;
            this.OnPropertyChanged();
        }
    }
    private string? changedProperty;
    public string? ChangedProperty
    {
        get => this.changedProperty;
        set
        {
            this.changedProperty = value;
            this.OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string name = null)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void ChangeProperty(string oldProperty, string newProperty)
    {
        this.ChangedProperty = oldProperty + " => " + newProperty;
    }

    public ProfileMemento Save()
    {
        var memento = new ProfileMemento();
        memento.Name = this.Name;
        memento.Surname = this.Surname;
        memento.Description = this.Description;
        memento.Avatar = this.Avatar;
        memento.ChangedProperty = this.ChangedProperty;

        return memento;
    }

    public void Restore(ProfileMemento memento)
    {
        this.Name = memento.Name;
        this.Surname = memento.Surname;
        this.Description = memento.Description;
        this.Avatar = memento.Avatar;
    }
}
