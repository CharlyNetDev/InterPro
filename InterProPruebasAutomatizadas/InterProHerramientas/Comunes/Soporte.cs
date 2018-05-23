using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Remote;
using System.IO;

namespace InterProHerramientas.Comunes
{
    public class Soporte
    {

        private const string CADENA_ARCHIVO = "C:\\source\\InterPro\\InterProPruebasAutomatizadas\\InterProHerramientas\\comunes\\DatosPrueba.xlsx";

        public string PathArchivo ()
        {
            return CADENA_ARCHIVO;
        }

        public void TerminarProceso(IWebDriver driver/*, Document doc*/)
        {
            //doc.Close();
            //doc.Dispose();
            CerrarSesion(driver);
            driver.Close();
            driver.Dispose();
            driver.Quit();
        }
        public void CerrarSesion(IWebDriver driver)
        {

        }

        IList<IWebElement> lstDiasCalendario = null;

        public enum TimerSleepType
        {
            sleepTimerMinimum = 1500,
            sleepTimerFast = 2500,
            sleepTimerMedium = 3500,
            sleepTimerSlow = 5000,
            sleepTimerLoad = 6500
        };

        public void ObtenerEvidenciaCaso(IWebDriver driver, Document doc, string EncabezadoEvidencia, string casoPrueba)
        {
            Paragraph strTexto = new Paragraph(EncabezadoEvidencia.ToUpper());
            strTexto.Alignment = Element.ALIGN_JUSTIFIED;
            doc.Add(strTexto);
            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            //screenShot.SaveAsFile("imagenCaso" + casoPrueba + ".png", System.Drawing.Imaging.ImageFormat.Png);
            //Image foto = Image.GetInstance("imagenCaso" + casoPrueba + ".png");
            //foto.ScalePercent(30);
            //foto.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            //doc.Add(foto);
            //Loading(driver, (int)TimerSleepType.sleepTimerFast);
        }

        public void ActivaCheckRadios(IWebElement elementoWeb, string opcionSeleccion)
        {
            if (opcionSeleccion.Equals("Si"))
            {
                elementoWeb.Click();
                elementoWeb.Click();
            }
        }

        public void SeleccionaCombo2(IWebElement combo, string opcion)
        {
            SelectElement elementoCombo = new SelectElement(combo);

            elementoCombo.SelectByText(opcion);
        }

        //public void SeleccionaCombo(IWebElement combo, string opcion)
        //{
        //    IList<IWebElement> lstOptions = combo.FindElements(By.TagName("option"));
        //    IWebElement aux = null;

        //    foreach (IWebElement _element in lstOptions)
        //    {
        //        if (_element.Text.Contains(opcion))
        //        {
        //            aux = _element;

        //            break;
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }

        //    PulsarBoton(aux);
        //    Thread.Sleep((int)TimerSleepType.sleepTimerFast);
        //}

        public void SeleccionaCombo(IWebElement combo, int indexOption)
        {
            int items = combo.FindElements(By.TagName("option")).Count;
            IWebElement selectedOption = null;

            for (int i = 1; i <= items; ++i)
            {
                if (i == indexOption)
                {
                    selectedOption = combo.FindElement(By.XPath(".//option[" + indexOption + "]"));

                    break;
                }
            }

            PulsarBoton(selectedOption);
            Thread.Sleep((int)TimerSleepType.sleepTimerFast);
        }


        public void SeleccionaCombo(IWebElement combo, string opcion)

        {

            IList<IWebElement> lstOptions = combo.FindElements(By.TagName("option"));

            IWebElement aux = null;

            foreach (IWebElement _element in lstOptions)

            {

                if (_element.Text.Contains(opcion))

                {

                    aux = _element;

                    break;

                }

                else

                {

                    continue;

                }

            }

            PulsarBoton(aux);

            Thread.Sleep((int)TimerSleepType.sleepTimerFast);

        }


