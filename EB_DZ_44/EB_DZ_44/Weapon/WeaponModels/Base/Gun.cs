using System.ComponentModel;

namespace EB_DZ_44.Weapon.WeaponModels.Base;


public abstract class Gun : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected string? weaponName;
    public virtual string? WeaponName
    {
        get => this.weaponName;
        set
        {
            this.weaponName = value;

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponName)));
        }
    }

    protected int weaponDamage;
    public virtual int WeaponDamage
    {
        get => this.weaponDamage;
        set
        {
            this.weaponDamage = value;
            this.WeaponDamageInfo = this.WeaponDamage.ToString();

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponDamage)));
        }
    }

    protected string? weaponDamageInfo;
    public virtual string? WeaponDamageInfo
    {
        get => this.weaponDamageInfo;
        set
        {
            this.weaponDamageInfo = value;

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponDamageInfo)));
        }
    }


    protected int weaponAccuracy;
    public virtual int WeaponAccuracy
    {
        get => this.weaponAccuracy;
        set
        {
            this.weaponAccuracy = value;
            this.WeaponAccuracyInfo = this.WeaponAccuracy.ToString();

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponAccuracy)));
        }
    }
    protected string? weaponAccuracyInfo;
    public virtual string? WeaponAccuracyInfo
    {
        get => this.weaponAccuracyInfo;
        set
        {
            this.weaponAccuracyInfo = value;

            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(WeaponAccuracyInfo)));
        }
    }

}
