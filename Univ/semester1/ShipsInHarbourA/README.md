[Specification](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACmWR3WrCMBTHXyWcqxbT0jiELTQX4gYTNh37gEHtRdBsBtpUmjgcIuwyvoXP1icZifULr3JOTs7%2F%2Fzsna9ALMZVfcsqNrBRQGCqKVGPtCKNyf%2Bi5XGgXZiSOVT6pJ2q8NBSZyvBiVL3N5eKe%2F7ZvpfouxOyQipXUprH2CaOSr4bKiPqHF67mVF5qQRFJmUoZSZIEcTVzaXmWNvZPNtbunWlAUuZpMpmnrAy9SKWvWFgZDcYfo%2FdAsm4cq3aETObNdteGEcnDiDgPJxJ40DP8kL099F8Hj61CRDAKTp0nmTwioQc9VDskR812d3TskDA8uqCLNYTsuf95hRidAQIGI7TRQLM1zLjhQEFR1HNiJUUkcYF%2FT1FGcBf38C2%2B8z90uZC2x09JkamXwncepqXoxkue2NobwKB4KYACYKiFXhYGKNnkm38F%2BhYHOAIAAA%3D%3D)


```text
In: n∈N, m∈N, ships∈N[1..n]
Out: totalNoShipDay∈N, singleday∈N, exist∈L, maxInterval∈N
Pre: 1<=n<=1000 and 1<=m<=1000 and ∀i∈[1..n]:(1<=ships[i]<=m)
Post: totalNoShipDay=m-COUNT(i=2..n, ships[i]≠ships[i-1])-1 and
(exist, singleday)=SEARCH(i=2..n-1, (ships[i-1]≠ships[i]-1) and (ships[i+1] ≠ ships[i]+1)) and
( , maxInterval)=MAX(i=2..n, ships[i]-ships[i-1])
```
