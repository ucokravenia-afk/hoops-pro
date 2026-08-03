# CrazyGames SDK + Score API

Official docs: https://docs.crazygames.com/

## Integrated in HOOPS_PRO_PREMIUM.html

1. Script: `https://sdk.crazygames.com/crazygames-sdk-v3.js`
2. `CrazyGames.SDK.init()` on boot
3. `game.loadingStart` / `loadingStop`
4. `game.gameplayStart` on match start · `gameplayStop` on end
5. `game.happytime()` on win
6. Leaderboard: AES-GCM encrypt + `user.submitScore({ encryptedScore, score })`

## Score formula

```
score = clamp( ptsA*10 + margin*25 + winBonus + dunks*15 , 0, 500000)
winBonus = 500 if win, 100 if draw, 0 if loss
```

## Encryption key (required for real leaderboard)

1. Open [CrazyGames Developer Portal](https://developer.crazygames.com/)
2. Enable Leaderboard for the game · copy **Encryption Key** (32-byte base64)
3. Before game script, set:

```html
<script>window.HOOPS_CG_ENCRYPTION_KEY = "YOUR_KEY_FROM_PORTAL";</script>
```

Or replace `CG_LEADERBOARD_KEY` constant after publish.

Without the key, gameplay events still work; score submit logs a warning (safe for local dev).

## Suggested portal config

```json
{
  "scoreLabel": "RATING",
  "scoreSorting": "DESC",
  "minValue": 0,
  "maxValue": 500000,
  "cooldownSeconds": 10,
  "isIncremental": false
}
```

## Test

Use portal **Preview** → Logs tab → play a match to completion → look for `submitScore`.

## Data module (optional later)

`cgDataGet` / `cgDataSet` prefer `SDK.data` when logged-in user progress is enabled on submission form.
