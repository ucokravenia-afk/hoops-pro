# Full game pack strategy

The complete HOOPS_PRO_PREMIUM.html (~445KB) is stored in Grok session artifacts.

## Loader

`game/index.html` expects 27 gzip+base64 shards:

`game/parts/s0.txt` … `game/parts/s26.txt`

## Generate locally

```bash
python3 - <<'PY'
import gzip,base64
from pathlib import Path
raw=Path('HOOPS_PRO_PREMIUM.html').read_bytes()
b64=base64.b64encode(gzip.compress(raw,9)).decode()
n=27
ch=(len(b64)+n-1)//n
Path('game/parts').mkdir(parents=True,exist_ok=True)
for i in range(n):
    Path(f'game/parts/s{i}.txt').write_text(b64[i*ch:(i+1)*ch])
print('wrote',n,'parts')
PY
```

Then open `game/index.html` via a static server (fetch needs HTTP).

```bash
python3 -m http.server 8080 --directory game
```

## Grok

Ask: push pack parts s0-s26 ke branch feat/game-pack-parts
