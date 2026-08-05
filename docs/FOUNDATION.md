# HOOPS// PRO — Foundation Status

**Policy:** No random feature expansion until foundation gates pass.

**Last verified:** 2026-08-05 (syntax OK, critical symbols present)

## Architecture map

| Layer | Responsibility |
|-------|----------------|
| Presentation | Overlays, hub CTA, collection |
| Input | Keyboard, touch, gamepad |
| Gameplay | Match loop, rules, AI, motion blend |
| Data | CLUBS, PLAYER_CARD_DB, EVENT_CATALOG |
| Persistence | Split saves (career/manager/rpg/settings/events) |
| Live ops | Curated events only |
| Platform | CrazyGames SDK, local auth |

## Save keys (split)

- hoopsProCareerSave_v1
- hoopsProManagerSave_v1
- hoopsProRpgSave_v1
- hoopsProSettings_v1
- hoopsEvents_v1
- hoopsCardFavs
- hoopsOnboardDone_v1
- hoopsProAccounts_v1 / hoopsProSession_v1
- hoopsKeybinds_v1

## Player journey

Studio → Loading → Press Any Key → [Onboard once] → Main Menu (PLAY CTA) → Mode/Career/Match → Rewards → Meta

## Automated gates

`runFoundationGates()` logs PASS/FAIL to console on boot.

## Foundation fixes this pass

- Removed duplicate requestRewardedAdCoins
- Disambiguated hashStrFNV for auth path
- Foundation self-check on boot

## Next (ordered)

1. AI role behaviors
2. Shot contest + stamina audit
3. Particle/crowd performance caps
4. Save migration helpers
5. Then seasonal content

## Non-goals

100+ event UIs, open-world city, licensed NBA photos, multiplayer rewrite.
