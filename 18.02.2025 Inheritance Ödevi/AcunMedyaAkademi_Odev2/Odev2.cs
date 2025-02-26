/* ----------------Abstract Classlar---------------------------------------
 * Abstract classlar týpký ilk ödevdeki audi mercedes togg gibi classlardýr
 * içi boþ diðer classlardan kalýtým alýrlar
 * program çalýþýrken override yapmak zorunda kalýr yani 
 * audi classýnda nesne oluþturup marka tanýmlarsam þu sýrayla gider:
 * main program önce audi classýna gider ordanda kalýtým aldýðý araba classýna gider (yani temel araba özelliklerinin olduðu)
 * ve aracý tanýmlar.
 * -------------------------------------------------------------------------
 *
 * 
 * /* ----------------Abstraction-------------------------------------------
 * Abstraction yani soyutlama bir programda gereksiz detaylarý gizleyerek sadece önemli özellikleri ve davranýþlarý sunma prensibidir.
 * mesela bir dikdörtgenin alanýný hesaplayan bir program yazdýðýmýzý düþünelim.
 * kullanýcýdan sadece en ve boy bilgilerini alýp sonucu gösteririz.
 * kullanýcý arka planda yapýlan iþlemleri görmez
 * birnevi "Araba sürmek için arabanýn bütün parçalarýnýn ne iþe yaradýðýný öðrenmemize gerek yoktur." Gibi düþünebiliriz kullanýcý tarafýnda.
 * -------------------------------------------------------------------------
 * 
 *
 * -----------------Polymorphism--------------------------------------------
 * Bir Metodun türetilmiþ altsýnýflar tarafýndan kullanýlabilmesi özelliðine denir.
 * bir sýnýfýn veya metodun birden fazla farklý þekilde davranabilmesini ifade eder. 
 * Genellikle override ve virtual metodlarla saðlanýr.
 * mesela araba adýnda bir classýmýz olsun ve içinde "public virutal void Araclýstýr()" kodumuz olsun
 * bu kodun çýktýsý arac calýstýrýldý olsun
 * daha sonrasýnda motor ve araba adýnda 2 tane classýmýz daha olsun ve bu classlardada su kodlar olsun
 * public override void Araccalýstýr() -->Araba ("Araba Calýstýrýldý")
 * publýc override voýd Araccalýstýr() -->Motor ("Motor Calýstýrýldý")
 * artýk biz bu override classlarýnda yazdýrmak istediðimiz mesajlarý yazdýrabiliriz.
 * -------------------------------------------------------------------------