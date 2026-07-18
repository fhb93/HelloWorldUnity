using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Input : MonoBehaviour
{

    private Vector2 m_Move;

    public Vector2 GetMove()
    {
        return m_Move;
    }

    // 'Move' input action has been triggered.
    public void OnMove(InputValue value)
    {
        // Read value from control. The type depends on what type of controls the action is bound to.
        m_Move = value.Get<Vector2>();
    }


    public void Update()
    {
        // Update transform from m_Move
    }
}
