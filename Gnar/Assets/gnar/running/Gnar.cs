using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gnar : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    // Update is called once per frame
    void Update() {

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal / 50;

    }

    private void OnMouseDown()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 10.0f));

    }
}
