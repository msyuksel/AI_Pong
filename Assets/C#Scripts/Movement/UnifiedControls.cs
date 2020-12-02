using UnityEngine;

public class UnifiedControls : MonoBehaviour
{
    public bool isBumper1;

    public float speed = 5f;

    [SerializeField] private float yRange = 4f;

    void Update()
    {
        if (isBumper1)
        {
            float yOffset = InputAndMovementSpeed("Vertical");

            float clampedYPos = MovementAndRange(yOffset);

            transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);
        }
        else
        {
            float yOffset = InputAndMovementSpeed("Vertical2");

            float clampedYPos = MovementAndRange(yOffset);

            transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);
        }
        
    }

    private float InputAndMovementSpeed(string VOrV2)
    {
        float yThrow = Input.GetAxis(VOrV2);
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