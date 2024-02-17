using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAnimationBools : MonoBehaviour
{
    public void ResetAttackAnimation()
    {
        SceneManager.Instance.p1Animator.SetBool("attack", false);
    }

    public void ResetTakeDamageAnimation()
    {
        SceneManager.Instance.p1Animator.SetBool("takeDamage", false);
    }
}
