using UnityEngine;
public class Dore : MonoBehaviour
{
    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        anim.SetTrigger("Open");
        Debug.Log("apriti sesamo");
    }
}
