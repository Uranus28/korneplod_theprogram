using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Numerics;
using System.Linq.Expressions;

namespace Interface
{
    
    public partial class MainForm : Form
    {
        public static string l = "e";//сейчас включен english = e; russian = r ; chinese = c
        public static Txts texts=null;//отвечает за мультиязычность
        public static LongDouble a;
       public static int accu=0;
        public static Complex b;
        public static bool t_arif = true;
        public static bool t_num = true;
        public class Txts//класс для десериализации
        {
            public string LanguageToolStripMenuItem { get; set; }
            public string russianToolStripMenuItem { get; set; }
            public string englishToolStripMenuItem { get; set; }
            public string chineseToolStripMenuItem { get; set; }
            public string enternumber { get; set; }
            public string answer { get; set; }
            public string AboutToolStripMenuItem { get; set; }
            public string modes { get; set; }
            public string arifmetical_b { get; set; }
            public string analitical_b { get; set; }
            public string sqrt_button { get; set; }
            public string Accuracy { get; set; }
            public string img_num { get; set; }
            public string cnum_r { get; set; }
            public string num_r { get; set; }
            public string c_modes { get; set; }
            public string exception1 { get; set; }
            public string exception2 { get; set; }
            public string exception3 { get; set; }
        }
        public MainForm()
        {
            InitializeComponent();
            output_textBox.ReadOnly= true;
            LoadJson("en.json");
        }
        
