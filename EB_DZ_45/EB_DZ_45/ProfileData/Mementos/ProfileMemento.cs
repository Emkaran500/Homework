namespace EB_DZ_45.ProfileData.Mementos;

using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

public class ProfileMemento
{
    public readonly DateTime CreationDate;
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Description { get; set; }
    public BitmapImage? Avatar { get; set; }
    public string? ChangedProperty { get; set; }

    public ProfileMemento()
    {
        this.CreationDate = DateTime.Now;
    }
}
