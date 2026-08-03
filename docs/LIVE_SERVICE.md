# Live service layer (local)

Honest scope: **client-side live ops** with expandable calendar — not a full MMO backend with 500 players online.

## Economy

- `coins` — match rewards + quests
- `premium` — reserved for future
- Season pass XP per season id `S{year}Q{quarter}`

## Ranked

- MMR + tiers: Bronze → Diamond
- 5 placement matches

## Events (calendar)

| ID | Window |
|----|--------|
| christmas | Dec 20–31 |
| eid_fitri | Mar–May (window) |
| ramadan | Feb–Apr |
| newyear | Jan 1–7 |
| independence | Aug 10–20 |
| halloween | Oct 25–31 |
| valentine | Feb 10–16 |
| summer | Jun–Jul |

Active event missions roll into `rpgData.eventQuests` and progress with match stats.

Christmas also enables snow weather when starting a match.

## Expand

Add objects to `LIVE_EVENTS` array — no rewrite required.
