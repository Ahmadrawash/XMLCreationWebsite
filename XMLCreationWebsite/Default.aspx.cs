/*
 * author: Dr. Ahmad Rawashdeh
 * course: Web Technology BIT 386
  */

using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace GoogleAPIWebsite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            


            String prod1 = "";
            String prod2 = ""; 
            String prod3 = "";
            String results = "";


            //get the text of the textboxes (query, cx, and key)
            prod1 = product1TextBox.Text.Trim();
            prod2 = product2TextBox.Text.Trim();
            prod3 = product3TextBox.Text.Trim();

          
            ////error checking
            //if (prod1 == null || prod1.Equals(""))
            //{
            //    outputLabel.Text = "error: prod1 is empty";
            //    return;
            //}
            //if (prod2 == null || prod2.Equals(""))
            //{
            //    outputLabel.Text = "error: prod2 is empty";
            //    return;
            //}
            //if (prod3 == null || prod3.Equals(""))
            //{
            //    outputLabel.Text = "error: prod3 is empty";
            //    return;
            //}

            
            //start using the Goolge API search
            try
            {

                XmlDocument doc = new XmlDocument();

                //(1) the xml declaration is recommended, but not mandatory
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);

                //(2) string.Empty makes cleaner code
                XmlElement element1 = doc.CreateElement(string.Empty, "order", string.Empty);
                doc.AppendChild(element1);

                //invoice (billing) address
                XmlElement element2 = doc.CreateElement(string.Empty, "invoiceAddress", string.Empty);
                element1.AppendChild(element2);

                XmlElement elementstr = doc.CreateElement(string.Empty, "street", string.Empty);
                XmlText text1 = doc.CreateTextNode("123 High Street");
                elementstr.AppendChild(text1);
                element2.AppendChild(elementstr);

                XmlElement elementtown = doc.CreateElement(string.Empty, "Town", string.Empty);
                XmlText text11 = doc.CreateTextNode("Anytown");
                elementtown.AppendChild(text11);
                element2.AppendChild(elementtown);

                XmlElement elementPostcode = doc.CreateElement(string.Empty, "Postcode", string.Empty);
                XmlText text111 = doc.CreateTextNode("AB12 3CD");
                elementstr.AppendChild(text111);
                element2.AppendChild(elementPostcode);

                //shipping address
                XmlElement element3 = doc.CreateElement(string.Empty, "ShippingAddress", string.Empty);
                element1.AppendChild(element3);

                XmlElement elementstreet = doc.CreateElement(string.Empty, "Street", string.Empty);
                XmlText text1111 = doc.CreateTextNode("45 Low Road");
                elementstreet.AppendChild(text1111);
                element3.AppendChild(elementstreet);

                XmlElement elementTown2 = doc.CreateElement(string.Empty, "Town", string.Empty);
                XmlText text11111 = doc.CreateTextNode("Coketown");
                elementTown2.AppendChild(text11111);
                element3.AppendChild(elementTown2);

                XmlElement elementPostCode2 = doc.CreateElement(string.Empty, "PostCode", string.Empty);
                XmlText text111111 = doc.CreateTextNode("EF45 6GH");
                elementPostCode2.AppendChild(text111111);
                element3.AppendChild(elementPostCode2);

                //XmlElement element3 = doc.CreateElement(string.Empty, "level2", string.Empty);
                //XmlText text1 = doc.CreateTextNode("text");
                //element3.AppendChild(text1);
                //element2.AppendChild(element3);

                //XmlElement element4 = doc.CreateElement(string.Empty, "level2", string.Empty);
                //XmlText text2 = doc.CreateTextNode("other text");
                //element4.AppendChild(text2);
                //element2.AppendChild(element4);

                //order
                XmlElement element4 = doc.CreateElement(string.Empty, "line", string.Empty);
                element1.AppendChild(element4);

                XmlElement elementItem = doc.CreateElement(string.Empty, "item", string.Empty);
                XmlText text2 = doc.CreateTextNode("Widget");
                elementItem.AppendChild(text2);
                element4.AppendChild(elementItem);

                XmlElement elementSize = doc.CreateElement(string.Empty, "Size", string.Empty);
                XmlText text22 = doc.CreateTextNode("10");
                elementSize.AppendChild(text22);
                element4.AppendChild(elementSize);

                XmlElement elementQuantity = doc.CreateElement(string.Empty, "Quantity", string.Empty);
                XmlText text222 = doc.CreateTextNode("100");
                elementQuantity.AppendChild(text222);
                element4.AppendChild(elementQuantity);

                doc.Save("C:\\Users\\ahmed\\Documents\\xml\\order.xml");


                ////(2) string.Empty makes cleaner code
                //XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
                //doc.AppendChild(element1);

                //XmlElement element2 = doc.CreateElement(string.Empty, "level1", string.Empty);
                //element1.AppendChild(element2);

                //XmlElement element3 = doc.CreateElement(string.Empty, "level2", string.Empty);
                //XmlText text1 = doc.CreateTextNode("text");
                //element3.AppendChild(text1);
                //element2.AppendChild(element3);

                //XmlElement element4 = doc.CreateElement(string.Empty, "level2", string.Empty);
                //XmlText text2 = doc.CreateTextNode("other text");
                //element4.AppendChild(text2);
                //element2.AppendChild(element4);

                //doc.Save("C:\\Users\\ahmed\\Documents\\xml\\data.xml");                                       
                return;
            }

            catch (Exception exc)
            {
                outputLabel.Text = "Exeption: " + exc.Message + "\n" + exc.StackTrace;
            }

        }

    }
}