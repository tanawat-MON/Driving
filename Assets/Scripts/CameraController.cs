using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;
    Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //player = GameObject.Find("Car"); �Ҵ��ª���
        player = GameObject.FindWithTag("Player");        // �Ҵ��� Tag
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