        private void языкToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void output_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Accuracy_Scroll(object sender, EventArgs e)//изменение ползунка точности
        {
            if (texts != null)
            {                
                accuracy_label.Text = texts.Accuracy+": " + Accuracy.Value.ToString();
            }
            else
            {
                accuracy_label.Text = "Accuracy: " + Accuracy.Value.ToString();
            }
            accu = Accuracy.Value;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)//справка о программе
        {
            if (l == "e")
            {
                AboutBox1 frmAbout = new AboutBox1();
                frmAbout.ShowDialog();
            }
            else if (l == "r")
            {
                AboutBox frmAbout = new AboutBox();
                frmAbout.ShowDialog();
            }
            else if (l == "c")
            {
                AboutBox2 frmAbout = new AboutBox2();
                frmAbout.ShowDialog();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void num_r_CheckedChanged(object sender, EventArgs e)//переключение ввода чисел
        {
            if (t_num)
            {
                t_num = false;
                inputim_textBox.Visible = true;
                img_num.Visible = true;
            }
            else
            {
                t_num = true;
                inputim_textBox.Visible = false;
                img_num.Visible = false;
            }
        }
        private void arifmetical_b_CheckedChanged(object sender, EventArgs e)//переключение режима калькулятора
        {
            if (t_arif)
                t_arif = false;
            else
                t_arif = true;
        }
    
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void LoadJson(string fs)//хагрузка JSON Файлов
        {
            using (StreamReader file = File.OpenText(fs))
            {
                JsonSerializer serializer = new JsonSerializer();
                texts = (Txts)serializer.Deserialize(file, typeof(Txts));
            }

            LanguageToolStripMenuItem.Text = texts.LanguageToolStripMenuItem;
            AboutToolStripMenuItem.Text = texts.AboutToolStripMenuItem;
            modes.Text = texts.modes;
            arifmetical_b.Text = texts.arifmetical_b;
            analitical_b.Text = texts.analitical_b;
            sqrt_button.Text = texts.sqrt_button;
            accuracy_label.Text = texts.Accuracy + ": " + Accuracy.Value.ToString(); ;
            russianToolStripMenuItem.Text = texts.russianToolStripMenuItem;
            englishToolStripMenuItem.Text = texts.englishToolStripMenuItem;
            chineseToolStripMenuItem.Text = texts.chineseToolStripMenuItem;
            enternumber.Text = texts.enternumber;
            answer.Text = texts.answer;
            img_num.Text = texts.img_num;
            cnum_r.Text = texts.cnum_r;
            num_r.Text = texts.num_r;
            c_modes.Text = texts.c_modes;
    }
        /////переключение языков
        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l != "r")
            {
                LoadJson("ru.json");
                l = "r";
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l != "e")
            {
                LoadJson("en.json");
                l = "e";
            }
        }

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l != "c")
            {
                LoadJson("ch.json");
                l = "c";
            }
        }
        {
            for (int i = 0; i < input_textBox.Text.Length; i++)
            {
                
                if ("0123456789".IndexOf(input_textBox.Text[i])==-1)
                {
                    
                    if (input_textBox.Text[i] != '.')
                    {
                        //MessageBox.Show(Convert.ToString(input_textBox.Text[i]));
                        if (input_textBox.Text[i] != '-')
                            input_textBox.Text = input_textBox.Text.Replace(Convert.ToString(input_textBox.Text[i]), "");
                        
                    }
                }
            }
            for (int i = 0; i < inputim_textBox.Text.Length; i++)
            {
                if (inputim_textBox.Text[i] < '0' || inputim_textBox.Text[i] > '9')
                {
                    if (inputim_textBox.Text[i] != '.')
                    {
                        if(inputim_textBox.Text[i] != '-')
                            inputim_textBox.Text = inputim_textBox.Text.Replace(Convert.ToString(inputim_textBox.Text[i]), "");
                    }
                }
            }
           
        }
        private void input_textBox_TextChanged(object sender, EventArgs e)
        {
            chist();
        }

        private void inputim_textBox_TextChanged(object sender, EventArgs e)
        {
            chist();
        }

        private void sqrt_button_Click(object sender, EventArgs e)//вычисление корня
        {
            try
            {
                string s = "";
                if (input_textBox.Text.IndexOf('.') == input_textBox.Text.Length - 1)
                    MessageBox.Show(texts.exception1);
                else
                {
                    if (inputim_textBox.Text.IndexOf('.') == input_textBox.Text.Length - 1)
                        MessageBox.Show(texts.exception1);
                    else
                    {
                        bool is_right = false;//проверка на правильное составление числа
                        if (t_num)
                        {
                            a = new LongDouble(input_textBox.Text);
                            
                            is_right = true;
                        }
                        else
                        {
                                double b_d;
                                double a_d;
                                string a_s = input_textBox.Text;
                                string b_s = inputim_textBox.Text;
                            
                                if (b_s == "")
                                {
                                    b_s = "0";
                                }
                           
                            if (a_s == "")
                                {
                                    a_s = "0";
                                }
                            
                            a_d = Convert.ToDouble(a_s.Replace(".",",")); //реальная
                            b_d = Convert.ToDouble(b_s.Replace(".", ",")); //мнимая
                            b = new Complex(a_d, b_d);
                                is_right = true;

                        }
                        if (arifmetical_b.Checked)//арифметический корень
                        {
                            if (!t_num)
                            {
                                if (is_right)
                                {
                                    var tup = b.sqrt();
                                    s = tup.Item1.ToString() + "  ;   " + tup.Item2.ToString();
                                }
                            }
                            else
                            {
                                if (is_right)
                                {

                                    s = a.sqrt(Accuracy.Value).ToString();
                                    if (s.IndexOf('.' )!= -1){
                                        s=s.Substring(0, s.IndexOf('.') + Accuracy.Value + 1);
                                        if (s[s.Length - 1] == '.')
                                        {
                                            s=s.Substring(0, s.Length - 1);
                                        }
                                    }
                                    
                                }
                            }
                        }
                        else//аналитический корень
                        {
                            if (!t_num)
                            {
                                if (is_right)
                                {
                                    var tup = b.sqrt();
                                    s = tup.Item1.ToString() + "  ;   " + tup.Item2.ToString();
                                }
                            }
                            else
                            {
                                if (is_right)
                                {
                                    s = a.analytical_sqrt().ToString();
                                }

                            }
                        }
                    }
                }
                output_textBox.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        ////////методы///////////////////////////////////////////////////////////////////



       public class LongDouble
        {
            public int sign; // знак числа
            public List<int> digits; // вектор цифр
            public int exponent; // экспонента для свдига
            private int divDigits = 29;

            public LongDouble()
            { // конструктор по-умолчанию
                sign = 1;
                digits = new List<int>() { 0 };
                exponent = 1;
            }
            public LongDouble(LongDouble x)
            { // конструктор копирования
                sign = x.sign;
                exponent = x.exponent;
                digits = new List<int>(x.digits);
            }
            private void init_str(string value)
            {
                if (value[0] == '.' || value[value.Length - 1] == '.')
                    throw new Exception(texts.exception1);
                bool was_dot = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '.' && was_dot)
                        throw new Exception(texts.exception1);
                    if (value[i] == '.')
                        continue;
                    if (value[i] >= '0' && value[i] <= '9')
                        continue;
                    throw new Exception(texts.exception1);
                }
                int index;
                digits = new List<int>() { };
                // если первый символ строки - минус, значит число отрицательное
                if (value[0] == '-')
                {
                    sign = -1; // знак отрицательного числа -1
                    index = 1; // начинать идти нужно будет с первого символа
                }
                else
                {
                    sign = 1; // иначе число положительное
                    index = 0; // и идти нужно будет с нулевого символа 
                }

                exponent = value.Length - index; // предполагаем, что всё число будет целым, а значит и экспонента будет равна длине строки

                // идём по всей строке
                while (index < value.Length)
                {
                    if (value[index] == '.')  // если встретили точку
                        exponent = sign == 1 ? index : index - 1; // запоминаем экспоненту, так как целая часть закончилась
                    else
                        digits.Add(value[index] - '0'); // иначе вставляем в вектор очередную цифру

                    index++; // переходим к новому символу
                }
                if (sign == -1)
                {
                    throw new Exception(texts.exception1);
                }
            }
            public LongDouble(string value)
            { // конструктор из строки
                init_str(value);
            }
            public LongDouble(string value, int precision)
            {
                init_str(value);
                divDigits = precision;
            }
            public void removeZeroes()
            {
                int n = 1; // определяем, до какого момента нужно будет идти для удаления нулей справа
                if (exponent > 1)
                    n = exponent;
                // пока справа нули
                while (digits.Count > n && digits[digits.Count - 1] == 0)
                    digits.RemoveAt(digits.Count - 1); // удаляем их

                // пока число цифр больше одной и вектор начинается с нуля
                while (digits.Count > 1 && digits[0] == 0)
                {
                    digits.RemoveAt(0); // удаляем нули из начала вектора
                    exponent--; // и уменьшаем экспоненту
                }

                // если справа всё ещё остались нули
                while (digits.Count > 1 && digits[digits.Count - 1] == 0)
                    digits.RemoveAt(digits.Count - 1); // то удалим их

                // если в результате осталась всего одна нулевая цифра, то превратим её в честный ноль
                if (digits.Count == 1 && digits[0] == 0)
                {
                    exponent = 1;
                    sign = 1;
                }
            }
            public override string ToString()
            {
                string result = "";
                if (sign == -1)
                    result += "-"; // если число отрицательное, то сначала выведем знак минус

                // если экспонента положительна, то у числа ненулевая целая часть
                if (exponent > 0)
                {
                    int i = 0;
                    int e = exponent;

                    // выводим первые exponent цифр (или все цифры, если экспонента больше) числа чтобы вывести целую часть
                    while (i < digits.Count && i < e)
                    {
                        result += digits[i].ToString();
                        i++;
                    }

                    // если экспонента больше цифр числа, то выводим нули, чтобы дойти до экспоненты
                    while (i < e)
                    {
                        result += "0";
                        i++;
                    }

                    // если цифры ещё остались
                    if (i < digits.Count)
                    {
                        result += "."; // то выводим точку

                        // и выводим оставшиеся цифры как дробную часть
                        while (i < digits.Count)
                            result += digits[i++].ToString();
                    }
                }
                else
                { // иначе эспонента отрицательна или нулевая
                    result += "0."; // выводим нулевую целую часть с точкой

                    // выводим |exponent| нулей (если экспонента нулевая, то не будет ни одного нуля)
                    for (int i = 0; i < -exponent; i++)
                        result += "0";

                    // выводим все цифры числа
                    for (int i = 0; i < digits.Count; i++)
                        result += digits[i].ToString();
                }

                return result;
            }
            public static LongDouble operator *(LongDouble t1, LongDouble t2)
            {
                int len = t1.digits.Count + t2.digits.Count; // максимальная длина нового числа не больше суммы длин перемножаемых чисел

                LongDouble res = new LongDouble(); // создадим объект для результата

                res.sign = t1.sign * t2.sign; // перемножаем знаки
                res.digits = new List<int>(); // создаём вектор из нулей
                for (int i = 0; i < len; i++)
                    res.digits.Add(0);
                res.exponent = t1.exponent + t2.exponent; // складываем экспоненты

                // умножаем числа в столбик
                for (int i = 0; i < t1.digits.Count; i++)
                    for (int j = 0; j < t2.digits.Count; j++)
                        res.digits[i + j + 1] += t1.digits[i] * t2.digits[j]; // прибавляем результат произведения цифр из i-го и j-го разрядов

                // в результате такого перемножения в ячейках могли получиться двузначные числа, поэтому нужно выполнить переносы
                for (int i = len - 1; i > 0; i--)
                {
                    res.digits[i - 1] += res.digits[i] / 10; // добавляем к более старшему разряду десятки текущего разряда
                    res.digits[i] %= 10; // оставляем только единицы у текущего разряда
                }

                res.removeZeroes(); // удаляем нули, как в конструкторе из строки, если таковые имеются

                return res; // возвращаем результат умножения двух чисел
            }
            public static LongDouble operator -(LongDouble x)
            {
                LongDouble res = new LongDouble(); // создаём число
                res.sign = -x.sign; // меняем знак на противоположный
                res.exponent = x.exponent; // копируем экспоненту
                res.digits = new List<int>(x.digits); // копируем цифры

                return res; // возвращаем результат
            }
            public static LongDouble operator +(LongDouble t1, LongDouble t2)
            {
                if (t1.sign == t2.sign)
                {
                    int exp1 = t1.exponent;
                    int exp2 = t2.exponent;
                    int exp = exp1;
                    if (exp2 > exp)
                        exp = exp2;
                    List<int> d1 = new List<int>(t1.digits);
                    List<int> d2 = new List<int>(t2.digits);
                    while (exp1 != exp)
                    {
                        d1.Insert(0, 0); // добавляя нули в начало первого
                        exp1++;
                    }
                    while (exp2 != exp)
                    {
                        d2.Insert(0, 0); // и в начало второго векторов
                        exp2++;
                    }
                    int size = d1.Count;
                    if (d2.Count > size)
                        size = d2.Count;
                    // выравниваем размеры векторов, добавляя нули в конец каждого из них
                    while (d1.Count != size)
                        d1.Add(0);

                    while (d2.Count != size)
                        d2.Add(0);

                    int len = 1 + size;

                    LongDouble res = new LongDouble(); // создаём новое число

                    res.sign = t1.sign; // знак результата совпадает со знаком чисел
                    res.digits = new List<int>() { }; // создаём вектор из len нулей
                    for (int i = 0; i < len; i++)
                        res.digits.Add(0);

                    // заполняем каждую ячейку вектора суммой двух соответствующих цифр
                    for (int i = 0; i < size; i++)
                        res.digits[i + 1] = d1[i] + d2[i];

                    // проверяем переполнения
                    for (int i = len - 1; i > 0; i--)
                    {
                        res.digits[i - 1] += res.digits[i] / 10; // прибавляем к более старшему разряду десятки текущего
                        res.digits[i] %= 10; // оставляем у текущего разряда только единицы
                    }

                    res.exponent = exp + 1; // восстанавливаем экспоненту
                    res.removeZeroes(); // убираем нули

                    return res; // возвращаем число
                }
                if (t1.sign == -1)
                {
                    return t2 - (-t1);
                }
                return t1 - (-t2);
            }
            public LongDouble inverse()
            {
                if (digits.Count == 1 && digits[0] == 0)
                    throw new Exception(texts.exception2); // делить на ноль нельзя, поэтому бросим исключение
                LongDouble x = new LongDouble(this); // скопируем число,
                x.sign = 1; // сделав его положительным

                LongDouble d = new LongDouble("1"); // создадим то, что будем делить на x

                LongDouble res = new LongDouble(); // создадит объект для результата
                res.sign = sign; // знак результата совпадёт со знаком числа
                res.exponent = 1; // начнём с единичной экспоненты
                res.digits = new List<int>() { }; // создадим пустой вектор для цифр обратного элемента
                LongDouble one = new LongDouble("1");
                // пока число меньше 1
                while (x < one)
                {
                    x.exponent++; // будем увеличивать его экспоненту (умножать на 10 фактически)
                    res.exponent++; // и заодно экспоненту результата
                }

                // дальше сдлеаем число d большим x, также умножая его на 10, чтобы получить число 100...0
                while (d < x)
                    d.exponent++;

                res.exponent -= d.exponent - 1; // подсчитаем реальное количество цифр в целой части

                int numbers = 0; // количество уже вычисленных цифр дробной части
                int cnt = 0;
                if (res.exponent > cnt)
                    cnt = res.exponent;
                int totalNumbers = divDigits + cnt; // количество цифр с учётом целой части
                LongDouble nol = new LongDouble("0");
                do
                {
                    int div = 0; // будущая цифра

                    // считаем, сколько раз нужно вычесть x из d
                    while (d >= x)
                    {
                        div++;
                        d = d - x;
                    }

                    // увеличиваем остаток в 10 раз
                    d.exponent++;
                    d.removeZeroes();
                    res.digits.Add(div); // записываем сформированную цифру
                    numbers++; // увеличиваем число вычисленных цифр
                } while (d != nol && numbers < totalNumbers); // считаем до тех пор, пока не дойдём до нулевого остатка или пока не превысим точность
                return res;
            }
            public static LongDouble operator /(LongDouble t1, LongDouble t2)
            {
                LongDouble res = t1 * t2.inverse();
                int help = 0;
                if (t1.exponent > help)
                    help = t1.exponent;
                int i = res.digits.Count - 1 - help;
                int n = 0;
                if (res.exponent > n)
                    n = res.exponent;
                // если в указанном месте девятка, то ищем место, в котором девятки закончатся
                if (i > n && res.digits[i] == 9)
                {
                    while (i > n && res.digits[i] == 9)
                        i--;

                    // если дошли до целой части
                    if (res.digits[i] == 9)
                    {
                        res.digits.RemoveRange(n, res.digits.Count - n); // то удаляем всю вещественную часть
                        res = res + new LongDouble(res.sign.ToString()); // и прибавляем 1 (или -1 к отрицательному) 
                    }
                    else
                    {
                        res.digits.RemoveRange(i + 1, res.digits.Count - (i + 1)); // иначе обрезаем с найденного места
                        res.digits[i]++; // и увеличиваем на 1 текущий разряд
                    }
                }

                return res; // возвращаем результат деления
            }
            public static LongDouble operator -(LongDouble t1, LongDouble t2)
            {
                if (t1.sign == 1 && t2.sign == 1)// если боа числа положительны
                {
                    bool cmp = t1 > t2; // получаем флаг того, больше ли первое число

                    int exp1 = cmp ? t1.exponent : t2.exponent; // сохраняем экспоненту большего числа
                    int exp2 = cmp ? t2.exponent : t1.exponent; // сохраняем экспоненту меньшего числа
                    int exp = exp1; // определяем максимальную экспоненту, чтобы к ней привести числа
                    if (exp2 > exp)
                        exp = exp1;

                    List<int> d1 = new List<int>(cmp ? t1.digits : t2.digits); // запоминаем вектор цифр большего числа
                    List<int> d2 = new List<int>(cmp ? t2.digits : t1.digits); // запоминаем вектор цифр меньшего числа

                    // выравниваем экспоненты как при сложении (добавляя нули вначале числа)
                    while (exp1 != exp)
                    {
                        d1.Insert(0, 0);
                        exp1++;
                    }

                    while (exp2 != exp)
                    {
                        d2.Insert(0, 0);
                        exp2++;
                    }

                    int size = d1.Count; // определяем максимальный размер
                    if (d2.Count > size)
                        size = d2.Count;
                    // добавляем нули в конец векторов цифр
                    while (d1.Count != size)
                        d1.Add(0);

                    while (d2.Count != size)
                        d2.Add(0);

                    int len = 1 + size;

                    LongDouble res = new LongDouble(); // создаём число для результата

                    res.sign = cmp ? 1 : -1; // знак будет 1, если первое больше второго, и -1, если первое меньше второго
                    res.digits = new List<int>() { }; // создаём вектор из len нулей
                    for (int i = 0; i < len; i++)
                        res.digits.Add(0);
                    for (int i = 0; i < size; i++)
                        res.digits[i + 1] = d1[i] - d2[i]; // вычитаем соответствующие разряды

                    // обрабатываем переполнения
                    for (int i = len - 1; i > 0; i--)
                    {
                        if (res.digits[i] < 0)
                        { // если текущий разряд стал меньше нуля
                            res.digits[i] += 10; // занимаем у предыдущего, прибавляя 10 к текущему
                            res.digits[i - 1]--; // уменьшаем на 1 предыдущий разряд
                        }
                    }

                    res.exponent = exp + 1; // восстанавливаем экспоненту
                    res.removeZeroes(); // удаляем лишнии нули

                    return res; // возвращаем результат
                }

                if (t1.sign == -1 && t2.sign == -1)  // если оба числа отрицательны, то из второго с обратным знаком вычитаем первое с обратным знаком
                    return (-t2) - (-t1);
                return t1 + (-t2); // если знаки разные, прибавляем к первому отрицательное второе
            }
            public static bool operator ==(LongDouble t1, LongDouble t2)
            {
                if (t1.sign != t2.sign)
                    return false;

                if (t1.exponent != t2.exponent)
                    return false;

                if (t1.digits.Count != t2.digits.Count)
                    return false;

                for (int i = 0; i < t1.digits.Count; i++)
                    if (t1.digits[i] != t2.digits[i])
                        return false;

                return true;
            }
            public static bool operator >(LongDouble t1, LongDouble t2)
            {
                if (t1.sign != t2.sign)
                    return t1.sign > t2.sign; // если знаки разные, то положительное число больше

                if (t1.exponent != t2.exponent)
                    return (t1.exponent > t2.exponent) ^ (t1.sign == -1); // если экспоненты разные, то больше число с большей экспонентой с учётом знака

                // копируем вектора
                List<int> d1 = new List<int>(t1.digits);
                List<int> d2 = new List<int>(t2.digits);
                int size = d1.Count; // определяем максимальный размер векторов
                if (d2.Count > size)
                    size = d2.Count;

                // выравниваем размеры векторов, добавляя в концы нули
                while (d1.Count != size)
                    d1.Add(0);

                while (d2.Count != size)
                    d2.Add(0);

                // проходим по всем цифрам числа
                for (int i = 0; i < size; i++)
                    if (d1[i] != d2[i])
                        return (d1[i] > d2[i]) ^ (t1.sign == -1); // если в каком-то разряде цифры разные, то больше число с большей цифрой с учётом знака

                return false; // иначе числа равны, а значит не больше
            }
            public static bool operator <(LongDouble t1, LongDouble t2)
            {
                
                return !(t1 > t2 || t1 == t2);
            }

            public static bool operator >=(LongDouble t1, LongDouble t2)
            {

                return (t1 > t2 || t1 == t2);
            }

            public static bool operator <=(LongDouble t1, LongDouble t2)
            {
                return t1 < t2 || t1 == t2;
            }

            public static bool operator !=(LongDouble t1, LongDouble t2)
            {
                return !(t1 == t2);
            }
            public LongDouble sqrt(int precision)
            {
                LongDouble x = new LongDouble("1", divDigits);
                LongDouble two = new LongDouble("2", divDigits);
                for (; ; )
                {
                    LongDouble nx = (x + this / x) / two;
                    LongDouble diff;
                    if (x > nx)
                        diff = x - nx;
                    else
                        diff = nx - x;
                    string go = diff.ToString();
                    bool ok = true;
                    if (diff >= new LongDouble("1")) ok = false;
                    for (int i = 0; i < go.Length; i++)
                    {
                        if (go[i] == '.')
                        {
                            for (int j = i + 1; j < go.Length && j < i + precision + 1; j++)
                            {
                                if (go[j] != '0')
                                {
                                    ok = false;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    if (ok)
                        break;
                    x = nx;
                }
                return x;
            }

            public string analytical_sqrt()
            {
                BigInteger r;
                if (!BigInteger.TryParse(this.ToString(), out r))
                {
                    
                    throw new Exception(texts.exception3+$"{ this.ToString()}");
                }
                if (r < 1)
                    return r.ToString();
                BigInteger l = new BigInteger(1);

                for (Int64 i = 2; i < Int64.Parse("10000000"); i++)
                {
                    if (r == 1)
                        break;
                    while (r % (new BigInteger(i * i)) == 0)
                    {
                        l *= i;
                        r /= i * i;
                    }
                }
                if (r == 1)
                    return l.ToString();
                if (l == 1)
                    return $"sqrt({r.ToString()})";
                return $"{l.ToString()} * sqrt({r.ToString()})";
            }
        }

        public class Complex
        {
            public double re, im;
            public Complex(double re, double im)
            {
                this.re = re;
                this.im = im;
            }
            public Tuple<Complex, Complex> sqrt()
            {
                double z = Math.Sqrt(re * re + im * im);
                double fi = Math.Atan(im / re);
                if (re < 0 && im < 0)
                    fi -= Math.PI;
                else if (re < 0)
                    fi += Math.PI;

                double k1_re = Math.Sqrt(z) * (Math.Cos(fi / 2.0));
                double k1_im = Math.Sqrt(z) * (Math.Sin(fi / 2.0));

                double k2_re = -Math.Sqrt(z) * (Math.Cos(fi / 2.0));
                double k2_im = -Math.Sqrt(z) * (Math.Sin(fi / 2.0));
                return Tuple.Create(new Complex(k1_re, k1_im), new Complex(k2_re, k2_im));
            }

            public override string ToString()
            {
                string res = "";
                res += re.ToString("F"+accu);
                if (im >= 0)
                {
                    res += "+";
                    res += im.ToString("F" + accu) + "*i";
                }
                else
                {
                    res += im.ToString("F" + accu) + "*i";
                }
                return res;
            }
        }

        
    }
}
