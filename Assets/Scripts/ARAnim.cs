using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARAnim : MonoBehaviour
{
    public Animator animator;
     public Animator animator1;
    [SerializeField] int choose;
    // Start is called before the first frame update
    public void animShow (){

        animator.SetBool ("Show", true);
    }

    public void changeColor (){

        animator1.SetInteger ("Color", choose);
        animator.SetBool ("Show", false);
    }

     public void ArBack (){

        SceneManager.LoadScene("MainMenu");
        
    }
}
