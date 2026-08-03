# AES-GCM score encryption (CrazyGames)

Implements the client leaderboard scheme from:
https://docs.crazygames.com/sdk/leaderboards-client/

## Algorithm

1. Decode portal **Encryption Key** from base64 → 16 or 32 raw bytes (AES-128/256)
2. Random **IV** 12 bytes (`crypto.getRandomValues`)
3. `subtle.importKey('raw', key, {name:'AES-GCM'}, false, ['encrypt'])`
4. Encrypt UTF-8 string of the numeric score with `{name:'AES-GCM', iv}`
5. Output **base64(IV || ciphertext+tag)**

## Game API

| Function | Role |
|----------|------|
| `cgEncryptScore(score, keyB64)` | Encrypt for `submitScore` |
| `cgDecryptScore(b64, keyB64)` | Local verify only |
| `cgTestAesGcm()` | Console self-test (ephemeral key) |

## Configure key

```html
<script>window.HOOPS_CG_ENCRYPTION_KEY = "BASE64_KEY_FROM_PORTAL";</script>
```

## Requirements

- Secure context: **HTTPS** or localhost (Web Crypto)
- Key must be the exact portal value (wrong length throws)

## Self-test

In browser console after load:

```js
await cgTestAesGcm()  // → true / PASS log
```
