using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateWirePiece : MonoBehaviour {

    //update variable when wire fom present elevator has been obtained
    //this means that players have the wire to fix the pad in the past
    public void UpdateWire()
    {
        PuzzlePiece.puzzlePieces.wire = 1;
    }
}
