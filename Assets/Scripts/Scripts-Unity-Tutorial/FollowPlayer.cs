using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    /* SOLU��O 1: DUAS C�MERAS - FRONT E BACK VIEW
    private Vector3 offsetBackView = new Vector3(0, 5, -9);
    private Vector3 offsetFrontView = new Vector3(0, 2, (float)0.5);
    private bool isFrontView = false;
    */

    private Vector3 offset = new Vector3(0, 5, -9);

    void Start()
    {
        
    }

    // ISSO N�O � INTERESSANTE: PORQUE A C�MERA FICA TREMENDO DE VEZ EM QUANDO POR CONTA DAS MOVIMENTA��ES SENDO CALCULADAS TEMPO -> void Update()
    // ISSO � INTERESSATE: O LATE UPDATE ATUALIZA DEPOIS DE UM Update() NORMAL -> LateUpdate()
    void LateUpdate()
    {
        // transform.position = player.transform.position;
        // ISSO N�O FUNCIONA: PORQUE TRANSLATE USA UM VALOR PARA SOMAR � POSI��O DO OBJETO, IMAGINE -20 SEQUENCIALMENTE -> transform.Translate(player.transform.position);
        // ISSO N�O FUNCIONA: PORQUE '' � UM CHAR, N�O UMA STRING, "" -> Debug.Log($'{player.transform.position})');
        // Debug.Log($"Posi��o do Player �: {player.transform.position}");
        // ISSO N�O � INTERESSANTE: PORQUE � A POSI��O RELATIVA DO CARRO SUBTRA�DOS 94, O QUE D� UM ZOOM GIGANTESCO -> transform.position = player.transform.position + new Vector3(0, 5, -94)

        /* SOLU��O 1: DUAS C�MERAS - FRONT E BACK VIEW
        if (Input.GetKeyDown("f"))
        {
            if (isFrontView)
            {
                isFrontView = false;
                offset = offsetBackView;
            } else
            {
                isFrontView = true;
                offset = offsetFrontView;
            }
        }*/

        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;

    }
}
