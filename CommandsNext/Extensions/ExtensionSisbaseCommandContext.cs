﻿using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisbase.CommandsNext.Extensions {
    public static class ExtensionSisbaseCommandContext {
        public static SisbaseCommandContext AsSisbaseContext(this SocketCommandContext context, CommandInfo command)
            => new(context.Client, context.Message, command);
    }
}
