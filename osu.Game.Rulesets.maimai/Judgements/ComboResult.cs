﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;

namespace osu.Game.Rulesets.Maimai.Judgements
{
    public enum ComboResult
    {
        [Description(@"Miss")]
        None,


        [Description(@"Good")]
        Meh,

        [Description(@"Great")]
        Good,

        [Description(@"Perfect")]
        Great,

        [Description(@"Critical")]
        Perfect,
    }
}