        public void SeleccionaCombo3(IWebElement combo, string opcion)
        {
            IList<IWebElement> optionInnerText = combo.FindElements(By.TagName("option"));
            SelectElement elementoCombo = new SelectElement(combo);

            foreach (IWebElement text in optionInnerText)
            {
                string textContent = combo.Text;
                if (textContent.Contains(opcion))
                {
                    elementoCombo.SelectByText(textContent);
                }


            }
        }

        public void PulsarBoton(IWebElement elemento)
        {
            elemento.Click();
        }

        public void ArchivoFileUploader(IWebDriver driver, IWebElement fileUploader, string fileName)
        {
            var allowsDetection = driver as IAllowsFileDetection;

            if (allowsDetection != null)
            {
                allowsDetection.FileDetector = new LocalFileDetector();
            }

            fileUploader.SendKeys(fileName);

            Loading(driver);
        }

        //public void PulsarBotonYObtenerEvidencia(IWebDriver driver, IWebElement boton, Document doc,
        //                                            string encabezado, string casoPrueba)
        //{
        //    PulsarBoton(boton);

        //    Loading(driver, (int)TimerSleepType.sleepTimerFast);

        //    ObtenerEvidenciaCaso(driver, doc, encabezado, casoPrueba);

        //    Loading(driver, (int)TimerSleepType.sleepTimerFast);
        //}

        public void LimpiarInput(IWebElement elemento)
        {
            elemento.Clear();
        }

        public void LimpiarYLLenarInput(IWebElement input, string texto)
        {
            LimpiarInput(input);
            input.SendKeys(texto);

            Thread.Sleep(1500);
        }


        public void CerrarDocumento(Document doc)
        {
            doc.Close();
            doc.Dispose();
        }



        public Document CrearReporte(/*string pathLogo, */Document doc, FileStream streaming, string numeroCaso)
        {
            Document documento = new Document();
            PdfWriter.GetInstance(documento, streaming);
            //Image logoEdenred = Image.GetInstance(pathLogo);
            Paragraph texto = new Paragraph(numeroCaso);

            documento.Open();
            documento.NewPage();
            //logoEdenred.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            //documento.Add(logoEdenred);
            documento.Add(new Paragraph(""));
            texto.Alignment = Element.ALIGN_LEFT;
            documento.Add(texto);

            return documento;
        }

