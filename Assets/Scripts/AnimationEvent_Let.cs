using UnityEngine;

public class AnimationEvent_Let : MonoBehaviour
{
    private Animator anim;
    private int randomAnimationIndex;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void RandomAnimation()
    {
        randomAnimationIndex = Random.Range(0, 3);
        anim.SetInteger("AnimationIndex", randomAnimationIndex);

    }
}
