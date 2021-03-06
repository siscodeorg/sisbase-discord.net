﻿using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisbase.CommandsNext {
    public abstract class PrefixResolver {
        public DiscordSocketClient Client { get; init; }
        public SocketSelfUser User { get; private init; }

        public PrefixResolver(DiscordSocketClient client) {
            Client = client;
            User = Client.CurrentUser;
        }

        public abstract Task<int> GetArgumentPositionAsync(SocketUserMessage message);
    }
}
