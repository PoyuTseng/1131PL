using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarFill;  // 用來參照血條填充的 Image
    public Transform target;     // 角色的 Transform（血條會跟隨這個）
    public float maxHealth = 100f;  // 最大血量
    private float currentHealth;  // 當前血量

    public Vector3 offset = new Vector3(0, 2, 0);  // 用來調整血條相對於角色的偏移位置

    void Start()
    {
        currentHealth = maxHealth;  // 初始化血量
    }

    void Update()
    {
        // 測試用的，減少血量
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10f);  // 每次按下空格鍵減少 10 點血量
        }

        // 每幀更新血條的位置
        FollowTarget();
    }

    // 設定角色受到傷害
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        UpdateHealthBar();
    }

    // 更新血條顯示
    void UpdateHealthBar()
    {
        float fillAmount = currentHealth / maxHealth;
        healthBarFill.fillAmount = fillAmount;  // 更新血條的填充比例
    }

    // 更新血條位置，使其跟隨角色
    void FollowTarget()
    {
        if (target != null)
        {
            // 將血條位置設置為角色位置加上一個偏移
            transform.position = target.position + offset;
        }
    }
}
