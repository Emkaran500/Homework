namespace EB_DZ_44.Weapon.Decorators;

using EB_DZ_44.Weapon.Decorators.Base;
using EB_DZ_44.Weapon.WeaponModels.Base;

public class ForegripDecorator : WeaponDecorator
{
    public ForegripDecorator(Gun wrapee) : base(wrapee)
    {
        this.WeaponName = wrapee.WeaponName;
        this.WeaponDamage = 10;
        this.WeaponAccuracy = 15;
    }
}
