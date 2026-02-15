using UnityEngine;

public class ToxicGas : MonoBehaviour
{
    [SerializeField] int damage = 100;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent<LifeController>(out LifeController life))
        {
            life.TakeDamage(damage);
        }
    }
}
