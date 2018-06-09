﻿using ProtoBuf;

namespace CitiesSkylinesMultiplayer.Commands
{
    /// <summary>
    ///     The server sends this command to all connected clients when
    ///     another client connects to the game.
    /// </summary>
    [ProtoContract]
    public class ClientConnect
    {
        /// <summary>
        ///     The username of the disconnected user.
        /// </summary>
        [ProtoMember(1)]
        public string Username { get; set; }
    }
}
