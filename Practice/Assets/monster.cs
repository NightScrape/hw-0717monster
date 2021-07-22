using UnityEngine;

public class monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float movementspeed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public int attack = 100;
    [Range(0, 5000)]
    public int hp = 350;
    [Header("掉落道具(遊戲物件)"),Tooltip("擊倒這隻怪物時是否會掉落相關獎勵")]
    public bool itemdrop = false;
    [Header("掉落道具機率"), Range(0, 1)]
    public float chance = 1;
    [Header("掉落道具音效"),Tooltip("掉落道具時是否會用音效提醒")]
    public bool AudioClip = false;
    private AudioSource auds;
    private Rigidbody2D rig;
    private Animator ani;
}
