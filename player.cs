using UnityEngine;

public class player : MonoBehaviour
{
    float xpos;
    float ypos;
    float half_scrn_x;

    void Start()
    {
        half_scrn_x = Screen.width / 2;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x > half_scrn_x) move(true);
            else move(false);
        }
    }

    void move(bool right)
    {
        if (right) xpos = transform.position.x + 0.5f;
        else xpos = transform.position.x - 0.5f;

        ypos =transform.position.y;
        xpos = Mathf.Clamp(xpos, -1.8f, 1.8f);
        transform.position = new Vector3(xpos, ypos, 0);
    }
}
