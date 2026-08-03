# Game build

## Play (easiest)

Use the latest **`HOOPS_PRO_PREMIUM.html`** from the Grok artifact / your download folder.
Open in Chrome or Edge.

## Reconstruct from pack (this repo)

```bash
cd game/pack
cat part_00.b64 part_01.b64 part_02.b64 part_03.b64 | tr -d '\n' | base64 -d | gzip -d > ../HOOPS_PRO_PREMIUM.html
```

Then open `game/HOOPS_PRO_PREMIUM.html`.

Optional: place `derozia_eternal.mp3` beside the HTML for BGM.

## CrazyGames

See `docs/CRAZYGAMES_SDK.md` — set `window.HOOPS_CG_ENCRYPTION_KEY` from the portal.
