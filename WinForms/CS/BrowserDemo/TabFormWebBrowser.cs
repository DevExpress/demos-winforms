using System;
using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.BrowserDemo {
    public class TabFormWebBrowser : WebBrowser {
        TabFormPage pageCore;
        public TabFormWebBrowser(TabFormPage page)
            : base() {
            this.pageCore = page;
        }
        public TabFormPage Page {
            get { return pageCore; }
        }
        protected override void OnDocumentCompleted(WebBrowserDocumentCompletedEventArgs e) {
            base.OnDocumentCompleted(e);
            OnDocumentCompletedCore(e);
        }
        protected async void OnDocumentCompletedCore(WebBrowserDocumentCompletedEventArgs e) {
            if(Page == null || e.Url == null || string.IsNullOrEmpty(e.Url.Host) || Url == null || !object.Equals(Url.Host, e.Url.Host))
                return;
            try {
                var favicon = await Favicon.QueryAsync(e.Url);
                if(favicon != null && !favicon.Failed)
                    Page.Image = favicon.Image;
            }
            catch { }
        }
        protected override void OnDocumentTitleChanged(System.EventArgs e) {
            base.OnDocumentTitleChanged(e);
            OnDocumentTitleChangedCore();
        }
        protected void OnDocumentTitleChangedCore() {
            if(Page == null || string.IsNullOrEmpty(DocumentTitle))
                return;
            Page.Text = DocumentTitle;
        }
        //
        sealed class Favicon {
            public static async Task<Favicon> QueryAsync(Uri uri) {
                string iconURL = "http://" + uri.Host + "/favicon.ico";
                return await DevExpress.Data.Utils.AsyncDownloader<Favicon>.LoadAsync(iconURL,
                        (exception, stream) => new Favicon(exception, stream), CancellationToken.None)
                    .ConfigureAwait(false);
            }
            //
            readonly Exception exception;
            Favicon(ExceptionDispatchInfo exceptionInfo, Stream stream) {
                this.exception = exceptionInfo?.SourceException;
                if(exception == null && stream != null) {
                    try {
                        this.Image = Image.FromStream(stream);
                    }
                    catch(Exception e) { exception = e; }
                }
            }
            public bool Failed {
                get { return (exception != null) || (Image == null); }
            }
            public Image Image {
                get;
                private set;
            }
        }
    }
}
