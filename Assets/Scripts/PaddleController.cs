using UnityEngine;

public class PaddleController : MonoBehaviour
{
    Rigidbody2D pad;
    Vector2 initial;
    public float displacement;

    void Start()
    {
        pad = GetComponent<Rigidbody2D>();
        initial = pad.transform.localPosition;
    }

    void Update()
    {
        // Move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (initial.x <= 9.75f)   // limit to the right edge
                initial.x = initial.x + displacement;
        }
        // Move left
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (initial.x >= -9.75f)  // limit to the left edge
                initial.x = initial.x - displacement;
        }

        // Apply movement
        pad.MovePosition(initial);
    }
}
