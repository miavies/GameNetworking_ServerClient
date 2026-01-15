using UnityEngine;
using Fusion;

public class NetworkPlayer : NetworkBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    #region Fusion Callbacks
    //relevant to the network, do it in spawned (initialization)
    public override void Spawned()
    {

    }

    //On destroy
    public override void Despawned(NetworkRunner runner, bool hasState)
    {

    }

    //update function
    public override void FixedUpdateNetwork()
    {
        if(GetInput(out NetworkInputData input))
        {
            this.transform.position += 
                new Vector3(input.InputVector.normalized.x, input.InputVector.normalized.y) 
                * Runner.DeltaTime;
        }
    }

    //happens after fixedupdatenetwork, for nonserver objects
    public override void Render()
    {
    }
    #endregion
}
