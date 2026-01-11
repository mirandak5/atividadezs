using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    public float _playerSpeed;
    private Vector2 _playerDirection;
    void Start()
    {
        
        _playerRb = GetComponent<Rigidbody2D>();
        
    }

  
    void Update()
    {

        _playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    }

    void FixedUpdate()
    {
        
        _playerRb.MovePosition(_playerRb.position + _playerDirection * _playerSpeed * Time.fixedDeltaTime);
        
    }
    
}
