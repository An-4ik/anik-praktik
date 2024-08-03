
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour /*, IBeginDragHandler, IDragHandler*/
{
    Vector2 targetPos;
    public float Jump;//прижок - дистанция

    public float speed;//скорость

    public float MaxHight;//максимальная высота
    public float MinHight;///минимальная высота

    public int Health = 3; //кол-во жизней

    public GameObject LoosPanel; //панелька проигрыша

    public GameObject effect; // эффект пузырек
    public AudioSource bubles; // звук пузырек

    public GameObject[] health = new GameObject[3]; //колво жизней
    public bool EnmAtak = false;

    public Animator CamAnim;
    public Animator Dmg;


    public bool moveUp = false; //при проведение пальцем вверх
    public bool moveDown = false; //при проведение пальцем вниз
    void Start()
    {
        Time.timeScale = 1.0f;
        Vector2 targetPos = new Vector2(transform.position.x, transform.position.y);
        Dmg = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        FishHelth();

        TheEnd();
    }

    private void MovePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || moveUp) && transform.position.y < MaxHight)
        {
            Instantiate(effect, transform.position, Quaternion.identity); // эффукт пузырек
            targetPos = new Vector2(transform.position.x, transform.position.y + Jump);
            bubles.pitch = Random.Range(0.8f, 1.2f);
            bubles.Play();
            CamAnim.SetTrigger("shake");
            moveUp = false;
        }
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || moveDown) && transform.position.y > MinHight)
        {
            Instantiate(effect, transform.position, Quaternion.identity); // эффукт пузырек
            targetPos = new Vector2(transform.position.x, transform.position.y - Jump);
            bubles.pitch = Random.Range(0.8f, 1.2f);
            bubles.Play();
            CamAnim.SetTrigger("shake");
            moveDown = false;

        }
        if (transform.position.y > MaxHight)
        {
            Vector2 posUp = new Vector2(transform.position.x, MaxHight);
            transform.position = posUp;
        }
        if (transform.position.y < MinHight)
        {
            Vector2 posUp = new Vector2(transform.position.x, MinHight);
            transform.position = posUp;
        }
    }

    private void FishHelth()
    {

        if (EnmAtak)
        {

            for (int i = 0; i < health.Length; i++)
            {


                health[Health].SetActive(false);


            }
           
            EnmAtak = false;
        }
    } 

    private void TheEnd() //конец жизней
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            LoosPanel.SetActive(true);
        }
    }

   /* public void OnBeginDrag(PointerEventData eventData)  //проведение пальцем по оси Y
    {
        if ((Mathf.Abs(eventData.delta.x) < (Mathf.Abs(eventData.delta.y))))
        {
            if (eventData.delta.y > 0)
            {
                moveUp = true;
            }
            else
            {
                moveDown = true;
            }
        }
    }
   
    
    public void OnDrag(PointerEventData eventData)
    {
        //здесь пусто :)
    }
    */

}
