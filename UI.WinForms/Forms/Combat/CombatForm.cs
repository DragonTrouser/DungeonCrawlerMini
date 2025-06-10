using Characters;
using Game;
using System.Numerics;
using UI.WinForms.Forms.Combat;

namespace UI.WinForms.Forms;

public partial class CombatForm : Form
{
    private readonly GameState _state;
    private readonly Character _enemy;

    public CombatForm(GameState state, Character enemy)
    {
        InitializeComponent();
        _state = state;
        _enemy = enemy;
        FormClosing += delegate (object? sender, FormClosingEventArgs e)
        {
            if (_enemy.IsConscious) e.Cancel = true;
        };
    }

    private void UpdateHealthBars()
    {
        var player = _state.Player!;
        ProgressBarEnemyHealth.Value = 100 * _enemy.Health / _enemy.MaxHealth;
        ProgressBarPlayerHealth.Value = 100 * player.Health / player.MaxHealth;
    }

    private void Reload()
    {
        var player = _state.Player!;

        TextBoxEnemyName.Text = _enemy.Name;
        TextBoxPlayerName.Text = player.Name;

        UpdateHealthBars();

        TextBoxEnemyAC.Text = $"{_enemy.ArmorClass}";
        TextBoxPlayerAC.Text = $"{player.ArmorClass}";

        if (_state.Player!.IsConscious)
        {
            ButtonAttack.Enabled = true;
            ButtonItem.Enabled = true;
        }
        else
        {
            ButtonAttack.Enabled = false;
            ButtonItem.Enabled = false;
        }

        if (!_enemy.IsConscious || !_state.Player!.IsConscious)
        {
            ButtonEndTurn.Text = "End Combat";
        }
    }

    private void CombatForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void ButtonAttack_Click(object sender, EventArgs e)
    {
        var form = new SelectAttackForm(_state.Player!, _enemy);
        ButtonAttack.Enabled = false;
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            UpdateHealthBars();
        };
        Hide();
    }

    private void ButtonItem_Click(object sender, EventArgs e)
    {
        var form = new SelectItemForm(_state.Player!);
        ButtonItem.Enabled = false;
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            UpdateHealthBars();
        };
        Hide();
    }

    private void ButtonEndTurn_Click(object sender, EventArgs e)
    {
        if (_enemy.IsConscious && _state.Player!.IsConscious)
        {
            var random = new Random();
            if (_enemy.Attacks.Count > 0)
            {
                int index = random.Next(_enemy.Attacks.Count);
                var attack = _enemy.Attacks[index];
                _enemy.TryAttack(attack, _state.Player!);
            }
            Reload();
        }
        else
        {
            if (_state.Player!.IsConscious)
            {
                _state.Player!.GrantExperience(_enemy.Experience / 10);
                foreach (var item in _enemy.Inventory) _state.Player!.TryPickUp(item);
            }
            Close();
        }
    }
}
