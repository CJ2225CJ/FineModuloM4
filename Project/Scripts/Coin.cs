using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    [SerializeField] UnityEvent onCoinPickUp;
    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    
    public void OnCoinPickUpF()
    {
        Destroy(gameObject);
        Debug.Log("ai preso il GETTONE DELLA PORTA");
        onCoinPickUp.Invoke();
    }
}