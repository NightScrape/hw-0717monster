using UnityEngine;

public class monster : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 10)]
    public float movementspeed = 3.5f;
    [Header("�����O"), Range(0, 500)]
    public int attack = 100;
    [Range(0, 5000)]
    public int hp = 350;
    [Header("�����D��(�C������)"),Tooltip("���˳o���Ǫ��ɬO�_�|�����������y")]
    public bool itemdrop = false;
    [Header("�����D����v"), Range(0, 1)]
    public float chance = 1;
    [Header("�����D�㭵��"),Tooltip("�����D��ɬO�_�|�έ��Ĵ���")]
    public bool AudioClip = false;
    private AudioSource auds;
    private Rigidbody2D rig;
    private Animator ani;
}
