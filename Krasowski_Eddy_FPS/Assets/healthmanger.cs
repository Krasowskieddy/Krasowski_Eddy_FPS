using UnityEngine;
using UnityEngine.UI;
public class healthmanger : MonoBehaviour
{
    public float health = 75f;
    public float maxHealth = 100f;

    public Image healthBarImage;


    // Update is called once per frame
    void Update()
    {
        healthBarImage.fillAmount = health / maxHealth;
    }
}
