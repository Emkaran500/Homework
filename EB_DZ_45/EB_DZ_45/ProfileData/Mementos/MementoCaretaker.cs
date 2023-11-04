namespace EB_DZ_45.ProfileData.Mementos;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class MementoCaretaker
{
    public ObservableCollection<ProfileMemento> Mementos { get; set; } = new ObservableCollection<ProfileMemento>();
    public int currentMemento;

    public Profile originator { get; set; } = Profile.Instance;

    private static MementoCaretaker caretaker;
    public static MementoCaretaker Instance
    {
        get
        {
            if (caretaker == null)
            {
                caretaker = new MementoCaretaker();
            }
            return caretaker;
        }
    }

    private MementoCaretaker() { }

    public void Save()
    {
        if (originator.Name == null)
        {
            if (originator.Surname == null)
            {
                if (originator.Description == null)
                {
                    if (originator.Avatar == null)
                        return;
                }
            }
        }

        var memento = this.originator.Save();
        
        foreach (var mem in Mementos)
        {
            if (mem.Name == memento.Name)
            {
                if (mem.Surname == memento.Surname)
                {
                    if (mem.Description == memento.Description)
                    {
                        if (mem.Avatar == memento.Avatar)
                            return;
                    }
                }
            }
        }

        this.Mementos.Add((ProfileMemento)memento);
        this.currentMemento = this.Mementos.Count - 1;
    }

    public void Load(int index)
    {
        if (this.Mementos == null)
            return;

        this.currentMemento = index;
        var currentMemento = this.Mementos[index];

        if (currentMemento == null)
            return;

        this.originator.Restore(currentMemento);
    }
}
