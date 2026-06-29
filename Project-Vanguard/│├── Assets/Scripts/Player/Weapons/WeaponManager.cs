using System.Collections.Generic;

namespace ProjectVanguard.Weapons
{
    public class WeaponManager
    {
        private readonly List<Weapon> weapons = new();

        public int CurrentWeaponIndex { get; private set; }

        public Weapon CurrentWeapon
        {
            get
            {
                if (weapons.Count == 0)
                    return null;

                return weapons[CurrentWeaponIndex];
            }
        }

        public void AddWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
        }

        public void NextWeapon()
        {
            if (weapons.Count == 0)
                return;

            CurrentWeaponIndex++;

            if (CurrentWeaponIndex >= weapons.Count)
                CurrentWeaponIndex = 0;
        }

        public void PreviousWeapon()
        {
            if (weapons.Count == 0)
                return;

            CurrentWeaponIndex--;

            if (CurrentWeaponIndex < 0)
                CurrentWeaponIndex = weapons.Count - 1;
        }

        public void ReloadCurrentWeapon()
        {
            CurrentWeapon?.Reload();
        }

        public void ShootCurrentWeapon()
        {
            CurrentWeapon?.Shoot();
        }
    }
}