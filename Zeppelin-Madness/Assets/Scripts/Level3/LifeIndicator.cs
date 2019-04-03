using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeIndicator : MonoBehaviour 
{
    
    public Image ActualLife;
    public Text RatioText;

    private float hitpoint = 150;
    private float maxHitpoint = 150;

    private void Start()
    {
        UpdateHealthbar();
        
    }

    private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        if (ActualLife && RatioText)
        {
            ActualLife.rectTransform.localScale = new Vector3(ratio, 1, 1);
            RatioText.text = (ratio * 100).ToString("0") + "%";
        }
        else return;
    }

    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("HIT");
        }
        if (hitpoint == 0)
        {
            SceneManager.LoadScene("Main Hub", LoadSceneMode.Single);
        }
        UpdateHealthbar();
    }

    private void HealDamage(float heal)
    {
        heal = 50;
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
        {
            hitpoint = maxHitpoint;
            Debug.Log("HEALING");
        }
        UpdateHealthbar();
    }
}
