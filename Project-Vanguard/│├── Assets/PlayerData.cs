namespace ProjectVanguard.Player
{
    public class PlayerData
    {
        public string PlayerName { get; set; } = "Player";

        public int Health { get; private set; } = 100;

        public int Armor { get; private set; } = 50;

        public int CurrentAmmo { get; private set; } = 30;

        public int MaxAmmo { get; } = 30;

        public bool IsAlive => Health > 0;

        public void TakeDamage(int damage)
        {
            if (Armor > 0)
            {
                int armorDamage = damage / 2;
                Armor -= armorDamage;
                damage -= armorDamage;

                if (Armor < 0)
                {
                    damage += -Armor;
                    Armor = 0;
                }
            }

            Health -= damage;

            if (Health < 0)
                Health = 0;
        }

        public void Heal(int amount)
        {
            Health += amount;

            if (Health > 100)
                Health = 100;
        }

        public void Reload()
        {
            CurrentAmmo = MaxAmmo;
        }

        public void Shoot()
        {
            if (CurrentAmmo > 0)
                CurrentAmmo--;
        }
    }
}