using UnityEngine;

public class Movement : MonoBehaviour
{
    private Input _input;
    private Rigidbody2D _rb;

    //adding speed to win over inertia
    [SerializeField]
    private float _speed;

    private void Awake()
    {
        _input = GetComponent<Input>();
        _rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        _rb.AddForce(_input.GetMove() *_speed);
    }

    private void Update()
    {
        
    }
}
