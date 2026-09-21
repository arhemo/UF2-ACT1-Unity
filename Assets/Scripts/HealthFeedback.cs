using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthFeedback : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private TMP_Text lifeText;

    [SerializeField] private Button damageButton;
    [SerializeField] private Button healButton;
    [SerializeField] private Button killButton;
    [SerializeField] private Button reviveButton;

    private int previousHealth = -1;

    private void Start()
    {
        UpdateFeedback();
    }

    private void Update()
    {
        if (player.GetHealth() != previousHealth)
            UpdateFeedback();
    }

    private void UpdateFeedback()
    {
        int currentHealth = player.GetHealth();
        int maxHealth = player.GetMaxHealth();

        lifeText.text = "HEALTH: " + currentHealth + " / " + maxHealth;

        UpdateButtons();

        previousHealth = currentHealth;
    }

    private void UpdateButtons()
    {
        killButton.interactable = player.IsAlive();
        reviveButton.interactable = player.IsDead();

        damageButton.interactable = player.IsAlive();
        healButton.interactable = player.IsAlive();
    }
}