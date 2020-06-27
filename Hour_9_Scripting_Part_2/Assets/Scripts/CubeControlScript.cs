using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    float itemscale = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 5f, 0f, Input.GetAxis("Vertical") * 5f, 0f);

        transform.Rotate(Input.GetAxis("Mouse Y") * 3f, -Input.GetAxis("Mouse X") * 3f, 0f);

        if (Input.GetKey(KeyCode.N))
            itemscale = .1f;
        else if (Input.GetKey(KeyCode.M))
            itemscale += .1f;
        transform.localScale = new Vector3(itemscale, itemscale, itemscale);
    }
}
