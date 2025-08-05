using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    Vector2 movement;

    void Update()
    {
        PlayerShip_Movement();
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void PlayerShip_Movement()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;

        float yOffset = movement.y * controlSpeed * Time.deltaTime;

        transform.localPosition = new Vector3(transform.localPosition.x + xOffset, transform.localPosition.y + yOffset, 0f);
    }
}
