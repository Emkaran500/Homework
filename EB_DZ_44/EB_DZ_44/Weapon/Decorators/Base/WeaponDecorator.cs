namespace EB_DZ_44.Weapon.Decorators.Base;

using EB_DZ_44.Weapon.WeaponModels.Base;
using System.ComponentModel;

public abstract class WeaponDecorator : Gun, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected Gun Wrapee { get; set; }

    public override string? WeaponName
    {
        get => this.weaponName;
        set
        {
            this.weaponName = value;

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponName)));
        }
    }

    public override int WeaponDamage
    {
        get => this.Wrapee.WeaponDamage + this.weaponDamage;
        set
        {
            this.weaponDamage = value;
            this.WeaponDamageInfo = this.WeaponDamage.ToString();

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponDamage)));
        }
    }
    public override string? WeaponDamageInfo
    {
        get => this.weaponDamageInfo;
        set
        {
            this.weaponDamageInfo = value;

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponDamageInfo)));
        }
    }

    public override int WeaponAccuracy
    {
        get => this.Wrapee.WeaponAccuracy + this.weaponAccuracy;
        set
        {
            this.weaponAccuracy = value;
            this.WeaponAccuracyInfo = this.WeaponAccuracy.ToString();

            if (this.PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponAccuracy)));
        }
    }
    public override string? WeaponAccuracyInfo
    {
        get => this.weaponAccuracyInfo;
        set
        {
            this.weaponAccuracyInfo = value;

            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(WeaponAccuracyInfo)));
        }
    }

    public WeaponDecorator(Gun wrapee)
    {
        this.Wrapee = wrapee;
    }
}
