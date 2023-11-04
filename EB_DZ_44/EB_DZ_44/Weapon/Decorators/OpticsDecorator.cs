namespace EB_DZ_44.Weapon.Decorators;

using EB_DZ_44.Weapon.Decorators.Base;
using EB_DZ_44.Weapon.WeaponModels.Base;

public class OpticsDecorator : WeaponDecorator
{
    public OpticsDecorator(Gun wrapee) : base(wrapee)
    {
        this.WeaponName = wrapee.WeaponName;
        this.WeaponDamage = -5;
        this.WeaponAccuracy = 25;
    }
}
