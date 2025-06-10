using Actions;
using Characters;

namespace Game.Generators;

public static class CharacterGenerator
{
    private static readonly Random random = new();

    private static readonly string[] EnemyNames = [
        "Gloomfang", "Skulker", "Razorclaw", "Dreadmaw", "Venomspike",
        "Ashwalker", "Blightbeast", "Frostgnarl", "Gravetide", "Snarlhorn",
        "Bloodroot", "Shiversoul", "Nightgleam", "Wretch", "Hollowfang",
        "Spiteshade", "Gnash", "Thornback", "Murkfiend", "Scalebane"
    ];

    private static string GetRandomEnemyName()
    {
        return EnemyNames[random.Next(EnemyNames.Length)];
    }

    public static Character GeneratePlayer()
    {
        var player = new Character
        {
            Name = "Player",

            Level = 1,
            Experience = 0,
            Strength = 4,
            Dexterity = 3,
            Intelligence = 2,
            Perception = 2,

            maxHealthBase = 20,
            maxHealthPerLevel = 10,

            Money = new(0, 10, 5, 2),

            Speed = 25,
            Health = 30
        };

        foreach (var attack in ActionGenerator.GenerateInnatePlayer())
        {
            player.TryAddInnate(attack);
        }
        foreach (var item in ItemGenerator.GeneratePlayerStartingItems())
        {
            player.TryPickUp(item);
        }

        return player;
    }

    public static Character GenerateEnemy()
    {
        var enemy = new Character
        {
            Name = GetRandomEnemyName(),
            Level = 1,
            Experience = random.Next(300),

            Strength = 4,
            Dexterity = 2,
            Intelligence = 2,
            Perception = 2,

            maxHealthBase = 10,
            maxHealthPerLevel = 10,

            Money = new(0, 0, 3, 0),

            Speed = 25,
            Health = 20
        };

        if (random.NextDouble() < 0.3) enemy.Weapon = ItemGenerator.GenerateWeapon();
        if (random.NextDouble() < 0.3) enemy.Armor = ItemGenerator.GenerateArmor();

        foreach (var attack in ActionGenerator.GenerateInnateEnemy()) enemy.TryAddInnate(attack);

        return enemy;
    }
}
