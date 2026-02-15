using UnityEngine;

public class PickUpHandler : MonoBehaviour
{
    private PlayerController pc;
    private void Awake()
    {
        if (pc == null)
        {
            pc = GetComponent<PlayerController>();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tags.Coin))
        {
            collision.gameObject.GetComponent<Coin>().OnCoinPickUpF();
            Debug.Log("ai preso il GETTONE DELLA PORTA");
        }
    }
}
