using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvitoBot
{
	public partial class MainForm : Form
	{
		object _lockAction = new object();
		bool _isCompleted = false;


		public MainForm()
		{
			InitializeComponent();

			webBrowser1.ProgressChanged += new WebBrowserProgressChangedEventHandler(webBrowser1_ProgressChanged);
			webBrowser1.ScriptErrorsSuppressed = true;

			// Установка уровня режима совместимости WebBrowser на 11
			SetWebBrowserCompatiblityLevel();
		}

		#region ИЗМЕНЕНИЕ РЕЖИМА СОВМЕСТИМОСТИ WebBrowser
		// MAGIC
		//http://www.cyberforum.ru/windows-forms/thread1637948.html#post8616074
		//https://blogs.msdn.microsoft.com/patricka/2015/01/12/controlling-webbrowser-control-compatibility/
		//Элемент управления WebBrowser по умолчанию работает в режиме совместимости с IE7. Чтобы переключить его на более новые версии необходимо создать ключ в реестре по пути
		//HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION
		// или HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION

		private static void SetWebBrowserCompatiblityLevel()
		{
			string appName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
			int lvl = 1000 * GetBrowserVersion();
			bool fixVShost = File.Exists(Path.ChangeExtension(Application.ExecutablePath, ".vshost.exe"));

			WriteCompatiblityLevel("HKEY_LOCAL_MACHINE", appName + ".exe", lvl);
			if (fixVShost) WriteCompatiblityLevel("HKEY_LOCAL_MACHINE", appName + ".vshost.exe", lvl);

			WriteCompatiblityLevel("HKEY_CURRENT_USER", appName + ".exe", lvl);
			if (fixVShost) WriteCompatiblityLevel("HKEY_CURRENT_USER", appName + ".vshost.exe", lvl);
		}

		private static void WriteCompatiblityLevel(string root, string appName, int lvl)
		{
			try
			{
				Microsoft.Win32.Registry.SetValue(root + @"\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", appName, lvl);
			}
			catch (Exception)
			{
			}
		}

		public static int GetBrowserVersion()
		{
			string strKeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer";
			string[] ls = new string[] { "svcVersion", "svcUpdateVersion", "Version", "W2kVersion" };

			int maxVer = 0;
			for (int i = 0; i < ls.Length; ++i)
			{
				object objVal = Microsoft.Win32.Registry.GetValue(strKeyPath, ls[i], "0");
				string strVal = Convert.ToString(objVal);
				if (strVal != null)
				{
					int iPos = strVal.IndexOf('.');
					if (iPos > 0)
						strVal = strVal.Substring(0, iPos);

					int res = 0;
					if (int.TryParse(strVal, out res))
						maxVer = Math.Max(maxVer, res);
				}
			}

			return maxVer;
		}
		#endregion

		#region PRIVATE METHODS

		// метод перехода на заданный url
		private void _navigate(string url)
		{
			lock (_lockAction)
			{
				webBrowser1.Navigate(url);

				_isCompleted = false;
				while (_isCompleted == false) Application.DoEvents();

			}
		}

		// получение html элемента поля логина
		private HtmlElement _getLoginEl()
		{
			HtmlElement res = null;

			foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("input"))
			{
				if (el.GetAttribute("className") == "login-form-input login-form-input_placeholder-focus-visible")
				{
					res = el;
					break;
				}
			}


			return res;
		}

		// получение html элемента поля пароля
		private HtmlElement _getPasswordEl()
		{
			HtmlElement res = null;

			foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("input"))
			{
				if (el.GetAttribute("className") == "form-password-input login-form-input")
				{
					res = el;
					break;
				}
			}


			return res;
		}

		// получение html элмента кнопки входа
		private HtmlElement _getLoginButtonEl()
		{
			HtmlElement res = null;

			foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("button"))
			{
				if (el.GetAttribute("className") == "button button-origin button-origin-yellow login-form-submit")
				{
					res = el;
					break;
				}
			}


			return res;
		}

		#endregion
		
		#region PUBLIC METHODS
		////////////////////////////
		// обработчик события завершения обновления страницы
		private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
		{
			if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
				_isCompleted = true;
		}
			
		// обработчик кнопки заполнения логина пароля
		private void buttonFill_Click(object sender, EventArgs e)
		{
			// получение html элементов
			HtmlElement loginEl = _getLoginEl();
			HtmlElement passwordEl = _getPasswordEl();

			// заполнение полей
			loginEl.SetAttribute("value", textBoxLogin.Text);
			passwordEl.SetAttribute("value", textBoxPassword.Text);
			
		}

		// обрабтчик нажатия кнопки входа
		private void buttonLogin_Click(object sender, EventArgs e)
		{
			// получение html элементов
			HtmlElement loginButtonEl = _getLoginButtonEl();

			// выполнение авторизации

			_isCompleted = false;

			lock (_lockAction)
			{
				loginButtonEl.InvokeMember("Click");

				while (_isCompleted == false) Application.DoEvents();
			}
			
		}

		// обработчик кнопки перехода на главную страницу Авито
		private void buttonNavigateToAvito_Click(object sender, EventArgs e)
		{
			string avitoUrl = @"https://www.avito.ru";

			_navigate(avitoUrl);
		}

		// обработчик кнопки перехода на станицу авторизации Авито
		private void buttonNavigateToLoginForm_Click(object sender, EventArgs e)
		{
			string loginFormUrl = @"https://www.avito.ru/profile/login";

			_navigate(loginFormUrl);
		}

		#endregion
	}
}
