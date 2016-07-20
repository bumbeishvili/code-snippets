# code snippets

## contents
+ c sharp
  - [converter.cs](#converter.cs)
+ php
  - [converter.php](#converter.php)
+ js
  - [number_to_text.js](#number_to_text.js)
  - [converter.js](#converter.js)
  - [GeoGrammar.js](#GeoGrammar.js)


## C sharp (C#)

### `Converter.cs`
 <a id="Converter.cs"></a> 
usage:  
`1. Converter.ToGeorgian("iyo arabeTs rostevan");`  
`2. Converter.ToLatin("ტუ ბე ორ ნოტ ტუ ბე");`  
returns:  
`1. იყო არაბეთს როსტევან`  
`2. to be or not to be`  

---



## PHP (php)  
 <a id="converter.php"></a> 
## `converter.php`  
include:  
`1. include("converter.php");`  
usage:  
`1. Converter::ToGeorgian("iyo arabeTs rostevan");`  
`2. Converter::ToLatin("ტუ ბე ორ ნოტ ტუ ბე");`    
returns:  
`1. იყო არაბეთს როსტევან`  
`2. to be or not to be`  

---


## Javascript (js)
 <a id="number_to_text.js"></a> 
### `number_to_text.js`  
desc:  
`converts max 10^3003 numbers to georgian text`  
include:  
`<script type="text/javascript" src="number_to_text.js" ></script>`  
usage:  
`1. convertToGeorgian(5);`  
`2. convertToGeorgian("1256");`  
returns:  
`1.ხუთი`  
`2. ათას ორასორმოცდათექვსმეტი`  


[example](http://bumbeishvili.github.io/code-snippets/NumberToGeorgian/)

---

### `converter.js`  
 <a id="converter.js"></a> 
desc:  
`converts word from latin encoding to georgian (end reverse)`  
include:  
`<script type="text/javascript" src="converter.js" ></script>`  
usage:  
```javascript
var c = new EncodingConverter()

c.toLatin('აბგდევზთიკლმნოპჟრსტუფქღყშცძწჭხჯჰ')
c.toGeorgian('abgdevzTiklmnopJrstufqryScZcwWxjh')
```

returns:  
`1. abgdevzTiklmnopJrstufqRyScZwWxjh`  
`2. აბგდევზთიკლმნოპჟრსტუფქრყშცძცწჭხჯჰ  `


[example](http://bumbeishvili.github.io/code-snippets/JSEncodingConverter/)

---


### `GeoGrammar.js`  
 <a id="GeoGrammar.js"></a> 
desc:  
`აბრუნებს საკუთარ სახელებს`  
include:  
`<script type="text/javascript" src="GeoGrammar.js" ></script>  `  
Invoking Examples  

    Grammar.Abrune.SakutariSaxeli.Saxelobitshi('დავითი'); 
    Grammar.Abrune.SakutariSaxeli.Motxrobitshi('გიორგი');
    Grammar.Abrune.SakutariSaxeli.Micemitshi('ქეთევანი')
    Grammar.Abrune.SakutariSaxeli.Natesaobitshi('თამარ');
    Grammar.Abrune.SakutariSaxeli.Moqmedebitshi('ლალი');
    Grammar.Abrune.SakutariSaxeli.Vitarebitshi('ნინიკო');
    Grammar.Abrune.SakutariSaxeli.Wodebitshi('დავითი');

  Results  

    დავითი
    გიორგიმ
    ქეთევანს
    თამარის
    ლალითი
    ნინიკოდ
    დავით

[example](http://bumbeishvili.github.io/code-snippets/GeoGrammar/)


---
