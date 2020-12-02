using UnityEngine;

public class Paddle2 : MonoBehaviour
{

    public float speed = 5f;

    [SerializeField] private float yRange = 4f;

    void Update()
    {
        float yOffset = InputAndMovementSpeed();

        float clampedYPos = MovementAndRange(yOffset);

        transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);
    }

    private float InputAndMovementSpeed()
    {
        float yThrow = Input.GetAxis("Vertical2");
        float yOffset = yThrow * speed * Time.deltaTime;
        return yOffset;
    }

    private float MovementAndRange(float yOffset)
    {
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange);
        return clampedYPos;
    }
}
