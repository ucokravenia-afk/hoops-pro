# Xsolla Webhook — HOOPS// PRO

Server-side payment confirmation. **Cannot run inside the HTML game file.**

## Setup

```bash
cd xsolla-webhook
npm install
export XSOLLA_WEBHOOK_SECRET="from_xsolla_merchant_webhooks"
export GRANT_API_SECRET="optional_random_string"
export PORT=8787
npm start
```

Public URL (HTTPS):

```
https://your-domain.com/webhooks/xsolla
```

Paste into Xsolla Merchant → Project → Webhooks.

## Signature

`Authorization: Signature <sha1(rawBody + secret)>`

## Client

```html
<script>
window.HOOPS_GRANT_API = "https://your-domain.com";
window.HOOPS_GRANT_SECRET = "same_as_GRANT_API_SECRET";
</script>
```

Game polls `GET /v1/grants/:userId` and claims after CG login / shop open.
