using UnityEngine;

public class CheckPointButton : MonoBehaviour
{
    [SerializeField] int checkPointId;
    [SerializeField] int sceneId;

    public void ButtonClick()
    {
        UIManager.instance.CheckPointButtonClick(checkPointId, sceneId);
    }
}
