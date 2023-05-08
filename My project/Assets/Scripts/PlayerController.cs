using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Velocidade do jogador tipo float
    public float velocidadejogador;
    private Vector2 botaoclicado;

    public bool havedoubleLasers;

    public Rigidbody2D rig;
    public GameObject PlayerFastfire;
    public Transform LocalPlayerFireUnique;
        
        
    // Start is called before the first frame update
    void Start()
    {
        havedoubleLasers = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovimmentPlayer();
        FastFirePlayer();
    }

    private void MovimmentPlayer()
    {
        botaoclicado = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rig.velocity = botaoclicado.normalized * velocidadejogador;
    }

    private void FastFirePlayer()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (havedoubleLasers == false)
            {
                Instantiate(PlayerFastfire, LocalPlayerFireUnique.position, LocalPlayerFireUnique.rotation);
            }
        }
    }
}
