using UnityEngine;

public class DamageObject : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 7)
        {
            PlayerData.instance.ChangeHealth(-10); 
            Destroy(gameObject); 
            Debug.Log("Damage! Yeni Health: " + PlayerData.instance.health);

        }
    }
}
