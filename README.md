# korneplod_theprogram
 <h2>  Приложение для вычисления квадратного корня </h2>
 <h2>   «victorКОРНЕплод»</h2>
 
Документация по разработанному приложения, предназначенному для поиска квадратного корня, заданного числа, вплоть до 28 знаков после запятой. Результат может быть представлен арифметически и аналитически.
Ключевые слова: квадратный корень, полиязычность, пользовательский интерфейс, комплексные корни, аналитический результат, арифметический результат.

<h2> Quadratic Root Calculation Application </h2>
<h2>   «victorКОРНЕплод»</h2>
Documentation on a developed application designed to find the square root, of a given number, up to 28 decimal places. The result can be represented arithmetically and analytically.
Keywords: square root, multilingualism, user interface, complex roots, analytical result, arithmetic result.

<h2> 一个计算平方根的应用程序 </h2>
<h2>   «victorКОРНЕплод»</h2>
一个已开发的应用程序的文档，旨在寻找一个给定数字的平方根，最多到28位小数。其结果可以用算术和分析的方法来表示。
关键词：平方根，多语言，用户界面，复数根，分析结果，算术结果。

<h3>1.	ВВЕДЕНИЕ</h3>
Предлагаемая документация разработанного приложения, предназначенного для поиска квадратного корня заданного числа.
Рассматриваемая программа разработана на основе выданного заказчиком технического задания, которое также приведено ниже с незначительными изменениями.
Разработанное приложение состоит из:

-	Пользовательского интерфейса, позволяющие найти квадратный корень числа, вплоть до 28 знаков.
-	Перечень доступных языков.
-	Переключения режима (Арифметический/Аналитический).

 

<h3>2.	ТЕХНИЧЕОСКОЕ ЗАДАНИЕ ПОИСКА КВАДРАТНОГО КОРНЯ</h3>

Наименование разработки: «victorКОРНЕплод».

Алгоритм поиска квадратного корня работает с длинной арифметикой действительных чисел, используя метод Ньютона.

<h3>2.1	НАЗНАЧЕНИЕ РАЗРАБОТКИ</h3>
Приложение предназначено для поиска квадратного корня. Корни могут быть не только арифметические, но и могут быть получены из нуля, а также комплексные.
<h3>2.2	ТРЕБОВАНИЯ К ПРОДУКТУ</h3>
Разработка приложения выполняется с использованием компилятора Visual Studio 2022.

1)	Функциональность: 
Корни не только арифметические, из нуля, комплексные, длинные числа, заданная точность, аналитические.
Данное приложение позволяет получить ответ на все поставленные задачи. Если есть необходимость точного результата, тогда можно вывести результат вплоть до 28 знаков после запятой (исключение комплексные числа).

2)	Ошибкоустойчивость.

Должна быть предусмотрена защита от некорректного ввода данных. В таком случае, если пользователь некорректно ввел данные, тогда он получит соответствующее уведомление, и соответствующее поле будет очищено. При вводе отрицательного числа или строки, не являющейся числом, программа выводит уведомление о том, что введено неправильное число. То же самое происходит при попытке ввода дробного числа для поиска аналитического представления корня.

3)	GUI (с учетом управления точностью и полиязычности).

Windows Forms – интерфейс программирования, отвечающий за графический интерфейс пользователя и являющийся частью Microsoft .NET Framework. Данный интерфейс упрощает доступ к элементам интерфейса Microsoft Windows за счет создания обертки для существующего Win32 API в управляемом коде.
Точностью полученного результата контролируется при помощи TrackBar, который имеет диапазон значений от 0 до 28.
Полиязычность подробнее описана в 4-ом пункте.

4)	Полиязычность.

Полиязычность реализована следующим образом, каждый из доступных языков представлен в виде JSON-файла, который хранит ключевые предложения/слова, которые в свою очередь были представлены на WindowsForm (дизайне приложения). 
Переключение на другой язык реализовано так, что пользователь может поменять язык без необходимости «лезть» в код. Для этого реализована кнопка язык, позволяющая выбрать один из доступных языков, а именно русский, английский и китайский. 
5)	Кроссплатформенность

7)	Документация (с учетом полиязычности)

9)	Служба поддержки (если не телефонная горячая линия, то хотя бы форум) (с учетом полиязычности).

Возникли вопросы? У вас есть возможность связаться с нами по горячей линии. Номер оператора: 8-914-782-28-32.
<h3>3.	СЦЕНАРИИ ИСПОЛЬЗОВАНИЯ</h3>

3.1	Проведение проверок
Осуществлять проверки можно только тех значений, которые удовлетворяют техническим требованиям
Примеры возможных проверок и полученных результатов представлены в файле с тестами.

3.2	Локализация приложения
Приложение поддерживает несколько языков локализации, которую можно сменить в соответствующей разделе «Язык».  Добавление нового языка осуществляется при создании нового JSON-файла, в котором хранятся ключевой текст. Также есть необходимость добавить новое условие проверки

<h3>Пример JSON-файла.</h3>
{

"LanguageToolStripMenuItem": "Язык",

"englishToolStripMenuItem": "Английский",

"russianToolStripMenuItem": "Русский",

"chineseToolStripMenuItem": "Китайский",

"enternumber": "Введите число:",

"answer": "Ответ:",

"AboutToolStripMenuItem": "О программе",

"modes": "Режим калькултора",

"arifmetical_b": "Арифметический",

"analitical_b": "Аналитический",

"sqrt_button": "Найти корень",

"Accuracy": "Точность",

"img_num": "Введите мнимое число:",

"cnum_r": "Комплексное число",

"num_r": "Число",

"c_modes": "Режим вывода:",

"exception1": "Неверное число!",

"exception2": "LongDouble inverse() - деление на 0!",

"exception3": "Не могу найти аналитическое решение"

}

3.3	Вывод данных
Реализован как арифметический вывод, так и аналитический. Для переключения между режимами используются соответствующие radiobutton’ы.


<h3>4.	СТРУКТУРА ПРИЛОЖЕНИЯ.</h3>

-	Кнопка «Язык» предназначена для выбора языка. Из доступных это английский, русский, китайский. Для полиязычности был реализован метод LoadJson, который получает ключевой текст из соответствующего JSON-файла. Данный текст распределяется по определенным полям. 
-	Кнопка «О программе» предоставляет пользователю информацию о программе. Открывается новое окно, позволяющего получить пользователю информацию о приложении.
-	Ползунок/TrackBar «Точность» необходим для задания количества знаком после запятой в ответе.
-	сlass LongDouble предназначен для поиска квадратного корня исходного числа. В данном классе реализован ряд перегрузок, которые необходимы для нахождения верного ответа. 
-	сlass Complex позволяет найти комплексные корни числа. Также реализован выбор режима ввода данных. При выборе «Комплексное число» на интерфейсе отображается новый textbox, предназначенный для ввода мнимого числа. При выборе «Число» необходимо ввести число.

Для более подробного ознакомления с приложением необходимо обратиться к коду, в котором представлены подробные комментарии.
