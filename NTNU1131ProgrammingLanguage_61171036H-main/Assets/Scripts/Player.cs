using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string Name;
    public float HP;
    private float maxHP;
    private Image hpBar;
    private Transform barPos;
    private RectTransform barUI;
    private Animator animator; // 角色的動畫控制器

    public void Initialize(string name, float hp, Image hpBar, Transform barPos, RectTransform barUI)
    {
        this.Name = name;
        this.HP = hp;
        this.maxHP = hp;
        this.hpBar = hpBar;
        this.barPos = barPos;
        this.barUI = barUI;

        animator = GetComponent<Animator>(); // 獲取Animator元件
    }

    public void TakeDamage(float damage)
    {
        HP = Mathf.Max(0, HP - damage);
        Debug.Log($"[{Name}] takes {damage} damage! Remaining HP: {HP}");
    }

    public void UpdateHPBar()
    {
        hpBar.fillAmount = HP / maxHP;
        Vector3 screenPos = Camera.main.WorldToScreenPoint(barPos.position);
        barUI.position = screenPos;
    }

    public void PlayAttackAnimation()
    {
        if (animator != null)
        {
            animator.Play("攻擊"); // 統一播放名稱為“攻擊”的動畫
        }
        else
        {
            Debug.LogWarning($"[{Name}] does not have an Animator component!");
        }
    }
}
