using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Rows;

namespace DevExpress.XtraVerticalGrid.Demos {
    public class ComputersData {
        public static List<PCConfiguration> InitOrdersData(string fileName, VGridControl vGridControl, int count) {
            var computers = InitXMLDataCore(fileName, count);
            var configurations = CreatePCConfigurations(computers, computers.Count);
            vGridControl.DataSource = configurations;
            return configurations;
        }
        static List<Computer> InitXMLDataCore(string fileName, int count) {
            DataSet ds = new DataSet();
            //var computersTable = "Computers";
            var gamingChassisTable = "GamingChassis";
            var memorySizesTable = "MemorySizes";
            var memoryTypesTable = "MemoryTypes";
            var motherboardsTable = "Motherboards";
            var powerSuppliesTable = "PowerSupplies";
            var processorsTable = "Processors";
            var ramsTable = "RAMs";
            var trademarksTable = "Trademarks";
            var videoCardsTable = "VideoCards";

            ds.ReadXml(fileName);

            var trademarks = new List<Trademark>();
            var memoryTypes = new List<MemoryType>();
            var memorySizes = new List<MemorySize>();
            var computers = new List<Computer>();
            var processors = new List<Processor>();
            var motherboards = new List<Motherboard>();
            var videoCards = new List<VideoCard>();
            var gamingChassis = new List<GamingChassis>();
            var rams = new List<RAM>();
            var powerSupplies = new List<PowerSupply>();
            
            foreach(DataRow row in ds.Tables[trademarksTable].Rows) {
                trademarks.Add(new Trademark() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                });
            }
            foreach(DataRow row in ds.Tables[memorySizesTable].Rows) {
                memorySizes.Add(new MemorySize() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                });
            }
            foreach(DataRow row in ds.Tables[memoryTypesTable].Rows) {
                memoryTypes.Add(new MemoryType() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                });
            }
            foreach(DataRow row in ds.Tables[processorsTable].Rows) {
                processors.Add(new Processor() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Price = (decimal)row["Price"],
                    Trademark = trademarks.First(x => x.Id == (int)row["TrademarkId"]).Name,
                    Socket = (string)row["Socket"],
                    BaseFrequency = (string)row["BaseFrequency"],
                    MaxFrequency = (string)row["MaxFrequency"],
                    NumberCores = (int)row["NumberCores"],
                    TDP = (string)row["TDP"],
                    ReleaseYear = (int)row["ReleaseYear"],
                    AverageRating = (float)row["AverageRating"]
                });
            }
            foreach(DataRow row in ds.Tables[motherboardsTable].Rows) {
                motherboards.Add(new Motherboard() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Price = (decimal)row["Price"],
                    Trademark = trademarks.First(x => x.Id == (int)row["TrademarkId"]).Name,
                    Socket = (string)row["Socket"],
                    Chipset = (string)row["Chipset"],
                    FormFactor = (string)row["FormFactor"],
                    MinMemoryFrequency = (string)row["MinMemoryFrequency"],
                    MaxMemoryFrequency = (string)row["MaxMemoryFrequency"],
                    NetworkAdapterChipset = (string)row["NetworkAdapterChipset"],
                    AmountMemorySlots = (int)row["AmountMemorySlots"],
                    SoundAdapterChipset = (string)row["SoundAdapterChipset"],
                    SoundScheme = (string)row["SoundScheme"],
                    ReleaseYear = (int)row["ReleaseYear"],
                    AverageRating = (float)row["AverageRating"]
                });
            }
            foreach(DataRow row in ds.Tables[videoCardsTable].Rows) {
                videoCards.Add(new VideoCard() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Price = (decimal)row["Price"],
                    Trademark = trademarks.First(x => x.Id == (int)row["TrademarkId"]).Name,
                    GraphicsProcessor = (string)row["GraphicsProcessor"],
                    MaximumResolution = (string)row["MaximumResolution"],
                    MemorySize = memorySizes.First(x => x.Id == (int)row["MemorySizeId"]).Name,
                    MemoryType = memoryTypes.First(x => x.Id == (int)row["MemoryTypeId"]).Name,
                    ConnectionInterface = (string)row["ConnectionInterface"],
                    NominalFrequencyVideoChip = (string)row["NominalFrequencyVideoChip"],
                    TurboFrequency = (string)row["TurboFrequency"],
                    ReleaseYear = (int)row["ReleaseYear"],
                    AverageRating = (float)row["AverageRating"]
                });
            }
            foreach(DataRow row in ds.Tables[gamingChassisTable].Rows) {
                gamingChassis.Add(new GamingChassis() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Price = (decimal)row["Price"],
                    Trademark = trademarks.First(x => x.Id == (int)row["TrademarkId"]).Name,
                    Backlight = (string)row["Backlight"],
                    Type = (string)row["Type"],
                    ReleaseYear = (int)row["ReleaseYear"],
                    AverageRating = (float)row["AverageRating"]
                });
            }
            foreach(DataRow row in ds.Tables[ramsTable].Rows) {
                rams.Add(new RAM() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Price = (decimal)row["Price"],
                    Trademark = trademarks.First(x => x.Id == (int)row["TrademarkId"]).Name,
                    MemorySize = memorySizes.First(x => x.Id == (int)row["MemorySizeId"]).Name,
                    MemoryType = memoryTypes.First(x => x.Id == (int)row["MemoryTypeId"]).Name,
                    ClockFrequency = (string)row["ClockFrequency"],
                    ReleaseYear = (int)row["ReleaseYear"],
                    AverageRating = (float)row["AverageRating"]
                });
            }
            foreach(DataRow row in ds.Tables[powerSuppliesTable].Rows) {
                powerSupplies.Add(new PowerSupply() {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Price = (decimal)row["Price"],
                    Power = (string)row["Power"],
                    CPUPowerConnectors = (string)row["CPUPowerConnectors"],
                    VideoCardPowerConnectors = (string)row["VideoCardPowerConnectors"],
                    Trademark = trademarks.First(x => x.Id == (int)row["TrademarkId"]).Name,
                    ReleaseYear = (int)row["ReleaseYear"],
                    AverageRating = (float)row["AverageRating"]
                });
            }
            int _processorId, _motherboardId, _gamingChassisId, _videoCardId, _RAMId, _powerSupplyId;
            for(int i = 1; i < count; i++) {
                _processorId = TutorialConstants.Random.Next(1, 7);
                _motherboardId = TutorialConstants.Random.Next(1, 5);
                _gamingChassisId = TutorialConstants.Random.Next(1, 20);
                _videoCardId = TutorialConstants.Random.Next(1, 6);
                _RAMId = TutorialConstants.Random.Next(1, 7);
                _powerSupplyId = TutorialConstants.Random.Next(1, 5);
                Computer temp = new Computer() {
                    Id = i,
                    ProcessorId = _processorId,
                    MotherboardId = _motherboardId,
                    GamingChassisId = _gamingChassisId,
                    VideoCardId = _videoCardId,
                    RAMId = _RAMId,
                    PowerSupplyId = _powerSupplyId,
                    Processor = processors.First(x => x.Id == _processorId),
                    Motherboard = motherboards.First(x => x.Id == _motherboardId),
                    VideoCard = videoCards.First(x => x.Id == _videoCardId),
                    GamingChassis = gamingChassis.First(x => x.Id == _gamingChassisId),
                    RAM = rams.First(x => x.Id == _RAMId),
                    PowerSupply = powerSupplies.First(x => x.Id == _powerSupplyId),
                    Price = 0,
                    AverageRating = 1
                };
                temp.Price = GetMinPrice(temp);
                temp.AverageRating = GetAvgRating(temp);
                computers.Add(temp);
            }
            return computers;
        }

        static decimal GetMinPrice(Computer comp) {
            return comp.Processor.Price + comp.Motherboard.Price + comp.VideoCard.Price + comp.GamingChassis.Price + comp.RAM.Price + comp.PowerSupply.Price;
        }
        static float GetAvgRating(Computer comp) {
            return (comp.Processor.AverageRating + comp.Motherboard.AverageRating + comp.VideoCard.AverageRating + comp.GamingChassis.AverageRating + comp.RAM.AverageRating + comp.PowerSupply.AverageRating) / 6;
        }
        static List<PCConfiguration> CreatePCConfigurations(List<Computer> computers, int itemCount) {
            var data = new List<PCConfiguration>(itemCount);
            for(int i = 0; i < itemCount; i++) 
                data.Add(new PCConfiguration(computers[TutorialConstants.Random.Next(0, computers.Count - 1)], i + 1, TutorialConstants.Random));
            return data;
        }
        public static void InitEditors(VGridControl vGridControl) {
            if(vGridControl.Rows.Count == 0)
                return;
            foreach(var row in vGridControl.Rows)
                SetRowEditorProperties(row, vGridControl);
        }
        static void SetRowEditorProperties(BaseRow row, VGridControl vGridControl) {
            if(row is EditorRow)
                SetEditorProperties(row.Properties, vGridControl);
            if(row is CategoryRow) {
                var category = row as CategoryRow;
                if(category.HasChildren)
                    SetChildRowsEditorProperties(category.ChildRows, vGridControl);
            }
            if(row is MultiEditorRow) {
                var multiEditorRow = row as MultiEditorRow;
                if(multiEditorRow.HasChildren)
                    SetChildRowsEditorProperties(multiEditorRow.ChildRows, vGridControl);
                if(multiEditorRow.PropertiesCollection.Count > 0)
                    SetEditorPropertiesCollection(multiEditorRow.PropertiesCollection, vGridControl);
            }
        }
        static void SetEditorProperties(RowProperties rowProperties, VGridControl vGridControl) {
            RepositoryItem item = GetEditByFielsName(rowProperties.FieldName, vGridControl.RepositoryItems);
            if(item != null && rowProperties.RowEdit == null)
                rowProperties.RowEdit = item;
        }
        static void SetChildRowsEditorProperties(VGridRows childRows, VGridControl vGridControl) {
            foreach(var row in childRows)
                SetRowEditorProperties(row, vGridControl);
        }
        static void SetEditorPropertiesCollection(MultiEditorRowPropertiesCollection propertiesCollection, VGridControl vGridControl) {
            foreach(RowProperties rowProperties in propertiesCollection)
                SetEditorProperties(rowProperties, vGridControl);
        }
        static RepositoryItem GetEditByFielsName(string fieldName, RepositoryItemCollection repositoryItemCollection) {
            foreach(RepositoryItem item in repositoryItemCollection)
                if(item.Name.IndexOf("/" + fieldName) >= 0)
                    return item;
            return null;
        }
        #region Data
        public class Computer {
            public int Id { get; set; }
            public int ProcessorId { get; set; }
            public int MotherboardId { get; set; }
            public int GamingChassisId { get; set; }
            public int VideoCardId { get; set; }
            public int RAMId { get; set; }
            public int PowerSupplyId { get; set; }
            public decimal Price { get; set; }
            public float AverageRating { get; set; }
            public Processor Processor { get; set; }
            public Motherboard Motherboard { get; set; }
            public VideoCard VideoCard { get; set; }
            public GamingChassis GamingChassis { get; set; }
            public RAM RAM { get; set; }
            public PowerSupply PowerSupply { get; set; }
        }
        public class GamingChassis {
            public int Id { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
            public string Trademark { get; set; }
            public string Type { get; set; }
            public string Backlight { get; set; }
            public int ReleaseYear { get; set; }
            public float AverageRating { get; set; }
        }
        public class MemorySize {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class MemoryType {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Motherboard {
            public int Id { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
            public string Trademark { get; set; }
            public string FormFactor { get; set; }
            public string Socket { get; set; }
            public string Chipset { get; set; }
            public string MinMemoryFrequency { get; set; }
            public string MaxMemoryFrequency { get; set; }
            public int AmountMemorySlots { get; set; }
            public string SoundAdapterChipset { get; set; }
            public string SoundScheme { get; set; }
            public string NetworkAdapterChipset { get; set; }
            public int ReleaseYear { get; set; }
            public float AverageRating { get; set; }
        }
        public class PowerSupply {
            public int Id { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
            public string Trademark { get; set; }
            public string Power { get; set; }
            public string CPUPowerConnectors { get; set; }
            public string VideoCardPowerConnectors { get; set; }
            public int ReleaseYear { get; set; }
            public float AverageRating { get; set; }
        }
        public class Processor {
            public int Id { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
            public string Trademark { get; set; }
            public string Socket { get; set; }
            public string BaseFrequency { get; set; }
            public string MaxFrequency { get; set; }
            public int NumberCores { get; set; }
            public string TDP { get; set; }
            public int ReleaseYear { get; set; }
            public float AverageRating { get; set; }
        }
        public class RAM {
            public int Id { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
            public string Trademark { get; set; }
            public string MemoryType { get; set; }
            public string MemorySize { get; set; }
            public string ClockFrequency { get; set; }
            public int ReleaseYear { get; set; }
            public float AverageRating { get; set; }
        }
        public class Trademark {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Site { get; set; }
        }
        public class VideoCard {
            public int Id { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
            public string GraphicsProcessor { get; set; }
            public string NominalFrequencyVideoChip { get; set; }
            public string TurboFrequency { get; set; }
            public string Trademark { get; set; }
            public string MemoryType { get; set; }
            public string MemorySize { get; set; }
            public string ConnectionInterface { get; set; }
            public string MaximumResolution { get; set; }
            public int ReleaseYear { get; set; }
            public float AverageRating { get; set; }
        }
        public class PCConfiguration {
            public PCConfiguration(Computer computer, int id, DevExpress.Data.Utils.NonCryptographicRandom rnd) {
                ComputerId = id;
                // Processor
                var processor = computer.Processor;
                ProcName = processor.Name;
                ProcPrice = processor.Price;
                ProcTrademark = processor.Trademark;
                ProcSocket = processor.Socket;
                ProcBaseFrequency = processor.BaseFrequency;
                ProcMaxFrequency = processor.MaxFrequency;
                ProcNumberCores = processor.NumberCores;
                ProcTDP = processor.TDP;
                ProcReleaseYear = processor.ReleaseYear;
                ProcAverageRating = processor.AverageRating;
                // Motherboard
                var motherboard = computer.Motherboard;
                MotName = motherboard.Name;
                MotPrice = motherboard.Price;
                MotTrademark = motherboard.Trademark;
                MotFormFactor = motherboard.FormFactor;
                MotSocket = motherboard.Socket;
                MotChipset = motherboard.Chipset;
                MotMinMemoryFrequency = motherboard.MinMemoryFrequency;
                MotMaxMemoryFrequency = motherboard.MaxMemoryFrequency;
                MotAmountMemorySlots = motherboard.AmountMemorySlots;
                MotSoundAdapterChipset = motherboard.SoundAdapterChipset;
                MotSoundScheme = motherboard.SoundScheme;
                MotNetworkAdapterChipset = motherboard.NetworkAdapterChipset;
                MotReleaseYear = motherboard.ReleaseYear;
                MotAverageRating = motherboard.AverageRating;
                // Video Card
                var videoCard = computer.VideoCard;
                VidName = videoCard.Name;
                VidPrice = videoCard.Price;
                VidTrademark = videoCard.Trademark;
                VidGraphicsProcessor = videoCard.GraphicsProcessor;
                VidNominalFrequencyVideoChip = videoCard.NominalFrequencyVideoChip;
                VidTurboFrequency = videoCard.TurboFrequency;
                VidMemoryType = videoCard.MemoryType;
                VidMemorySize = videoCard.MemorySize;
                VidConnectionInterface = videoCard.ConnectionInterface;
                VidMaximumResolution = videoCard.MaximumResolution;
                VidReleaseYear = videoCard.ReleaseYear;
                VidAverageRating = videoCard.AverageRating;
                // Gaming Chassis
                var gamingChassis = computer.GamingChassis;
                GamName = gamingChassis.Name;
                GamPrice = gamingChassis.Price;
                GamTrademark = gamingChassis.Trademark;
                GamReleaseYear = gamingChassis.ReleaseYear;
                GamType = gamingChassis.Type;
                GamBacklight = gamingChassis.Backlight;
                GamAverageRating = gamingChassis.AverageRating;
                // RAM
                var ram = computer.RAM;
                RamName = ram.Name;
                RamPrice = ram.Price;
                RamTrademark = ram.Trademark;
                RamMemoryType = ram.MemoryType;
                RamMemorySize = ram.MemorySize;
                RamClockFrequency = ram.ClockFrequency;
                RamReleaseYear = ram.ReleaseYear;
                RamAverageRating = ram.AverageRating;
                // Power Supply
                var powerSupply = computer.PowerSupply;
                PowName = powerSupply.Name;
                PowPrice = powerSupply.Price;
                PowTrademark = powerSupply.Trademark;
                PowPower = powerSupply.Power;
                PowCPUPower = powerSupply.CPUPowerConnectors;
                PowVideoCard = powerSupply.VideoCardPowerConnectors;
                PowReleaseYear = powerSupply.ReleaseYear;
                PowAverageRating = powerSupply.AverageRating;
                //
                Discount = Math.Round(0.1 * rnd.Next(1, 5), 2);
                ModelPrice = decimal.Round(computer.Price - (computer.Price * (decimal)Discount), 2);
                decimal rating =
                    (decimal)processor.AverageRating * 10.0m +
                    (decimal)videoCard.AverageRating * 9.0m +
                    (decimal)ram.AverageRating * 8.0m +
                    (decimal)motherboard.AverageRating * 7.0m +
                    (decimal)powerSupply.AverageRating * 6.0m +
                    (decimal)gamingChassis.AverageRating * 5.0m;
                AverageRating = (float)Math.Round(rating / 45.0m, 2);
            }

            public int ComputerId { get; private set; }
            public double Discount { get; private set; }
            [DataType(DataType.Currency)]
            public decimal ModelPrice { get; private set; }
            public float AverageRating { get; private set; }

            public string ProcName { get; private set; }
            [DataType(DataType.Currency)]
            public decimal ProcPrice { get; private set; }
            public string ProcTrademark { get; private set; }
            public string ProcSocket { get; private set; }
            public string ProcBaseFrequency { get; private set; }
            public string ProcMaxFrequency { get; private set; }
            public int ProcNumberCores { get; private set; }
            public string ProcTDP { get; private set; }
            public int ProcReleaseYear { get; private set; }
            public float ProcAverageRating { get; private set; }

            public string MotName { get; private set; }
            [DataType(DataType.Currency)]
            public decimal MotPrice { get; private set; }
            public string MotTrademark { get; private set; }
            public string MotFormFactor { get; private set; }
            public string MotSocket { get; private set; }
            public string MotChipset { get; private set; }
            public string MotMinMemoryFrequency { get; private set; }
            public string MotMaxMemoryFrequency { get; private set; }
            public int MotAmountMemorySlots { get; private set; }
            public string MotSoundAdapterChipset { get; private set; }
            public string MotSoundScheme { get; private set; }
            public string MotNetworkAdapterChipset { get; private set; }
            public int MotReleaseYear { get; private set; }
            public float MotAverageRating { get; private set; }

            public string VidName { get; private set; }
            [DataType(DataType.Currency)]
            public decimal VidPrice { get; private set; }
            public string VidTrademark { get; private set; }
            public string VidGraphicsProcessor { get; private set; }
            public string VidNominalFrequencyVideoChip { get; private set; }
            public string VidTurboFrequency { get; private set; }
            public string VidMemoryType { get; private set; }
            public string VidMemorySize { get; private set; }
            public string VidConnectionInterface { get; private set; }
            public string VidMaximumResolution { get; private set; }
            public int VidReleaseYear { get; private set; }
            public float VidAverageRating { get; private set; }

            public string GamName { get; private set; }
            [DataType(DataType.Currency)]
            public decimal GamPrice { get; private set; }
            public string GamTrademark { get; private set; }
            public string GamType { get; private set; }
            public string GamBacklight { get; private set; }
            public int GamReleaseYear { get; private set; }
            public float GamAverageRating { get; private set; }

            public string RamName { get; private set; }
            [DataType(DataType.Currency)]
            public decimal RamPrice { get; private set; }
            public string RamTrademark { get; private set; }
            public string RamMemoryType { get; private set; }
            public string RamMemorySize { get; private set; }
            public string RamClockFrequency { get; private set; }
            public int RamReleaseYear { get; private set; }
            public float RamAverageRating { get; private set; }

            public string PowName { get; private set; }
            [DataType(DataType.Currency)]
            public decimal PowPrice { get; private set; }
            public string PowTrademark { get; private set; }
            public string PowPower { get; private set; }
            public string PowCPUPower { get; private set; }
            public string PowVideoCard { get; private set; }
            public int PowReleaseYear { get; private set; }
            public float PowAverageRating { get; private set; }
        }
        #endregion
    }
}
