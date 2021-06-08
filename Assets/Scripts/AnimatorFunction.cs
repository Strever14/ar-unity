using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimatorFunction : MonoBehaviour
{
    public Animator animator;
    [SerializeField] int choose;
    [SerializeField] Text infoNamaMotor;
    [SerializeField] string namaMotor;
    // Start is called before the first frame update
    
    public void animShow (){
        infoNamaMotor.text = namaMotor;
        animator.SetInteger ("NoMotor", choose);
         Manager.Buat.choose = choose ;
        animator.SetBool ("Show", true);
    }

    public void animClose (){
        animator.SetInteger ("NoMotor", 0);
        animator.SetBool ("Show", false);
    }

    public void animMenuShow (){
        animator.SetBool ("Menu", true);
    }

    public void animMenuClose (){
        animator.SetBool ("Menu", false);
    }

    public void Ar (){

        choose = Manager.Buat.choose;

        if (choose == 1) {
            SceneManager.LoadScene("Beat");
        } else if (choose == 2) {
            SceneManager.LoadScene("Supra");
        }else if (choose == 3) {
            SceneManager.LoadScene("Vario");
        }else if (choose == 4) {
            SceneManager.LoadScene("Suzuki");
        }
    }
    
}
