// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Sentakki.Judgements
{
    public class SentakkiBreakJudgement : SentakkiJudgement
    {
        protected override int NumericResultFor(HitResult result)
        {
            switch (result)
            {
                default:
                    return 0;

                case HitResult.Meh:
                    return 1000;

                case HitResult.Good:
                    return 2000;

                case HitResult.Great:
                    return 2500;
                case HitResult.Perfect:
                    return 2600;
            }
        }

        protected override double HealthIncreaseFor(HitResult result) => base.HealthIncreaseFor(result);
    }
}
