# SCADA/MES Üretim Hattı Simülasyon Sistemi - Sistem Tasarımı

## 1. Proje Amacı
Bu proje, PLC, SCADA ve MES sistemlerinin birlikte çalışma mantığını öğrenmek amacıyla tasarlanmıştır. Gerçek bir üretim hattı simüle edilerek üretim verilerinin TCP/IP üzerinden aktarılması, izlenmesi, kayıt altına alınması ve analiz edilmesi hedeflenmektedir.

## 2. Sistem Mimarisi
Sensörler → PLC Simülatörü (Server) → TCP/IP Haberleşmesi → SCADA İstemcisi (Client) → MES Analiz Katmanı

PLC simülatörü üretim verilerini oluşturacak, SCADA uygulaması bu verileri gerçek zamanlı olarak görüntüleyecek ve MES katmanı üretim performans analizlerini gerçekleştirecektir.

## 3. Tags

| Tag Adı       | Veri Tipi | Açıklama             |
| ------------- | --------- | -------------------- |
| SystemState   | Integer   | Sistem durumu        |
| Temp          | Integer   | Sıcaklık             |
| Motor1        | Boolean   | Motor durumu         |
| ConveyorSpeed | Integer   | Konveyör hızı        |
| ProductCount  | Integer   | Üretilen ürün sayısı |
| RejectCount   | Integer   | Hatalı ürün sayısı   |
| Pressure      | Double    | Basınç değeri        |
| Humidity      | Integer   | Nem değeri           |
| AlarmState    | Boolean   | Alarm durumu         |

## 4. Sistem Durumları

| Değer | Durum       |
| ----- | ----------- |
| 0     | IDLE        |
| 1     | RUNNING     |
| 2     | WARNING     |
| 3     | ERROR       |
| 4     | MAINTENANCE |

IDLE:Sistem bekleme modundadır.
RUNNING:Üretim normal şekilde devam etmektedir.
WARNING:Sistem çalışmaktadır ancak dikkat gerektiren bir durum oluşmuştur.
ERROR:Üretim hattında hata meydana gelmiştir.
MAINTENANCE:Sistem bakım modundadır.

## 5. Haberleşme Paketi Tasarımı

SystemState;Temp;Motor1;ConveyorSpeed;ProductCount;RejectCount;Pressure;Humidity;AlarmState
Örnek veri: 1;36;1;120;245;3;5.2;45;0

## 6. SCADA Ekran Tasarımı

Sistem Bilgileri:
* Bağlantı Durumu
* Sistem Durumu
* Alarm Durumu

Üretim Bilgileri:
* Toplam Üretim Miktarı
* Hatalı Ürün Sayısı

Makine Bilgileri:
* Motor Durumu
* Konveyör Hızı

Çevresel Veriler:
* Sıcaklık
* Basınç
* Nem

Grafikler:
* Sıcaklık Grafiği
* Üretim Grafiği

Kayıtlar:
* Sistem Logları
* Alarm Kayıtları

## 7. MES Katmanında Hesaplanacak Veriler

* Toplam Üretim Miktarı
* Hatalı Ürün Sayısı
* Hatalı Ürün Oranı
* Üretim Verimliliği
* Alarm Sayısı
* Çalışma Süresi

Bu çalışma kapsamında SCADA/MES üretim hattı simülasyon projesinin temel mimarisi oluşturulmuş, kullanılacak veri yapıları belirlenmiş ve haberleşme protokolü tasarlanmıştır. Bir sonraki aşamada PLC simülatörü geliştirilerek sistemin gerçek zamanlı veri üretmesi sağlanacaktır.



