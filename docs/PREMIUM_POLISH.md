# Premium browser polish (HTML5 2D)

Scope is **premium web** quality on canvas — not native 3D PBR.

## Shipped

### Arena (per matchup)
- Club-tinted paint keys, banners, LED boards
- Jumbotron matchup bar
- Scorer table, home/away benches
- Shot-clock plates on backboards
- Floor vignette / wood theme preserved
- Cache key includes club ids (rebuild when matchup changes)

### Crowd
- Mood residual from `crowdRoar` / big plays
- Stronger bob + arm raise when excited
- Phone camera flashes on high mood
- Clothing highlight variation

### UI
- HUD blur + score glow
- Primary button hover lift

### Platform
- CrazyGames SDK scores + AES-GCM
- Embed/4K adaptive scale
- Safe storage

## Honest limits

Thousands of unique 3D spectators, locker tunnels, and PBR materials are **out of scope** for single-file canvas. Architecture keeps crowd density + FX budget tunable via `PERF`.

## Next polish priorities

1. Mid-match substitution panel
2. Accessibility shot-meter modes
3. Settings: reduce crowd / particles
4. Pack full HTML to GitHub shards
