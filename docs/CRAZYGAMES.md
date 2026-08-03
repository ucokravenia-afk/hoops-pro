# CrazyGames hosting

See also **CRAZYGAMES_SDK.md** for leaderboard scores.

## Upload

- Engine: HTML5 / externally hosted zip with `HOOPS_PRO_PREMIUM.html` as entry
- Enable mobile if desired
- Progress Save: optional Data Module (SDK helpers ready)
- Leaderboard: configure encryption key then set `HOOPS_CG_ENCRYPTION_KEY`

## QA

- [ ] SDK init without error in Preview
- [ ] gameplayStart/Stop on match
- [ ] submitScore after final buzzer when key set
- [ ] iframe resize / 4K stable
