using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float min_Y, max_Y;
    [SerializeField] private GameObject player_Bullet;
    [SerializeField] private Transform attack_Point;
    public LifeCounts script;

    [SerializeField] private float attack_Timer = 0.35f;
    private float current_Attack_Timer;
    private bool canAttack;
    [SerializeField] private AudioClip ShotSound;

    [SerializeField] private ButtonsPlaneUPDOWN boolsBT;
    [SerializeField] private GameObject fireAnim;



    private void Awake()
    {
        Button fireButton = GameObject.Find("shoot").GetComponent<Button>();


        fireButton.onClick.AddListener(Fire);

        current_Attack_Timer = attack_Timer;
        LifeCounts.currentLifeIndex = 4;
    }

    private void Update()
    {
        MovePlayer();
        Attack();
    }

    void MovePlayer()
    {
        if (boolsBT.moveUp)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            if (temp.y > max_Y)
                temp.y = max_Y;
            transform.position = temp;
        }
        else if (boolsBT.moveDown)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            if (temp.y < min_Y)
                temp.y = min_Y;
            transform.position = temp;
        }
    }

    void Fire()
    {
        if (canAttack)
        {
            canAttack = false;
            attack_Timer = 0;
            Instantiate(player_Bullet, attack_Point.position, Quaternion.identity);
            GetComponent<AudioSource>().PlayOneShot(ShotSound);
            fireAnim.SetActive(true);
        }
        
    }

    void Attack()
    {
        attack_Timer += Time.deltaTime;
        if (attack_Timer > current_Attack_Timer)
        {
            canAttack = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            LifeCounts.currentLifeIndex--;
            script.DisableNextLife();
        }
    }
}