using Characters.Exceptions;
using Core;
using Core.Structs;

namespace Characters;

public class Character : ICharacter, IEquatable<Character>
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name
    {
        get;
        set
        {
            field = value ?? nameof(Character);
        }
    } = nameof(Character);
    public string? Description
    {
        get;
        set
        {
            field = value ?? nameof(Character);
        }
    } = nameof(Character);

    public int Level
    {
        get;
        set
        {
            field = Math.Max(value, 0);
        }
    }
    public int Experience
    {
        get;
        set
        {
            field = Math.Max(value, 0);
        }
    }
    public int ExperienceToNextLevel
    {
        get
        {
            return (2 * Level * Level - Level) * 100;
        }
    }
    public bool ShouldLevelUp
    {
        get
        {
            return Experience > ExperienceToNextLevel;
        }
    }

    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Perception { get; set; }

    public int maxHealthBase = 10;
    public int maxHealthPerLevel = 10;
    public int MaxHealth
    {
        get
        {
            return maxHealthBase + Level * maxHealthPerLevel;
        }
    }
    public int Health
    {
        get;
        set
        {
            field = Math.Clamp(value, 0, MaxHealth);
        }
    }
    public bool IsConscious
    {
        get
        {
            return Health > 0;
        }
    }

    protected List<IItem> _inventory = [];
    public IReadOnlyList<IItem> Inventory
    {
        get
        {
            return _inventory.AsReadOnly();
        }
    }
    public Money Money { get; set; }

    protected List<IAttack> _innateAttacks = [];
    public IReadOnlyList<IAttack> InnateAttacks
    {
        get
        {
            return _innateAttacks.AsReadOnly();
        }
    }
    public IReadOnlyList<IAttack> Attacks
    {
        get
        {
            if (Weapon is null)
            {
                return InnateAttacks;
            }
            return [.. InnateAttacks, .. Weapon.Attacks];
        }
    }
    public IWeapon? Weapon { get; set; }
    public IArmor? Armor { get; set; }
    public int ArmorClass
    {
        get
        {
            int armorClass = 10;
            if (Armor is not null)
            {
                if (Armor.DexterityCap is null)
                {
                    armorClass += Armor.ArmorClass + Dexterity;
                }
                else
                {
                    armorClass += Armor.ArmorClass + Math.Min(Dexterity, Armor?.DexterityCap ?? 0);
                }
            }
            return armorClass + Dexterity;
        }
    }
    public int Speed
    {
        get
        {
            if (IsConscious)
            {
                return field;
            }
            return 0;
        }
        set
        {
            value += Armor?.SpeedAdjustment ?? 0;
            field = Math.Max(value, 0);
        }
    }

    public event EventHandler? OnLevelUp = delegate (object? sender, EventArgs e)
    {
        if (sender is Character character)
        {
            character.Experience -= character.ExperienceToNextLevel;
            character.Level++;
        }
    };

    public override string ToString()
    {
        return $"Character named {Name}";
    }

    public bool Equals(Character? other)
    {
        return Id == other?.Id;
    }
    public static bool operator ==(Character left, Character right)
    {
        return left.Id == right.Id;
    }
    public static bool operator !=(Character left, Character right)
    {
        return left.Id != right.Id;
    }

    public void LevelUp()
    {
        OnLevelUp?.Invoke(this, EventArgs.Empty);
    }
    public void GrantExperience(int amount)
    {
        if (amount < 0)
        {
            return;
        }
        Experience += amount;
        while (ShouldLevelUp)
        {
            LevelUp();
        }
    }

    public virtual bool ShouldTakeDamage(AttackRoll? attackRoll = null)
    {
        if (attackRoll is null)
        {
            return true;
        }
        return attackRoll?.Result >= ArmorClass;
    }
    public virtual void TakeDamage(DamageRoll? damageRoll = null)
    {
        Health -= damageRoll?.Result ?? 0;
    }

    public bool Has(IItem item)
    {
        return Inventory.Contains(item);
    }
    public virtual void PickUp(IItem item)
    {
        if (Has(item))
        {
            throw new ItemAlreadyInInventoryException(this, item);
        }
        _inventory.Add(item);
    }
    public bool TryPickUp(IItem item)
    {
        try
        {
            PickUp(item);
            return true;
        }
        catch (ItemAlreadyInInventoryException)
        {
            return false;
        }
    }
    public virtual void Drop(IItem item)
    {
        if (!Has(item))
        {
            throw new ItemNotInInventoryException(this, item);
        }
        if (Weapon is not null && Weapon.Equals(item))
        {
            throw new CannotDropEquippedItemException(this, item);
        }
        if (Armor is not null && Armor.Equals(item))
        {
            throw new CannotDropEquippedItemException(this, item);
        }
        _inventory.Remove(item);
    }
    public bool TryDrop(IItem item)
    {
        try
        {
            Drop(item);
            return true;
        }
        catch (ItemNotInInventoryException)
        {
            return false;
        }
        catch (CannotDropEquippedItemException)
        {
            return false;
        }
    }
    public virtual void Equip(IItem item)
    {
        if (!Has(item))
        {
            throw new ItemNotInInventoryException(this, item);
        }
        if (item is IWeapon weapon)
        {
            Weapon = weapon;
        }
        else if (item is IArmor armor)
        {
            Armor = armor;
        }
        else
        {
            throw new CannotEquipItemException(this, item);
        }
    }
    public bool TryEquip(IItem item)
    {
        try
        {
            Equip(item);
            return true;
        }
        catch (ItemNotInInventoryException)
        {
            return false;
        }
        catch (CannotEquipItemException)
        {
            return false;
        }
    }
    public virtual void Unequip(IItem item)
    {
        if (!Has(item))
        {
            throw new ItemNotInInventoryException(this, item);
        }
        if (Weapon is not null && Weapon.Equals(item))
        {
            Weapon = null;
        }
        else if (Armor is not null && Armor.Equals(item))
        {
            Armor = null;
        }
        else
        {
            throw new CannotUnequipItemException(this, item);
        }
    }
    public bool TryUnequip(IItem item)
    {
        try
        {
            Unequip(item);
            return true;
        }
        catch (ItemNotInInventoryException)
        {
            return false;
        }
        catch (CannotUnequipItemException)
        {
            return false;
        }
    }
    public void Use(IItem item)
    {
        if (!Has(item))
        {
            throw new ItemNotInInventoryException(this, item);
        }
        if (item is not IPotion potion)
        {
            throw new ItemNotUsableException(this, item);
        }

        var missingHealth = MaxHealth - Health;
        var healAmount = Math.Min(potion.Health, missingHealth);

        Health += healAmount;
        potion.Health -= healAmount;
    }
    public bool TryUse(IItem item)
    {
        try
        {
            Use(item);
            return true;
        }
        catch (ItemNotInInventoryException)
        {
            return false;
        }
        catch (ItemNotUsableException)
        {
            return false;
        }
    }

    public bool Has(IAttack attack)
    {
        return Attacks.Contains(attack);
    }
    public bool HasInnate(IAttack attack)
    {
        return InnateAttacks.Contains(attack);
    }
    public virtual void AddInnate(IAttack attack)
    {
        if (HasInnate(attack))
        {
            throw new AttackAlreadyAvailableException(this, attack);
        }
        _innateAttacks.Add(attack);
    }
    public bool TryAddInnate(IAttack attack)
    {
        try
        {
            AddInnate(attack);
            return true;
        }
        catch (AttackAlreadyAvailableException)
        {
            return false;
        }
    }
    public void RemoveInnate(IAttack attack)
    {
        if (!HasInnate(attack))
        {
            throw new AttackNotAvailableException(this, attack);
        }
        _innateAttacks.Remove(attack);
    }
    public bool TryRemoveInnate(IAttack attack)
    {
        try
        {
            RemoveInnate(attack);
            return true;
        }
        catch (AttackNotAvailableException)
        {
            return false;
        }
    }
    public virtual void Attack(IAttack attack, params Span<ICharacter> targets)
    {
        if (!Has(attack))
        {
            throw new AttackNotAvailableException(this, attack);
        }
        if (attack.AttackRoll is AttackRoll atkRoll)
        {
            atkRoll.Base = Strength;
            attack.AttackRoll = atkRoll;
        }
        if (attack.DamageRoll is DamageRoll dmgRoll)
        {
            dmgRoll.Base = Strength;
            attack.DamageRoll = dmgRoll;
        }

        attack.Roll();
        foreach (var target in targets)
        {
            if (target.ShouldTakeDamage(attack.AttackRoll))
            {
                target.TakeDamage(attack.DamageRoll);
            }
        }
    }
    public bool TryAttack(IAttack attack, params Span<ICharacter> targets)
    {
        try
        {
            Attack(attack, targets);
            return true;
        }
        catch (AttackAlreadyAvailableException)
        {
            return false;
        }
    }
}
