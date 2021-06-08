using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    public Animator animator;
    public int choose;
    
    // Start is called before the first frame update
    public void animKawasaki (){
        animator.SetBool("Kawasaki", true);
    }

    public void animSuzuki (){
        animator.SetBool("Suzuki", true);
    }

    public void NonActive (){
        animator.SetBool("Kawasaki", false);
        animator.SetBool("Suzuki", false);
    }

    public void Ar (){
        
        choose = Manager.Buat.choose;

        if (choose == 1) {
            SceneManager.LoadScene("Kawasaki");
        } else if (choose == 2) {
            SceneManager.LoadScene("Suzuki");
        }
    }

    public void isiKawasaki(){
        Manager.Buat.choose = 1;
    }
    
    public void isiSuzuki(){
        Manager.Buat.choose = 2;
    }

}
