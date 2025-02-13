using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int CheckPointId = 0;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (PlayerData.instance.checkPointId >= CheckPointId) return;

        if (other.gameObject.layer == 7)
        {
            Debug.Log("Checkpointa girildi!");
            //PlayerData player = other.GetComponent<PlayerData>();
            // if (player != null)
            //{

            PlayerData.instance.ChangePointId(CheckPointId);
            PlayerData.instance.ChangeStoryProgress(20);
            PlayerData.instance.AddCheckpoint(transform.position);

            SaveSystem.SaveGame(PlayerData.instance);

            Debug.Log("Checkpoint Kaydedildi!");
            UIManager.instance.UpdateSavedInformation();
            //}
        }
    }
}
