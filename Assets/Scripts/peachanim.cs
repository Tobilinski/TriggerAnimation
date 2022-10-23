using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peachanim : MonoBehaviour
{
    public Animator peachanime;
    public void playIdle()
    {
        peachanime.SetBool("IsSurp", false);
    }
}
