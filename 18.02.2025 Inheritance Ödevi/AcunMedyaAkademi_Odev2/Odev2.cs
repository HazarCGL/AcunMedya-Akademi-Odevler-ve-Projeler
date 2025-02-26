/* ----------------Abstract Classlar---------------------------------------
 * Abstract classlar t�pk� ilk �devdeki audi mercedes togg gibi classlard�r
 * i�i bo� di�er classlardan kal�t�m al�rlar
 * program �al���rken override yapmak zorunda kal�r yani 
 * audi class�nda nesne olu�turup marka tan�mlarsam �u s�rayla gider:
 * main program �nce audi class�na gider ordanda kal�t�m ald��� araba class�na gider (yani temel araba �zelliklerinin oldu�u)
 * ve arac� tan�mlar.
 * -------------------------------------------------------------------------
 *
 * 
 * /* ----------------Abstraction-------------------------------------------
 * Abstraction yani soyutlama bir programda gereksiz detaylar� gizleyerek sadece �nemli �zellikleri ve davran��lar� sunma prensibidir.
 * mesela bir dikd�rtgenin alan�n� hesaplayan bir program yazd���m�z� d���nelim.
 * kullan�c�dan sadece en ve boy bilgilerini al�p sonucu g�steririz.
 * kullan�c� arka planda yap�lan i�lemleri g�rmez
 * birnevi "Araba s�rmek i�in araban�n b�t�n par�alar�n�n ne i�e yarad���n� ��renmemize gerek yoktur." Gibi d���nebiliriz kullan�c� taraf�nda.
 * -------------------------------------------------------------------------
 * 
 *
 * -----------------Polymorphism--------------------------------------------
 * Bir Metodun t�retilmi� alts�n�flar taraf�ndan kullan�labilmesi �zelli�ine denir.
 * bir s�n�f�n veya metodun birden fazla farkl� �ekilde davranabilmesini ifade eder. 
 * Genellikle override ve virtual metodlarla sa�lan�r.
 * mesela araba ad�nda bir class�m�z olsun ve i�inde "public virutal void Aracl�st�r()" kodumuz olsun
 * bu kodun ��kt�s� arac cal�st�r�ld� olsun
 * daha sonras�nda motor ve araba ad�nda 2 tane class�m�z daha olsun ve bu classlardada su kodlar olsun
 * public override void Araccal�st�r() -->Araba ("Araba Cal�st�r�ld�")
 * publ�c override vo�d Araccal�st�r() -->Motor ("Motor Cal�st�r�ld�")
 * art�k biz bu override classlar�nda yazd�rmak istedi�imiz mesajlar� yazd�rabiliriz.
 * -------------------------------------------------------------------------