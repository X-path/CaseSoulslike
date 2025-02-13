using UnityEngine;

public class Gold : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 7)
        {
            PlayerData.instance.ChangeGold(1); // 
            Destroy(gameObject);
            Debug.Log("Altýn toplandý! Yeni Altýn: " + PlayerData.instance.gold);

        }
    }
}
