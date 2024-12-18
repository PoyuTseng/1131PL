using UnityEngine;

namespace PYT
{
    /// <summary
    /// NPC控制器
    /// </summary>
    public class NPCController: MonoBehaviour
    {
        [SerializeField, Header("NPC 資料")]
        private DataNPC dataNPC;
        [SerializeField, Header("動畫參數")]
        private string[] parameters =
        {
            "走路", "跑步", "攻擊", "跑砍走"
        };

        private Animator ani;

        public DataNPC data => dataNPC;

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        public void PlayAinmation(int index)
        {
            ani.SetTrigger(parameters[index]);
        }
    }
}