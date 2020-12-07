using UnityEngine;

public class UnifiedControls : MonoBehaviour
{
    public bool isBumper1;

    public float speed = 5f;

    [SerializeField] private float xRange = 4f;

    public Joystick joystick;

    void Update()
    {
        if (isBumper1)
        {
            Bumper1();
        }
        else
        {
            Bumper2();
        }

    }

    private void Bumper1()
    {
        float xOffset = InputAndMovementSpeed("Horizontal");

        float clampedXPos = MovementAndRange(xOffset);

        transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, transform.localPosition.z);
    }

    private void Bumper2()
    {
        float xOffset = InputAndMovementSpeed("Horizontal2");

        float clampedXPos = MovementAndRange(xOffset);

        transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, transform.localPosition.z);
    }

    private float InputAndMovementSpeed(string whichInput)
    {
        if (!isBumper1)
        {
            float xThrow = Input.GetAxis(whichInput);
            float xOffset = xThrow * speed * Time.deltaTime;
            return xOffset;
        }
        else
        {
            float xThrow = joystick.Horizontal;
            float xOffset = xThrow * speed * Time.deltaTime;
            return xOffset;
        }
    }

    private float MovementAndRange(float xOffset)
    {
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedxPos = Mathf.Clamp(rawXPos, -xRange, xRange);
        return clampedxPos;
    }
}