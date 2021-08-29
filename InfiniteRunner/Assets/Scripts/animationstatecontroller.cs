using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationstatecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    int isRunningHash;
    int isJumpHash;
    int isCrouchHash;
    void Start()
    {
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("RUNNING");
        isJumpHash = Animator.StringToHash("JUMPING");
        isCrouchHash = Animator.StringToHash("CROUC");
    }

    // Update is called once per frame
    void Update()
    {
        bool isjump = animator.GetBool(isJumpHash);
        bool isrunning = animator.GetBool(isRunningHash);
        bool iscrouch = animator.GetBool(isCrouchHash);
        bool forwardpressed = Input.GetKey("w")||Input.GetKey("up");
        bool jumppressed = Input.GetKey("space");
        bool crouchpressed = Input.GetKey("c");
        if (!isrunning && forwardpressed)
        {
            animator.SetBool(isRunningHash, true);

        }
        if (isrunning &&!forwardpressed)
        {
            animator.SetBool(isRunningHash, false);

        }
        if(!isjump&&(forwardpressed&&jumppressed))
        {
            animator.SetBool(isJumpHash, true);
        }
        if (isrunning&&(!forwardpressed || !jumppressed))
        {
            animator.SetBool(isJumpHash, false);
        }
        if(jumppressed)
        {
            animator.SetBool(isJumpHash, true);
        }
        if(!jumppressed)
        {
            animator.SetBool(isJumpHash, false);
        }

        if(crouchpressed)
        {
            animator.SetBool(isCrouchHash, true);
        }
        if(!crouchpressed)
        {
            animator.SetBool(isCrouchHash, false);
        }

    }
}
