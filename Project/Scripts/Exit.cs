using UnityEngine;
public class Exit : MonoBehaviour
{
    [SerializeField] public GameObject winGameObject;
    private void OnTriggerEnter(Collider other)
    {
        winGameObject.SetActive(true);
        Debug.Log("You Win");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
