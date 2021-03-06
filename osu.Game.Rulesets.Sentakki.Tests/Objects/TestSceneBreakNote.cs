﻿using NUnit.Framework;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Beatmaps;
using osu.Game.Beatmaps.ControlPoints;
using osu.Game.Rulesets.Sentakki.Objects;
using osu.Game.Rulesets.Sentakki.Objects.Drawables;
using osu.Game.Tests.Visual;
using osuTK;
using osuTK.Graphics;

namespace osu.Game.Rulesets.Sentakki.Tests.Objects
{
    [TestFixture]
    public class TestSceneBreakNote : OsuTestScene
    {
        private readonly Container content;
        protected override Container<Drawable> Content => content;

        private int depthIndex;

        public TestSceneBreakNote()
        {
            base.Content.Add(content = new SentakkiInputManager(new RulesetInfo { ID = 0 }));

            AddStep("Miss Single", () => testSingle());
            AddStep("Hit Single", () => testSingle(true));
        }

        private void testSingle(bool auto = false)
        {
            var circle = new Break
            {
                StartTime = Time.Current + 1000,
                Position = new Vector2(0, -66f),
                Angle = 0,
                EndPosition = new Vector2(0, -296.5f),
                NoteColor = Color4.OrangeRed,
            };

            circle.ApplyDefaults(new ControlPointInfo(), new BeatmapDifficulty { });

            Add(new DrawableBreak(circle)
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Depth = depthIndex++,
                Auto = auto
            });
        }
    }
}
