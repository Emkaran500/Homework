namespace EB_DZ_44.Weapon.Decorators;

using EB_DZ_44.Weapon.Decorators.Base;
using EB_DZ_44.Weapon.WeaponModels.Base;

public class SilencerDecorator : WeaponDecorator
{
    public SilencerDecorator(Gun wrapee) : base(wrapee)
    {
        this.WeaponName = wrapee.WeaponName;
        this.WeaponDamage = -10;
        this.WeaponAccuracy = 10;
    }
}
