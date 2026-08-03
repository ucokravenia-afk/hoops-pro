# Rebound system (HTML5 core)

## Goals
Make missed shots contested, reward positioning and bigs, create second-chance offense.

## Mechanics

1. **Weighted contest** — distance, rebound/strength/vertical, position (C/PF bias), stamina fatigue
2. **Defensive bias** ~56% base (real basketball tilt)
3. **Tip-out** (~7%) — chaotic 50/50
4. **Grabber selection** — weighted random among team near hoop
5. **OREB** — shorter shot clock (14s), higher momentum
6. **Putback look** — if OREB inside ~52px, chance of automatic putback attempt (AI always-ish, human sometimes)

## Stats

- `player.stats.reb` increments on successful grab
- Ticker differentiates OREB vs DREB

## Integration

- `resolveShot` miss path → `resolveRebound`
- Momentum, possession, shot clock updated
- Future: mid-air animation hooks without rewriting shot arc
