# Xsolla webhook integration

## Why a server?

Xsolla sends **server-to-server** HTTP callbacks. A browser HTML game cannot receive them securely. Deploy `xsolla-webhook/`.

## Verify signature

1. Read `Authorization: Signature <hex>`
2. Use **raw** JSON body bytes
3. `sha1(body + secret)` lowercase hex
4. Constant-time compare

Never respond **4xx** to `order_paid` on your own bugs (may refund). Use **5xx** to retry.

## SKU map

Edit `SKU_MAP` in `server.js` to match Xsolla catalog / CrazyGames items.

## Flow

Player pays → Xsolla `order_paid` → webhook stores pending grant → game `pullXsollaGrants()` applies coins/cosmetics.