        //public void Loading(IWebDriver driver, int timeMiliseconds)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeMiliseconds));
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(timeMiliseconds));
        //    Thread.Sleep(timeMiliseconds);
        //}

        public void Loading(IWebElement elemento)
        {
            while (!elemento.Displayed)
            {
                Thread.Sleep((int)TimerSleepType.sleepTimerFast);
            }
        }

        public void Loading(IWebDriver driver)
        {
            IWebElement backGroundProcess = driver.FindElement(By.Id("BackProcess"));
            //IWebElement backGroundProcessImage = driver.FindElement(By.Id("BackProcessImg"));

            while (backGroundProcess.Displayed)
            {
                Thread.Sleep((int)TimerSleepType.sleepTimerFast);
            }
        }

        public void ScrollTo(IWebDriver driver, int xPosition, int yPosition)
        {
            IJavaScriptExecutor je = driver as IJavaScriptExecutor;

            var js = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
            je.ExecuteScript(js);
        }

        public void ScrollTo(IWebDriver driver, IWebElement elemento)
        {
            IJavaScriptExecutor je = driver as IJavaScriptExecutor;
            string id = elemento.GetAttribute("id");

            var js = String.Format("document.getElementById('" + id + "').focus();");
            je.ExecuteScript(js);
        }

        //public void CheckGridView(IWebDriver driver, IWebElement gridView, short columnIndexAuxItem, short columnIndexResultItem, string tarjeta)
        //{
        //    IWebElement chkActivarBloquear = null;

        //    chkActivarBloquear = ElementoCheckGrid(driver, gridView, columnIndexAuxItem, columnIndexResultItem, tarjeta);

        //    PulsarBoton(chkActivarBloquear);

        //    Loading(driver, (int)TimerSleepType.sleepTimerFast);

        //}

        private IWebElement ElementoCheckGrid(IWebDriver driver, IWebElement gridView, short columnIndexAuxItem, short columnIndexResultItem, string tarjeta)
        {
            IWebElement ElementoGridBloquear = null;
            IWebElement elementoChkBloquear = null;
            IList<IWebElement> lstRows = null;
            int limitRows = 0;

            lstRows = gridView.FindElements(By.TagName("tr"));

            limitRows = lstRows.Count;

            for (int i = 1; i <= limitRows; ++i)
            {
                try
                {
                    ElementoGridBloquear = driver.FindElement(By.XPath(".//div[2]/table/tbody/tr[" + i + "]/td[" + columnIndexAuxItem + "]"));
                }
                catch
                {
                    continue;
                }

                if (ElementoGridBloquear.Displayed)
                {
                    if (ElementoGridBloquear.Text.Equals(tarjeta))
                    {
                        elementoChkBloquear = driver.FindElement(By.XPath(".//div[2]/table/tbody/tr[" + i + "]/td[" + columnIndexResultItem + "]/input"));

                        break;
                    }
                }
            }

            return elementoChkBloquear;
        }

        //public void InputkGridView(IWebDriver driver, IWebElement gridView, short columnIndexAuxItem, short columnIndexResultItem, string tarjeta, string textoInput)
        //{
        //    IWebElement inputGrid = null;

        //    inputGrid = ElementoInputGrid(driver, gridView, columnIndexAuxItem, columnIndexResultItem, tarjeta);

        //    LimpiarYLLenarInput(inputGrid, textoInput);

        //    Loading(driver, (int)TimerSleepType.sleepTimerFast);

        //}

        private IWebElement ElementoInputGrid(IWebDriver driver, IWebElement gridView, short columnIndexAuxItem, short columnIndexResultItem, string tarjeta)
        {
            IWebElement ElementoGridBloquear = null;
            IWebElement elementoInputBloquear = null;
            IList<IWebElement> lstRows = null;
            int limitRows = 0;

            lstRows = gridView.FindElements(By.TagName("tr"));

            limitRows = lstRows.Count;

            for (int i = 1; i <= limitRows; ++i)
            {
                try
                {
                    ElementoGridBloquear = driver.FindElement(By.XPath(".//div[2]/table/tbody/tr[" + i + "]/td[" + columnIndexAuxItem + "]"));
                }
                catch
                {
                    continue;
                }

                if (ElementoGridBloquear.Displayed)
                {
                    if (ElementoGridBloquear.Text.Equals(tarjeta))
                    {
                        elementoInputBloquear = driver.FindElement(By.XPath(".//div[2]/table/tbody/tr[" + i + "]/td[" + columnIndexResultItem + "]/input"));

                        break;
                    }
                }
            }

            return elementoInputBloquear;
        }

        public string TextoElementoGridView(IWebDriver driver, IWebElement grid, short columnIndexAuxItem, short columnIndexResultItem, string tarjeta)
        {
            IWebElement ElementoGridBloquear = null;
            IWebElement elementoBtnBloquear = null;
            IList<IWebElement> lstRows = grid.FindElements(By.TagName("tr"));
            int limitRows = lstRows.Count;

            for (int i = 1; i < limitRows; ++i)
            {
                try
                {
                    ElementoGridBloquear = grid.FindElement(By.XPath(".//div[2]/table/tbody/tr[" + i + "]/td[" + columnIndexAuxItem + "]"));
                }
                catch
                {
                    continue;
                }

                if (ElementoGridBloquear.Displayed)
                {
                    if (ElementoGridBloquear.Text.Equals(tarjeta))
                    {
                        elementoBtnBloquear = grid.FindElement(By.XPath(".//div[2]/table/tbody/tr[" + i + "]/td[" + columnIndexResultItem + "]"));

                        break;
                    }
                }
            }

            return elementoBtnBloquear.Text;
        }

        public void FechaCalendario(IWebDriver driver, IWebElement tBox, string fecha)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            string id = tBox.GetAttribute("id");
            string script = String.Format("document.getElementById('{0}').setAttribute('value', '{1}')", id, fecha);

            js.ExecuteScript("" + script + "");
        }
    }
}
