namespace ProjectVanguard.Weapons
{
    public class Weapon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int MagazineSize { get; set; }

        public int CurrentAmmo { get; private set; }

        public bool Automatic { get; set; }

        public Weapon(string name, int damage, int magazineSize, bool automatic)
        {
            Name = name;
            Damage = damage;
            MagazineSize = magazineSize;
            CurrentAmmo = magazineSize;
            Automatic = automatic;
        }

        public bool CanShoot()
        {
            return CurrentAmmo > 0;
        }

        public void Shoot()
        {
            if (CanShoot())
            {
                CurrentAmmo--;
            }
        }

        public void Reload()
        {
            CurrentAmmo = MagazineSize;
        }
    }
}