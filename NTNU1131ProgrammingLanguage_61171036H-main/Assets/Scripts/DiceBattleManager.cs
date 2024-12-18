using System;
using UnityEngine;
using UnityEngine.UI;

public class DiceBattleManager : MonoBehaviour
{
    public Player playerA;
    public Player playerB;
    public Image hpBarA;             // A玩家的血條前景
    public Image hpBarB;             // B玩家的血條前景
    public Transform barPosA;        // A玩家頭頂位置
    public Transform barPosB;        // B玩家頭頂位置
    public RectTransform barUIA;     // A玩家血條UI
    public RectTransform barUIB;     // B玩家血條UI

    private System.Random random = new System.Random();
    private bool battleStarted = false;

    void Start()
    {
        // 初始化玩家資料和血條
        playerA.Initialize("Player A", 50, hpBarA, barPosA, barUIA);
        playerB.Initialize("Player B", 50, hpBarB, barPosB, barUIB);

        Debug.Log(HuggingFaceManager("Narrator", "Welcome to the Dice Battle! Type 'START' to begin the battle."));
    }

    void Update()
    {
        // 檢測用戶輸入 START 以啟動戰鬥
        if (!battleStarted && Input.GetKeyDown(KeyCode.Return))
        {
            if (Input.inputString.ToUpper() == "START")
            {
                battleStarted = true;
                Debug.Log(HuggingFaceManager("Narrator", "The battle begins between Player A and Player B!"));
                StartBattle();
            }
        }
    }

    void StartBattle()
    {
        while (playerA.HP > 0 && playerB.HP > 0)
        {
            int rollA = RollDice(); // A擲骰子
            int rollB = RollDice(); // B擲骰子

            Debug.Log(HuggingFaceManager("Narrator", $"Player A rolls {rollA}, Player B rolls {rollB}."));
            ResolveTurn(rollA, rollB);

            // 更新血條
            playerA.UpdateHPBar();
            playerB.UpdateHPBar();

            if (playerA.HP <= 0 || playerB.HP <= 0)
            {
                EndBattle();
                break;
            }
        }
    }

    void ResolveTurn(int rollA, int rollB)
    {
        if (rollA > rollB)
        {
            if (rollA == 6)
            {
                float damage = rollA * 1.5f;
                playerB.TakeDamage(damage);
                Debug.Log(HuggingFaceManager("Narrator", "Player A scores a critical hit!"));
            }
            else
            {
                float damage = rollA;
                playerB.TakeDamage(damage);
                Debug.Log(HuggingFaceManager("Narrator", "Player A scores a normal hit."));
            }
        }
        else if (rollA < rollB)
        {
            if (rollB == 6)
            {
                float damage = rollB * 1.5f;
                playerA.TakeDamage(damage);
                Debug.Log(HuggingFaceManager("Narrator", "Player B scores a critical hit!"));
            }
            else
            {
                float damage = rollB;
                playerA.TakeDamage(damage);
                Debug.Log(HuggingFaceManager("Narrator", "Player B scores a normal hit."));
            }
        }
        else
        {
            float damageA = rollA * 0.5f;
            float damageB = rollB * 0.5f;
            playerA.TakeDamage(damageB);
            playerB.TakeDamage(damageA);
            Debug.Log(HuggingFaceManager("Narrator", "Both players hit each other with reduced damage."));
        }
    }

    void EndBattle()
    {
        if (playerA.HP <= 0 && playerB.HP <= 0)
        {
            Debug.Log(HuggingFaceManager("Narrator", "It's a tie! Both players fall."));
        }
        else if (playerA.HP <= 0)
        {
            Debug.Log(HuggingFaceManager("Narrator", "Player B wins the battle!"));
        }
        else if (playerB.HP <= 0)
        {
            Debug.Log(HuggingFaceManager("Narrator", "Player A wins the battle!"));
        }
    }

    int RollDice()
    {
        return random.Next(1, 7); // 骰子範圍 1 到 6
    }

    string HuggingFaceManager(string speaker, string message)
    {
        // 在這裡可以呼叫 HuggingFace API 進行語言生成
        // 現在只是模擬返回結果
        return $"[{speaker}] {message}";
    }
}
