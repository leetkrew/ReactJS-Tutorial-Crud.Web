using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Crud.Web.Models
{
    public class DisplayViewModel
    {

        public string JsxSource { get; set; }
        public string JsxFileName { get; set; }

        public DisplayViewModel(string actionName)
        {
            var jsxFile = string.Format("{0}Scripts\\jsx\\{1}.jsx", AppDomain.CurrentDomain.BaseDirectory, actionName);

            if (File.Exists(jsxFile))
            {
                var reader = File.OpenText(jsxFile);
                this.JsxSource = reader.ReadToEnd();
                this.JsxFileName = string.Format("{0}.jsx", actionName);
                reader.Close();
                reader.Dispose();
            }


        }

    }
}