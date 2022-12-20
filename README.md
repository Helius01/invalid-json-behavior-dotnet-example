# invalid-json-behavior-dotnet-example
This repository shows you the problem of serialization in dotnet.
Good to know this problem also exists in the `Newtonsoft.Json` package @JamesNK

```
Note:
The use of this repo is only for displaying bug

```


### Description
Hey. when i deserialized a type of `Dictionary<string,int>` from `appsettings.json` , I encountered an unexpected value  

**The result I expected :**
```
"https://example.com":1,
"https://example2.com":2
```


**The result I received:**
```
"https":1,
"https":2
```


