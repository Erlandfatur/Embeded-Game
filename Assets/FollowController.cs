using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour
{
    public GameObject Player;
    public bool isFollowing = false;
    public float followSpeed = 3f;
    public float followDistance = 2f;
    Vector3 moveDirection = Vector3.zero;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("isRunning", false);
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.LookAt(Player.transform);
         if (isFollowing == true)
    {
        if (Vector3.Distance(Player.transform.position, transform.position) > followDistance)
        {
            anim.SetBool("isRunning", true);
            CharacterController controller = GetComponent<CharacterController>();
            var moveDirection = Vector3.Normalize(Player.transform.position - transform.position);
            controller.SimpleMove(moveDirection * followSpeed);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

    }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isFollowing = true;
        }
    }
}
