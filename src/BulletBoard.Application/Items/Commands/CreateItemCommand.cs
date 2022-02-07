﻿using BulletBoard.Application.Base;
using BulletBoard.Core.Models;

namespace BulletBoard.Application.Items.Commands
{
    public sealed record CreateItemCommand(Item Item) : ICommand
    {
    }
}