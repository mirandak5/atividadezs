using NUnit.Framework.Constraints;
using UnityEngine;
//using UnityEngine.Animations;
public class Mola : MonoBehaviour
{

    public float Boost = 10;
    private Rigidbody2D rb;
   // private Animator animator;

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Boost), ForceMode2D.Impulse);
          //  animator.SetTrigger("Pulo");    
            
        }
        

        // Update is called once per frame
        void Update()
        {

            //animator = GetComponent<Animator>();

        }
    }
}
