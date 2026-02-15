using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class LifeController : MonoBehaviour
{
    [SerializeField] public int hp = 100;
    [SerializeField] private int maxHP = 100;
    [SerializeField] private int curentHP;
    [SerializeField] private UnityEvent<int, int> onHealthChanged;
    [SerializeField] private float duration = 0.5f;
    [SerializeField] public GameObject loseGameObject;
    IEnumerator Respawn;
    Vector3 respownPosition;

    private void Start()
    {
        hp = maxHP;
        onHealthChanged.Invoke(hp, maxHP);
        respownPosition = transform.position;
    }
    public void SetHp(int hp)
    {
        hp = Mathf.Clamp(hp, 0, maxHP);
        if (curentHP != hp)
        {
            curentHP = hp;
            if (curentHP == 0)
            {
                Die();
            }
        }
        curentHP = hp;
        if (curentHP == 0)
        {
            Die();
            loseGameObject.SetActive(true);
        }
        onHealthChanged.Invoke(hp, maxHP);
        Debug.Log("prendo danno");
    }
    public void TakeDamage(int damage)
    {
        AddHP(-damage);
    }

    public void AddHP(int amount) => SetHp(curentHP + amount);
    public int GetHP() => curentHP;
    public int GetMaxHP() => maxHP;

    public void Die()
    {
        StartCoroutine(RespawnEnum(duration));
    }
    IEnumerator RespawnEnum(float duration)
    {
        yield return new WaitForSeconds(duration);
        transform.position = respownPosition;
        onHealthChanged.Invoke(hp, maxHP);
        curentHP = maxHP;
        loseGameObject.SetActive(false);
        Debug.Log("resetHP");
    }
}
