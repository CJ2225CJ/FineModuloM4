using UnityEngine;
using UnityEngine.UI;

public class UI_LifeController : MonoBehaviour
{
    [SerializeField] Image lifeBar;
    public void UpdateLifeBar(int hp, int maxHp)
    {
        lifeBar.fillAmount = (float) hp / maxHp;
    }
}
