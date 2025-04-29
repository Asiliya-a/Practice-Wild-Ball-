using UnityEngine;

public class AnimationEvent_Let_1 : MonoBehaviour
{
    private Animator anim;
    private string[] animationNames = { "let_1-1_Animation", "let_1-2_Animation", "let_1-3_Animation" };


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void RandomAnimation_1()
    {
        int randomIndex = Random.Range(0, animationNames.Length);
        string randomAnimation = animationNames[randomIndex];
        anim.Play(randomAnimation);
    }
}
