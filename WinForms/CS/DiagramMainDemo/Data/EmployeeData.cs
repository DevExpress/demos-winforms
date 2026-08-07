using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
#if NET
using Microsoft.EntityFrameworkCore;
#else
using System.Data.SQLite;
#endif

namespace DevExpress.Diagram.Demos {
    [XmlRoot("Employees")]
    public class EmployeesWithPhotoData
        : List<Employee> {
    }
    public class Employee {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string JobTitle { get; set; }
        public string GroupName { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string StateProvinceName { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegionName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Title { get; set; }
        [XmlIgnore]
        public byte[] CroppedImageData { get; set; }
        public byte[] ImageData { get; set; }
        public override string ToString() {
            return FirstName + " " + LastName;
        }
    }
    public static class EmployeesData {
        public static readonly EmployeesWithPhotoData FilteredEmployees;
        static readonly Lazy<Dictionary<int, Employee>> employees = new Lazy<Dictionary<int, Employee>>(LoadEmployees);

        static EmployeesData() {
            FilteredEmployees = new EmployeesWithPhotoData();
            foreach(var id in filteredIds) {
                Employee employee;
                if(!employees.Value.TryGetValue(id, out employee))
                    continue;
                employee.ParentId = GetParentId(id);
                employee.CroppedImageData = CropImage(employee.ImageData);
                FilteredEmployees.Add(employee);
            }
        }
        public static IEnumerable<object> GetOrgChartEmployees() {
            var allEmployees = new EmployeesWithPhotoData();
            foreach(var employee in employees.Value.Values.OrderBy(x => x.Id)) {
                employee.ParentId = GetParentId(employee.Id);
                allEmployees.Add(employee);
            }
            return allEmployees;
        }

        static Dictionary<int, Employee> LoadEmployees() {
            var result = new Dictionary<int, Employee>();
            string path = DevExpress.Internal.DataDirectoryHelper.GetFile("devav.sqlite3", DevExpress.Internal.DataDirectoryHelper.DataFolderName);
            ClearReadOnly(path);
#if NET
            using(var devAvDb = new DevExpress.DevAV.DevAVDb($"Data Source={path}")) {
                var sources = devAvDb.Employees
                    .Include(e => e.Picture)
                    .ToList();
                foreach(var source in sources) {
                    if(source.Picture == null || source.Picture.Data == null)
                        continue;
                    result[(int)source.Id] = new Employee {
                        Id = (int)source.Id,
                        FirstName = source.FirstName,
                        LastName = source.LastName,
                        JobTitle = source.Title,
                        GroupName = GetDepartmentName(source.Department),
                        Phone = string.IsNullOrEmpty(source.MobilePhone) ? source.HomePhone : source.MobilePhone,
                        EmailAddress = source.Email,
                        AddressLine1 = source.Address != null ? source.Address.Line : null,
                        BirthDate = source.BirthDate ?? default(DateTime),
                        HireDate = source.HireDate ?? default(DateTime),
                        ImageData = source.Picture.Data
                    };
                }
            }
#else
            using(var connection = new SQLiteConnection(new SQLiteConnectionStringBuilder { DataSource = path }.ConnectionString)) {
                connection.Open();
                using(var command = connection.CreateCommand()) {
#pragma warning disable DX0024 // constant query, no user input
                    command.CommandText =
                        "SELECT e.Id, e.FirstName, e.LastName, e.Department, e.Title, " +
                        "e.MobilePhone, e.HomePhone, e.Email, e.Address_Line, e.BirthDate, e.HireDate, p.Data " +
                        "FROM Employees e LEFT JOIN Pictures p ON p.Id = e.PictureId";
                    using(var reader = command.ExecuteReader()) {
#pragma warning restore DX0024 // constant query, no user input
                        while(reader.Read()) {
                            if(reader.IsDBNull(11))
                                continue;
                            var employee = new Employee {
                                Id = (int)reader.GetInt64(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                GroupName = GetDepartmentName((DevExpress.DevAV.EmployeeDepartment)reader.GetInt64(3)),
                                JobTitle = reader.GetString(4),
                                Phone = !reader.IsDBNull(5) ? reader.GetString(5) : (!reader.IsDBNull(6) ? reader.GetString(6) : null),
                                EmailAddress = !reader.IsDBNull(7) ? reader.GetString(7) : null,
                                AddressLine1 = !reader.IsDBNull(8) ? reader.GetString(8) : null,
                                BirthDate = !reader.IsDBNull(9) ? reader.GetDateTime(9) : default(DateTime),
                                HireDate = !reader.IsDBNull(10) ? reader.GetDateTime(10) : default(DateTime),
                                ImageData = (byte[])reader[11]
                            };
                            result[employee.Id] = employee;
                        }
                    }
                }
            }
#endif
            return result;
        }
        static void ClearReadOnly(string path) {
            try {
                var attributes = File.GetAttributes(path);
                if(attributes.HasFlag(FileAttributes.ReadOnly))
                    File.SetAttributes(path, attributes & ~FileAttributes.ReadOnly);
            }
            catch { }
        }
        static string GetDepartmentName(DevExpress.DevAV.EmployeeDepartment department) {
            switch(department) {
                case DevExpress.DevAV.EmployeeDepartment.Sales: return "Sales";
                case DevExpress.DevAV.EmployeeDepartment.Support: return "Support";
                case DevExpress.DevAV.EmployeeDepartment.Shipping: return "Shipping";
                case DevExpress.DevAV.EmployeeDepartment.Engineering: return "Engineering";
                case DevExpress.DevAV.EmployeeDepartment.HumanResources: return "Human Resources";
                case DevExpress.DevAV.EmployeeDepartment.Management: return "Management";
                case DevExpress.DevAV.EmployeeDepartment.IT: return "IT";
                default: return string.Empty;
            }
        }

        static int GetParentId(int id) {
            foreach(var pair in idMap) {
                if(pair.Value.Contains(id))
                    return pair.Key;
            }
            return 0;
        }

        private static byte[] CropImage(byte[] imageBytes) {
            using(var ms = new MemoryStream(imageBytes))
            using(var original = Image.FromStream(ms)) {
                int skipYOffset = 50;
                int cropHeight = 220;
                if(skipYOffset + cropHeight > original.Height)
                    cropHeight = original.Height - skipYOffset;

                var cropArea = new Rectangle(0, skipYOffset, original.Width, cropHeight);
                using(var bmp = new Bitmap(cropArea.Width, cropArea.Height)) {
                    using(var g = Graphics.FromImage(bmp)) {
                        g.DrawImage(original, new Rectangle(0, 0, bmp.Width, bmp.Height), cropArea, GraphicsUnit.Pixel);
                    }

                    using(var output = new MemoryStream()) {
                        bmp.Save(output, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return output.ToArray();
                    }
                }
            }
        }

        static readonly int[] filteredIds = new[] { 1, 2, 3, 4, 5, 6, 30, 8, 9, 10, 32 };

        #region id map
        static readonly Dictionary<int, int[]> idMap = new Dictionary<int, int[]>() {
            { 1, new[] { 2, 3, 4 } },
            { 2, new[] { 5 } },
            { 3, new[] { 32 } },
            { 4, new[] { 8 } },
            { 5, new[] { 11, 26, 27, 7, 30, 9, 10 } },
            { 6, new[] { 21, 22, 23, 24, 25, 28 } },
            { 8, new[] { 12, 20, 40, 41, 42, 43, 44, 45, 47 } },
            { 9, new[] { 17, 18, 19, 31, 39, 46 } },
            { 10, new[] { 13, 14, 15, 16, 49, 50 } },
            { 32, new[] { 33, 34, 36, 37, 48, 51, 6 } },
            { 28, new[] { 29 } },
            { 33, new[] { 38 } },
        };
        #endregion
    }
}
