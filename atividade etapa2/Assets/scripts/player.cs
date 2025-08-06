using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float velocidade = 40;
    public float forcaDoPulo = 4;
    
    private bool noChao = false;
    private bool Andando = false;
    
    private SpriteRenderer sprite;
    private Rigidbody2D rb;
    private Animator animator;
    
    void Start()
    {
        
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    
    void Update()
    {
        Andando = false;
        
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime,0,0);
            sprite.flipX = true;
            Andando = true;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime,0,0);
            sprite.flipX = false;
            Andando = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            rb.AddForce(new Vector2(0,forcaDoPulo), ForceMode2D.Impulse);
        }

        animator.SetBool("Run",Andando);
        animator.SetBool("Jump",!noChao);
        
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        
        if(colisao.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }
    void OnCollisionExit2D(Collision2D colisao)
    {
        if(colisao.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }
}
