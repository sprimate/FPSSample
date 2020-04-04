using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeRugby : IGameMode
{
    public void Initialize(GameWorld world, GameModeSystemServer gameModeSystemServer)
    {
        throw new System.NotImplementedException();
    }

    public void OnPlayerJoin(PlayerState player)
    {
        throw new System.NotImplementedException();
    }

    public void OnPlayerKilled(PlayerState victim, PlayerState killer)
    {
        throw new System.NotImplementedException();
    }

    public void OnPlayerRespawn(PlayerState player, ref Vector3 position, ref Quaternion rotation)
    {
        throw new System.NotImplementedException();
    }

    public void Restart()
    {
        throw new System.NotImplementedException();
    }

    public void Shutdown()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
