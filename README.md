



# SİMPRA_HOMEWORK4

## Projeyi çalıştırmak için:
1. SimpraHomewroks.Apı -> appsettings.json -> MsSQL tanımlamasındaki ‘Server’ bilgisini kendiMsSQL server adı ile değiştiriniz. 
2. Package Manager Console -> Default Project -> SimpraHomework.Repository seçilir. 
3. Add-migration v1.1 veya EntityFramework6\Add-Migration initial komutu girilerek migration oluşturulur. 
4. Update-database komutu ile MsSQL’de ‘SimraHomework4Db’ ve tablolar oluşturulur.



## Proje Hedefleri:
0.Projede eksik olarak birakilan DapperRepository class in implemantasyonunu tamamlandı.
1. Projede eksik olarak birakilan DapperRepository class in implemantasyonunu tamamlandı.
2. Category modeli icin dapper servis hazirlandı . Bu servis Dynamic Dapper repository ile calisacak hale getirildi. 
3. Bu servis icin standart bir controller implement edildi.  (GetAll,GetById,Insert,Update,Delete)
4. Projede kullanilan tum DI islemlerini autofac ile olacak sekilde degistirildi. 
5. TransactionReportController dapper yerine EF ile calisacak sekilde guncellendi. 
