using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DevAV;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using Message = DevExpress.WindowsMailClient.Win.Data.Message;
#if !NET
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif

namespace DevExpress.WindowsMailClient.Win.Model {
    class MailClientDataModel {
        static BindingList<Employee> _employees = null;
        static List<Message> _messages = null;
        internal static DataTable MailTable {
            get {
                const string table = "Messages";
                return CreateDataTable(table);
            }
        }
        public static List<Message> Messages {
            get {
                try {
                    if(_messages == null) {
                        _messages = new List<Message>();
                        DataTable tbl = MailTable;
                        if(tbl != null) {
                            for(int i = 0; i < tbl.Rows.Count; i++) {
                                Message message = new Message(tbl.Rows[i]);
                                _messages.Add(message);
                            }
                            foreach(DataRow row in tbl.Rows) {
                                _messages.Add(new Message(row));
                            }
                        }
                    }
                }
                catch(Exception e) {
                    XtraMessageBox.Show(e.Message, e.Source);
                    _messages = new List<Message>();
                }
                return _messages;
            }
        }
        internal static BindingList<Employee> Employees {
            get {
                if(_employees == null) {
#if !NET
                    DevAVDb devAvDb = new DevAVDb();
#else
                    DevAVDb devAvDb = new DevAVDb($"Data Source={Internal.DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#endif
                    devAvDb.Employees.Load();
                    _employees = devAvDb.Employees.Local.ToBindingList();
                }
                return _employees;
            }
        }
        public static string GetNameByEmail(string email) {
            Employee employee = Employees.FirstOrDefault(p => p.Email == email);
            return (employee != null) ? employee.FullName : string.Empty;
        }
        public static Image GetPhotoByEmail(string email) {
            Employee employee = Employees.FirstOrDefault(p => p.Email == email);
            if(employee == null || employee.Picture == null)
                return null;
            Bitmap clippedImage = new Bitmap(employee.Photo);
            using(Graphics g = Graphics.FromImage(clippedImage)) {
                using(GraphicsCache gCache = new GraphicsCache(g)) {
                    using(GraphicsPath path = new GraphicsPath()) {
                        int indent = 4;
                        int size = Math.Max(1, Math.Min(clippedImage.Width, clippedImage.Height) - indent * 3);
                        path.AddEllipse(indent, indent, size, size);
                        gCache.DrawPath(Pens.Gray, path);
                    }
                }
            }
            return clippedImage;
        }
        static DataTable CreateDataTable(string table) {
            DataSet dataSet = new DataSet();
            string dataFile = DevAVDataDirectoryHelper.GetFile("MailDevAv.xml");
            if(dataFile != string.Empty) {
                FileInfo fi = new FileInfo(dataFile);
                dataSet.ReadXml(fi.FullName);
                return dataSet.Tables[table];
            }
            return null;
        }
        static Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
        public static Bitmap CreateSenderImage(string sender, Size size, LookAndFeel.UserLookAndFeel ulf) {
            Bitmap image = null;
            if(images.TryGetValue(sender, out image))
                return image;
            if(size.Width != size.Height) {
                int max = Math.Max(size.Width, size.Height);
                size = new Size(max, max);
            }
            Size imageSize = new Size(size.Width, size.Height);
            string[] parsedText = sender.Split(' ');
            string result = string.Empty;
            int count = 0;
            for(int i = 0; i < parsedText.Length; i++) {
                if(parsedText[i].Length > 0) {
                    result += parsedText[i][0];
                    count++;
                    if(count == 2) break;
                }
            }
            image = GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result);
            images.Add(sender, image);
            return image;
        }
    }
}
