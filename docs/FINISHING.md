# Feature-complete pass (browser)

## Shipped in this phase

### Career life
Stages: Youth → High School → College → Draft → Rookie → Pro → Veteran → Retired → HoF  
Advances by games played. Home type upgrades (dorm → apartment → house). Reputation growth.

### Manager awards (end of season)
MVP, DPOY, Playmaker, Rebounder, Finals MVP (if you champ), Best Coach  
Stored in `managerData.awardHistory`.

### Live ops
- Daily login coins + XP by streak
- Event calendar (Christmas, Idul Fitri, …)
- Ranked MMR + season pass XP
- Coins economy

### Hall of Fame
Original legend roll-call in Progress hub (not licensed assets).

## Explicit non-goals (honest)

- Not a full open-world life sim (malls, barbers, etc.) — stages + home + endorsements hooks only
- Not real multiplayer backend
- Not 500 unique scanned players
- Not PBR 3D console parity

## QA checklist

- [x] Syntax check main script
- [x] Settings + i18n menu
- [x] Mobile touch controls present
- [x] CrazyGames score encrypt path
- [x] Save keys: career, manager, rpg, settings, auth

## Continue later without rewrite

Add to `LIVE_EVENTS`, `LIFE_STAGES`, `ACHIEVEMENT_DEFS`, `CLUBS`.
