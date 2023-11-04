namespace EB_DZ_44.Weapon.WeaponModels;

using EB_DZ_44.Weapon.WeaponModels.Base;

public class Rifle : Gun
{
    public Rifle()
    {
        this.WeaponName = "Rifle";
        this.WeaponDamage = 40;
        this.WeaponAccuracy = 30;
    }
}
