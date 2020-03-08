using UnityEngine;

public class playermovement : MonoBehaviour
{
    public AudioSource audio;
    public AudioSource audiobeforespace;
    public float speed;
    public float rotationSpeed;
    public Animator anim;
    public float MoveDistance = 2f;
    bool check = true;

    private int playerPosition = 1;
    private bool runn;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        random_animations();
        

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        runcheck();

        if(Input.GetKey(KeyCode.Escape))
        {

        }
    }

    void random_animations()
    {
        int m = Random.Range(0, 4);
        if (m == 0)
        {
            anim.Play("d1", -1, 1f);
        }
        else if (m == 1)
        {
            anim.Play("d2", -1, 1f);
        }
        else if (m == 2)
        {
            anim.Play("d3", -1, 1f);
        }
        else
        {
            anim.Play("d4", -1, 1f);
        }
    }

    void RUN()
    {
        float forward = speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("j", true);
        }
        
        // if D key is pressed down
        if (Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (playerPosition < 2)
            {
                // move the player along the positive Z axis
                transform.Translate(MoveDistance, 0, 0);
                // increment the player position
                playerPosition++;
            }
        }
        // if A key is pressed down
        else if (Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (playerPosition > 0)
            {
                // move the player along the negative Z axis
                transform.Translate(-MoveDistance, 0, 0);
                // decrement the player position
                playerPosition--;
            }
        }
  
        transform.Translate(0, 0, forward);
        //transform.Rotate(0, rotation, 0);
    }
    void runcheck()
    {
        if (Input.GetKeyDown("space"))
        {
            runn = true;
            anim.SetBool("run", runn);
            RUN();
        }
        else if(runn==true)
        {
            audiobeforespace.Stop();
            if (check== true){
                audio.Play();
            check= false; }
            RUN();
        }
    }
    void end()
    {
        FindObjectOfType<GameManager>().endgame();
    }
    void endjump()
    {
        anim.SetBool("j", false);
        anim.Play("run");
    }
}