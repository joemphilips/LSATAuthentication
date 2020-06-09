## LSAT Authentication middleware

This package provides authentication middleware according to [LSAT](https://github.com/lightninglabs/LSAT).

### Services you must override

This middleware has to do side-effects to work properly.
You probably want to override interfaces listed below by injecting it with DI (`services.AddSingleton()`)

* `IMacaroonRepository` for storing secrets for each macaroons.
  * By default, it will use in memory storage, this means when the server crashes, all macaroons will be invalidated.
* `ILSATInvoiceProvider` for getting Invoice which pays to you. User can have complete macaroons after paying to this invoice.
  * This is not necessary, but in that case you must set invoice by handler like below.
  * Otherwise users can not know where they have to pay (thus middleware does not work at all)
```csharp
services.AddAuthentication(options =>
    {
        options.DefaultScheme = LSATDefaults.Scheme;
        options.DefaultChallengeScheme = LSATDefaults.Scheme;
    }).AddLSATAuthentication(options =>
    {
        options.Events.OnPaymentRequired = async ctx =>
        {
            ctx.Bolt11Invoice = GetMyAwesomeInvoice(); // create invoice however you like.
        };
    });
```
