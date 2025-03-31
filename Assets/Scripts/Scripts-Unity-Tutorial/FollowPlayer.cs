using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    /* SOLUÇÃO 1: DUAS CÂMERAS - FRONT E BACK VIEW
    private Vector3 offsetBackView = new Vector3(0, 5, -9);
    private Vector3 offsetFrontView = new Vector3(0, 2, (float)0.5);
    private bool isFrontView = false;
    */

    private Vector3 offset = new Vector3(0, 5, -9);

    void Start()
    {
        
    }

    // ISSO NÃO É INTERESSANTE: PORQUE A CÂMERA FICA TREMENDO DE VEZ EM QUANDO POR CONTA DAS MOVIMENTAÇÕES SENDO CALCULADAS TEMPO -> void Update()
    // ISSO É INTERESSATE: O LATE UPDATE ATUALIZA DEPOIS DE UM Update() NORMAL -> LateUpdate()
    void LateUpdate()
    {
        // transform.position = player.transform.position;
        // ISSO NÃO FUNCIONA: PORQUE TRANSLATE USA UM VALOR PARA SOMAR À POSIÇÃO DO OBJETO, IMAGINE -20 SEQUENCIALMENTE -> transform.Translate(player.transform.position);
        // ISSO NÃO FUNCIONA: PORQUE '' É UM CHAR, NÃO UMA STRING, "" -> Debug.Log($'{player.transform.position})');
        // Debug.Log($"Posição do Player é: {player.transform.position}");
        // ISSO NÃO É INTERESSANTE: PORQUE É A POSIÇÃO RELATIVA DO CARRO SUBTRAÍDOS 94, O QUE DÁ UM ZOOM GIGANTESCO -> transform.position = player.transform.position + new Vector3(0, 5, -94)

        /* SOLUÇÃO 1: DUAS CÂMERAS - FRONT E BACK VIEW
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
