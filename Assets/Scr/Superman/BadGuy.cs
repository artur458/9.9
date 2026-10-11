using UnityEngine;
using UnityEngine.UI;

public class BadGuy : MonoBehaviour
{
    public float health = 100f;
    public Slider healthBar;

    private void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    private void Update()
    {
        healthBar.value = health;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
