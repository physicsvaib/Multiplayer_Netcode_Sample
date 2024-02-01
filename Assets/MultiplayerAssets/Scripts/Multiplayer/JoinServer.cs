using Unity.Netcode;
using UnityEngine;

namespace Phyw.Multiplayer
{

  public class JoinServer : MonoBehaviour
  {
    #region CustomMethods
    public void Join()
    {
      NetworkManager.Singleton.StartClient();
    }
    #endregion

  }
}