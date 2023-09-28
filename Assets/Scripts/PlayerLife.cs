using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int damageImpact = 22;
    public Image healthBar;
    public float healthAmount = 100f;
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource damageSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Damage();
        }
    }

    // damage anim is not working currently

    private void Damage()
    {
        damageSoundEffect.time = 0.35f;
        damageSoundEffect.Play();
        anim.SetTrigger("damage");
        healthAmount -= damageImpact;
        healthBar.fillAmount = healthAmount / 100f;
        if (healthAmount <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}