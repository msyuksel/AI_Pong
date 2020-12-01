using UnityEngine;

public class Paddle1 : MonoBehaviour
{

    public float speed = 5f;

    [SerializeField] private float yRange = 4f;

    void Update()
    {
        float yThrow = Input.GetAxis("Vertical");
        float yOffset = yThrow * speed * Time.deltaTime;

        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange);

        transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);
    }

}
