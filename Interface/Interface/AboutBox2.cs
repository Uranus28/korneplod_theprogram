using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    partial class AboutBox2 : Form
    {
        public AboutBox2()
        {
            InitializeComponent();
            this.Text = String.Format("关于程序 {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("应用程序版本 {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = "这个程序计算数字的根。 支持从零开始计算长数，复数和数字。\r\n" +
                "实现了计算根的两种模式，算术和分析，也可以改变计算数的准确性。\r\n" +
                "该计划支持三种语言英语，中文和俄语。\r\n\r\n\r\n\r\n" +
                "功能描述:\r\n" +
                " -\"语言\"按钮：更改语言\r\n" +
                " -\"关于程序\"按钮：查看有关程序的信息\r\n" +
                " -精度滑块：在响应中设置小数位\r\n\r\n" +
                "使用步骤:\r\n" +
                "1）在使用它之前，您需要选择计算器模式:\r\n" +
                " -\"算术\"\r\n" +
                "-\"分析\"\r\n" + 
                "和数字输入模式:\r\n" +
                " -\"数字\"\r\n" +
                " -\"复数\"\r\n\r\n" +
                "2）接下来，您需要在\"输入字段\"中输入一个整数\r\n\r\n" +
                "3）点击\"查找根\"按钮";
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBox2_Load(object sender, EventArgs e)
        {

        }
    }
}
