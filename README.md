# WCF Task 3

***

#### Создать WCF службу под условным названием Converter

Контракт службы должен быть создан в интерфейсе и содержать методы:

* `ConvertedUnits LinearMeasure(double meters)`;
* `ConvertedUnits CelsiusToFahrenheit(double c)`;
* `ConvertedUnits FahrenheitToCelsius(double f)`;

Первый метод конвертирует переданное значение в метрах в
дюймы, футы и ярды, два других метода преобразауют температура из шкалы Целься и в шкалу Фаренгейта и обратно. Особенность
этой службы – класс ConvertedUnits.

Он может иметь такой вид и является контейнером для пересылки конвертированных значений.

***
```C#
Class ConvertedUnits
{
public double inch;
public double foot;
public double yard;
public double Celsius;
public double Fahrenheit;
}
```
Каждый из методов службы заполняет в этом классе только свои
поля. Например, метод *LinearMeasure()*, получив значение в метрах,
переведет его в дюймы, футы и ярды и запишет в первые три свойства. Температурные свойства этот метод не трогает. Аналогично,
два других метода не трогают линейные свойства этого класса. Может сконструировать класс другим способом. Лишь бы он передавал
все данные.

Задайте адрес конечной точки и привязку службы в конфигурационном файле. Также опишите в конфигурационном файле mex
точку. Клиент должен быть WinForms или WPF приложением. На
стороне клиента создайте прокси-класс. Прокси-класс создается командой «Добавить ссылку на службу». Создайте приятный интерфейс для ввода значений для конвертации и для вывода полученных
от службы результатов в окне клиентского приложения.
