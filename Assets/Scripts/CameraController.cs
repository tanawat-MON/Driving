using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;
    Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //player = GameObject.Find("Car"); หาด้วยชื่อ
        player = GameObject.FindWithTag("Player");        // หาด้วย Tag
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
