using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float speed = 5;

  Vector3 movement;

  void Update()
  {
    movement = new(
      Input.GetAxisRaw("Horizontal"),
      Input.GetAxisRaw("Vertical")
    );
    movement.Normalize();
  }

  void FixedUpdate()
  {
    GetComponent<Rigidbody2D>().velocity = movement * speed;
  }
}