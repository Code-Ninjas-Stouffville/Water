using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Animator playerAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x == 0 && y == 0)
        {
            
            playerAnim.SetBool("IsWalking", false);
        }
        else
        {
            
            playerAnim.SetBool("IsWalking", true);
            if (x<0)
            {
                gameObject.transform.localScale = new Vector3(-Mathf.Abs(gameObject.transform.localScale.x), gameObject.transform.localScale.y, gameObject.transform.localScale.z);
            }
            else
            {
                gameObject.transform.localScale = new Vector3(Mathf.Abs(gameObject.transform.localScale.x), gameObject.transform.localScale.y, gameObject.transform.localScale.z);
            }
        }

        Vector2 pos = new Vector2(x, y) * moveSpeed * Time.deltaTime;
        transform.Translate(pos);
    }
}
