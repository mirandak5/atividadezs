using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    
    public string SceneName;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("SceneName");
        }
    }
}