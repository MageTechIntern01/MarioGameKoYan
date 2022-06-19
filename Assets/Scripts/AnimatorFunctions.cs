using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatorFunctions : MonoBehaviour
{
    [Header("Particles")]
    [SerializeField] private ParticleSystem particleSystem1;
    [SerializeField] private int emitAmount1;
    [SerializeField] private ParticleSystem particleSystem2;
    [SerializeField] private int emitAmount2;
    [SerializeField] private ParticleSystem particleSystem3;
    [SerializeField] private int emitAmount3;
    [SerializeField] private ParticleSystem particleSystem4;
    [SerializeField] private int emitAmount4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //Play a sound through the specified audioSource
    

    public void EmitParticles()
    {
        particleSystem1.Emit(5);
    }

    public void EmitParticles1()
    {
        particleSystem1.Emit(emitAmount1);
    }

    public void EmitParticles2()
    {
        particleSystem2.Emit(emitAmount2);
    }

    public void EmitParticles3()
    {
        particleSystem3.Emit(emitAmount3);
    }

    public void EmitParticles4()
    {
        particleSystem4.Emit(emitAmount4);
    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}