using UnityEngine;

public class AnimationEvent_Let_2 : MonoBehaviour
{
    private Animator anim;
    private string[] animationNames = { "let_2-1_Animation", "let_2-2_Animation", "let_2-3_Animation" };


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void RandomAnimation_2()
    {
        int randomIndex = Random.Range(0, animationNames.Length);
        string randomAnimation = animationNames[randomIndex];
        anim.Play(randomAnimation);
    }
}
